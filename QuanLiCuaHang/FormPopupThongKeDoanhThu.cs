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
    public partial class FormPopupThongKeDoanhThu : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3DQNFS9;Initial Catalog=QLCH;Integrated Security=True");
        public FormPopupThongKeDoanhThu()
        {
            InitializeComponent();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value < dateTimePicker2.Value)
            {
                if(dateTimePicker2.Value < DateTime.Now)
                {
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT Ngayban, SUM(Tongtien) AS ThanhTien FROM Hoadonban WHERE Ngayban >= '" + dateTimePicker1.Value.ToString("yyyy/MM/dd") + "' AND Ngayban <= '" + dateTimePicker2.Value.ToString("yyyy/MM/dd") + "' GROUP BY Ngayban", con);
                    System.Data.DataTable dt = new System.Data.DataTable();
                    sda.Fill(dt);

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

                    Range row1 = worksheet.get_Range("B2", "I2");
                    row1.Merge();
                    row1.Font.Size = 20;
                    row1.Font.Name = "Times New Roman";
                    row1.Font.Bold = true;
                    row1.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    row1.Value2 = "THỐNG KÊ DOANH THU TỪ NGÀY " + dateTimePicker1.Text + " ĐẾN NGÀY " + dateTimePicker2.Text;

                    worksheet.Cells[5, 4] = "STT";
                    worksheet.Cells[5, 5] = "Ngày";
                    worksheet.Cells[5, 6] = "Doanh thu";
     

                    Range row_Data = worksheet.get_Range("D5", "F5");
                    row_Data.Font.Size = 11;
                    row_Data.Font.Name = "Times New Roman";
                    row1.Font.Bold = true;
                    row_Data.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                    row_Data.Cells.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        worksheet.Cells[6 + i, 4] = (i + 1);
                        worksheet.Cells[6 + i, 5] = dt.Rows[i]["Ngayban"];
                        worksheet.Cells[6 + i, 6] = dt.Rows[i]["ThanhTien"];
                    }

                    //worksheet.Cells[6 + (dt.Rows.Count), 4] = "Tổng tiền";
                    worksheet.Cells[6 + (dt.Rows.Count), 6] = "=SUM(F6:F" + (5 + dt.Rows.Count) + ")";

                    Range row_Last = worksheet.get_Range("D" + (6 + dt.Rows.Count), "E" + (6 + dt.Rows.Count));
                    row_Last.Merge();
                    row_Last.Font.Size = 11;
                    row_Last.Font.Name = "Times New Roman";
                    row_Last.Font.Bold = FontStyle.Bold;
                    row_Last.Font.Italic = FontStyle.Italic;
                    row_Last.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    row_Last.Cells.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                    row_Last.Value2 = "Tổng doanh thu:";

                    Range border_ChiTiet = worksheet.get_Range("D5", "F" + (5 + dt.Rows.Count));
                    border_ChiTiet.Borders.LineStyle = XlLineStyle.xlContinuous;

                    //End. Đổ dữ liệu vào Sheet

                    app.Visible = true;
                }   
                else
                {
                    MessageBox.Show("Ngày kết thúc không quá ngày hiện tại");
                }    
            }
            else
            {
                MessageBox.Show("Ngày bắt đầu không được sau ngày kết thúc");
            }
        }
    }
}
