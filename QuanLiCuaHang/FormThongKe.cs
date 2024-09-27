using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiCuaHang
{
    public partial class FormThongKe : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3DQNFS9;Initial Catalog=QLCH;Integrated Security=True");

        public FormThongKe()
        {
            InitializeComponent();
        }


        private void btn_DoanhThu_Click(object sender, EventArgs e)
        {
            FormPopupThongKeDoanhThu frm = new FormPopupThongKeDoanhThu();
            frm.ShowDialog();
        }

        private void btn_SanPham_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda1 = new SqlDataAdapter("SELECT Tenhang,SUM(CAST(Chitiet_HDBan.Soluong AS INT)) AS Soluong FROM Chitiet_HDBan INNER JOIN Mathang ON Mathang.Mahang = Chitiet_HDBan.Mahang GROUP BY Tenhang ORDER BY Soluong DESC", con);
            System.Data.DataTable dt1 = new System.Data.DataTable();
            sda1.Fill(dt1);

            SqlDataAdapter sda2 = new SqlDataAdapter("SELECT Tenhang,Soluong FROM Mathang ORDER BY Soluong DESC", con);
            System.Data.DataTable dt2 = new System.Data.DataTable();
            sda2.Fill(dt2);

            //Khởi tạo excel
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            //Khởi tạo workbook
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            //Khởi tạo worksheet
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            workbook.Worksheets.Add(Type.Missing);

            worksheet = workbook.Worksheets.get_Item(1);
            //worksheet.Name = comboBox_MaHoaDon.Text;

            worksheet = workbook.ActiveSheet;

            worksheet.Rows.ColumnWidth = 15;

            //Đổ dữ liệu vào Sheet

            Range row1 = worksheet.get_Range("C2", "I2");
            row1.Merge();
            row1.Font.Size = 20;
            row1.Font.Name = "Times New Roman";
            row1.Font.Bold = true;
            row1.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            row1.Value2 = "THỐNG KÊ MẶT HÀNG";

            Range row2 = worksheet.get_Range("C4", "E4");
            row2.Merge();
            row2.Font.Size = 14;
            row2.Font.Name = "Times New Roman";
            row2.Font.Bold = true;
            row2.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            row2.Value2 = "BÁN CHẠY";

            worksheet.Cells[5, 3] = "STT";
            worksheet.Cells[5, 4] = "Tên sản phẩm";
            worksheet.Cells[5, 5] = "Đã bán được";

            Range row3 = worksheet.get_Range("G4", "I4");
            row3.Merge();
            row3.Font.Size = 14;
            row3.Font.Name = "Times New Roman";
            row3.Font.Bold = true;
            row3.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            row3.Value2 = "TỒN KHO";

            worksheet.Cells[5, 7] = "STT";
            worksheet.Cells[5, 8] = "Tên sản phẩm";
            worksheet.Cells[5, 9] = "Số lượng tồn";

            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                worksheet.Cells[6 + i, 3] = (i + 1);
                worksheet.Cells[6 + i, 4] = dt1.Rows[i]["Tenhang"];
                worksheet.Cells[6 + i, 5] = dt1.Rows[i]["Soluong"];
            }

            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                worksheet.Cells[6 + i, 7] = (i + 1);
                worksheet.Cells[6 + i, 8] = dt2.Rows[i]["Tenhang"];
                worksheet.Cells[6 + i, 9] = dt2.Rows[i]["Soluong"];
            }


            Range border_ChiTiet1 = worksheet.get_Range("C5", "E" + (5 + dt1.Rows.Count));
            border_ChiTiet1.Borders.LineStyle = XlLineStyle.xlContinuous;

            Range border_ChiTiet2 = worksheet.get_Range("G5", "I" + (5 + dt2.Rows.Count));
            border_ChiTiet2.Borders.LineStyle = XlLineStyle.xlContinuous;

            //End. Đổ dữ liệu vào Sheet

            app.Visible = true;
        }

    }
}
