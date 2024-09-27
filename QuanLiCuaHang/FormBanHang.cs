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
    public partial class FormBanHang : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3DQNFS9;Initial Catalog=QLCH;Integrated Security=True");
        public FormBanHang()
        {
            InitializeComponent();
        }

        private void FormBanHang_Load(object sender, EventArgs e)
        {
            SqlDataAdapter sda1 = new SqlDataAdapter("SELECT TenNV FROM Nhanvien", con);
            System.Data.DataTable dt1 = new System.Data.DataTable();
            sda1.Fill(dt1);
            comboBox_TenNhanVien.DataSource = dt1;
            comboBox_TenNhanVien.DisplayMember = "TenNV";
            comboBox_TenNhanVien.ValueMember = "TenNV";

            SqlDataAdapter sda2 = new SqlDataAdapter("SELECT Mahang FROM Mathang", con);
            System.Data.DataTable dt2 = new System.Data.DataTable();
            sda2.Fill(dt2);
            comboBox_MaMatHang.DataSource = dt2;
            comboBox_MaMatHang.DisplayMember = "Mahang";
            comboBox_MaMatHang.ValueMember = "Mahang";

            SqlDataAdapter sda3 = new SqlDataAdapter("SELECT MaKH FROM Khachhang", con);
            System.Data.DataTable dt3 = new System.Data.DataTable();
            sda3.Fill(dt3);
            comboBox_MaKH.DataSource = dt3;
            comboBox_MaKH.DisplayMember = "MaKH";
            comboBox_MaKH.ValueMember = "MaKH";

            SqlDataAdapter sda4 = new SqlDataAdapter("SELECT MaHDBan FROM Hoadonban", con);
            System.Data.DataTable dt4 = new System.Data.DataTable();
            sda4.Fill(dt4);
            comboBox_MaHoaDon.DataSource = dt4;
            comboBox_MaHoaDon.DisplayMember = "MaHDBan";
            comboBox_MaHoaDon.ValueMember = "MaHDBan";
            
        }
        private void dinh_dang_tieu_de()
        {
            dataGridView1.Columns[0].HeaderText = "Mã hóa đơn";
            dataGridView1.Columns[0].Width = 250;
            dataGridView1.Columns[1].HeaderText = "Mã hàng";
            dataGridView1.Columns[1].Width = 290;
            dataGridView1.Columns[2].HeaderText = "Đơn giá";
            dataGridView1.Columns[2].Width = 300;
            
        }
        private void btn_ThemNV_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT ISNULL(MAX(CAST(SUBSTRING(MaHDBan, 3, LEN(MaHDBan) - 2) AS INT)) + 1, 1) FROM Hoadonban", con);
            System.Data.DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);

            comboBox_MaHoaDon.Text = "HD" + dt.Rows[0][0];

            SqlCommand cmd = new SqlCommand("INSERT INTO Hoadonban VALUES('" + comboBox_MaHoaDon.Text + "','" + dateTimePicker_NgayXuatHang.Value.ToString("yyyy-MM-dd") + "',N'" + txb_MaNV.Text + "',N'" + comboBox_MaKH.Text + "','" + textBox_ThanhTien.Text + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            SqlDataAdapter sda_ChiTiet = new SqlDataAdapter("SELECT * FROM Chitiet_HDBan WHERE MaHDBan = '" + comboBox_MaHoaDon.Text + "'", con);
            System.Data.DataTable dt_ChiTiet = new System.Data.DataTable();
            sda_ChiTiet.Fill(dt_ChiTiet);

            dataGridView1.DataSource = dt_ChiTiet;
        }

        private void comboBox_TenNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT TOP(1) MaNV FROM Nhanvien WHERE TenNV = N'" + comboBox_TenNhanVien.Text + "'", con);
            System.Data.DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);
            if(dt.Rows.Count>0)
                txb_MaNV.Text = dt.Rows[0][0].ToString();
        }

        private void comboBox_TenMatHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT TOP(1) Giaban FROM Mathang WHERE Mahang = N'" + comboBox_MaMatHang.Text + "'", con);
            System.Data.DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                comboBox_DonGia.Text = dt.Rows[0][0].ToString();
                textBox_ThanhTien.Text = (Convert.ToDouble(numericUpDown_SoLuong.Value) * Convert.ToDouble(dt.Rows[0][0])).ToString();
            }
        }

        private void btn_ThemHangHoa_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT Soluong FROM Mathang WHERE Mahang = N'" + comboBox_MaMatHang.Text + "'", con);
            System.Data.DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);

            if(Convert.ToInt32(dt.Rows[0][0]) >= numericUpDown_SoLuong.Value)
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Chitiet_HDBan VALUES( '" + comboBox_MaHoaDon.Text + "' ,'" + comboBox_MaMatHang.Text + "',N'" + numericUpDown_SoLuong.Text + "',N'')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                SqlCommand cmd_1 = new SqlCommand("UPDATE Mathang SET Soluong = Soluong - '" + numericUpDown_SoLuong.Text + "' WHERE Mahang = '" + comboBox_MaMatHang.Text + "'", con);
                con.Open();
                cmd_1.ExecuteNonQuery();
                con.Close();
            }
            else
            {
                MessageBox.Show("Không đủ số lượng sản phẩm để xuất hóa đơn");
            }    

            FormBanHang_Load(sender, e);
        }

        private void btn_XoaHD_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("DELETE Chitiet_HDBan WHERE MaHDBan = '" + comboBox_MaHoaDon.Text + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            SqlCommand cmd1 = new SqlCommand("DELETE Hoadonban WHERE MaHDBan = '" + comboBox_MaHoaDon.Text + "'", con);
            con.Open();
            cmd1.ExecuteNonQuery();
            con.Close();
        }

        private void btn_In_Click(object sender, EventArgs e)
        {
            if (comboBox_MaHoaDon.Text != "")
            {

                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Hoadonban WHERE MaHDBan = '" + comboBox_MaHoaDon.Text + "'", con);
                System.Data.DataTable dt = new System.Data.DataTable();
                sda.Fill(dt);

                SqlDataAdapter sda_ChiTiet = new SqlDataAdapter("SELECT * FROM Chitiet_HDBan INNER JOIN Mathang ON Chitiet_HDBan.Mahang = Mathang.Mahang WHERE MaHDBan = '" + comboBox_MaHoaDon.Text + "'", con);
                System.Data.DataTable dt_ChiTiet = new System.Data.DataTable();
                sda_ChiTiet.Fill(dt_ChiTiet);

                //Khởi tạo excel
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                //Khởi tạo workbook
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                //Khởi tạo worksheet
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

                workbook.Worksheets.Add(Type.Missing);

                worksheet = workbook.Worksheets.get_Item(1);
                worksheet.Name = comboBox_MaHoaDon.Text;

                worksheet = workbook.ActiveSheet;

                worksheet.Rows.ColumnWidth = 15;

                //Đổ dữ liệu vào Sheet

                Range row1 = worksheet.get_Range("A1", "C1");
                row1.Merge();
                row1.Font.Size = 16;
                row1.Font.Name = "Times New Roman";
                row1.Font.Bold = true;
                row1.Font.Color = Color.Blue;
                row1.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                row1.Value2 = "CỬA HÀNG THỜI TRANG";

                Range row2 = worksheet.get_Range("A2", "C2");
                row2.Merge();
                row2.Font.Size = 16;
                row2.Font.Name = "Times New Roman";
                row2.Font.Bold = true;
                row2.Font.Color = Color.Blue;
                row2.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                row2.Value2 = "NEW TERSERY";

                Range row3 = worksheet.get_Range("A3", "C3");
                row3.Merge();
                row3.Font.Size = 16;
                row3.Font.Name = "Times New Roman";
                row3.Font.Bold = true;
                row3.Font.Color = Color.Blue;
                row3.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                row3.Value2 = "Điện thoại: 0964843945";

                Range row4 = worksheet.get_Range("D2", "G2");
                row4.Merge();
                row4.Font.Size = 16;
                row4.Font.Name = "Times New Roman";
                row4.Font.Bold = true;
                row4.Font.Color = Color.Red;
                row4.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                row4.Value2 = "HÓA ĐƠN BÁN HÀNG";

                Range row5 = worksheet.get_Range("B6", "C6");
                row5.Merge();
                row5.Font.Size = 11;
                row5.Font.Name = "Times New Roman";
                row5.Font.Bold = true;
                //row2.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                row5.Value2 = "Mã hóa đơn:";

                Range row6 = worksheet.get_Range("D6", "E6");
                row6.Merge();
                row6.Font.Size = 11;
                row6.Font.Name = "Times New Roman";
                //row6.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                row6.Value2 = dt.Rows[0]["MaHDBan"];

                Range row7 = worksheet.get_Range("B7", "C7");
                row7.Merge();
                row7.Font.Size = 11;
                row7.Font.Name = "Times New Roman";
                row7.Font.Bold = true;
                //row4.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                row7.Value2 = "Mã nhân viên:";

                Range row8 = worksheet.get_Range("D7", "E7");
                row8.Merge();
                row8.Font.Size = 11;
                row8.Font.Name = "Times New Roman";
                row8.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                row8.Value2 = dt.Rows[0]["MaNV"];

                Range row9 = worksheet.get_Range("B8", "C8");
                row9.Merge();
                row9.Font.Size = 11;
                row9.Font.Name = "Times New Roman";
                row9.Font.Bold = true;
                //row9.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                row9.Value2 = "Mã khách hàng:";

                Range row10 = worksheet.get_Range("D8", "E8");
                row10.Merge();
                row10.Font.Size = 11;
                row10.Font.Name = "Times New Roman";
                //row7.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                row10.Value2 = dt.Rows[0]["MaKH"];

                Range row11 = worksheet.get_Range("B9", "C9");
                row11.Merge();
                row11.Font.Size = 11;
                row11.Font.Name = "Times New Roman";
                row11.Font.Bold = true;
                //row11.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                row11.Value2 = "Ngày bán:";

                Range row12 = worksheet.get_Range("D9", "E9");
                row12.Merge();
                row12.Font.Size = 11;
                row12.Font.Name = "Times New Roman";
                //row12.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                row12.Value2 = "'" + Convert.ToDateTime(dt.Rows[0]["Ngayban"]).ToString("dd-MM-yyyy");

                Range row_TenCot = worksheet.get_Range("B11", "G11");
                row_TenCot.Font.Size = 11;
                row_TenCot.Font.Name = "Times New Roman";
                row_TenCot.Font.Bold = FontStyle.Bold;
                row_TenCot.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                row_TenCot.Cells.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                worksheet.Cells[11, 2] = "STT";
                worksheet.Cells[11, 3] = "Mã hàng";
                worksheet.Cells[11, 4] = "Tên hàng";
                worksheet.Cells[11, 5] = "Giá bán";
                worksheet.Cells[11, 6] = "Số lượng";
                worksheet.Cells[11, 7] = "Thành tiền";

                Range row_Data = worksheet.get_Range("B12", "I" + (12 + dt_ChiTiet.Rows.Count));
                row_Data.Font.Size = 11;
                row_Data.Font.Name = "Times New Roman";
                row_Data.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                row_Data.Cells.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                for (int i = 0; i < dt_ChiTiet.Rows.Count; i++)
                {
                    worksheet.Cells[12 + i, 2] = (i + 1);
                    worksheet.Cells[12 + i, 3] = dt_ChiTiet.Rows[i]["Mahang"];
                    worksheet.Cells[12 + i, 4] = dt_ChiTiet.Rows[i]["Tenhang"];
                    worksheet.Cells[12 + i, 5] = dt_ChiTiet.Rows[i]["Giaban"];
                    worksheet.Cells[12 + i, 6] = dt_ChiTiet.Rows[i]["Soluong"];
                    worksheet.Cells[12 + i, 7] = "=E" + (12 + i) + "*" + "F" + (12 + i);
                }

                worksheet.Cells[13 + (dt_ChiTiet.Rows.Count), 6] = "Tổng tiền";
                worksheet.Cells[13 + (dt_ChiTiet.Rows.Count), 7] = "=SUM(G12:G" + (12 + dt_ChiTiet.Rows.Count - 1) + ")";
                worksheet.Cells[13 + (dt_ChiTiet.Rows.Count), 7].Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;

                Range row_NgayThangNam = worksheet.get_Range("F" + (16 + dt_ChiTiet.Rows.Count), "G" + (16 + dt_ChiTiet.Rows.Count));
                row_NgayThangNam.Merge();
                row_NgayThangNam.Font.Size = 11;
                row_NgayThangNam.Font.Name = "Times New Roman";
                //row_ChuKy.Font.Bold = FontStyle.Bold;
                row_NgayThangNam.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                row_NgayThangNam.Cells.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                row_NgayThangNam.Value2 = "Hà Nội, ngày "+DateTime.Now.Day + " tháng "+ DateTime.Now.Month +" năm "+ DateTime.Now.Year;

                Range row_ChuKy = worksheet.get_Range("F" + (17 + dt_ChiTiet.Rows.Count), "G" + (17 + dt_ChiTiet.Rows.Count));
                row_ChuKy.Merge();
                row_ChuKy.Font.Size = 11;
                row_ChuKy.Font.Name = "Times New Roman";
                //row_ChuKy.Font.Bold = FontStyle.Bold;
                row_ChuKy.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                row_ChuKy.Cells.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                row_ChuKy.Value2 = "Nhân viên bán hàng";

                Range row_ChuKyDuoi = worksheet.get_Range("F" + (18 + dt_ChiTiet.Rows.Count), "G" + (18 + dt_ChiTiet.Rows.Count));
                row_ChuKyDuoi.Merge();
                row_ChuKyDuoi.Font.Size = 11;
                row_ChuKyDuoi.Font.Name = "Times New Roman";
                row_ChuKyDuoi.Font.Italic = FontStyle.Italic;
                row_ChuKyDuoi.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                row_ChuKyDuoi.Cells.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                row_ChuKyDuoi.Value2 = "(Ký và ghi rõ họ tên)";

                //Range border_ChiTiet = worksheet.get_Range("D8", "I" + (8 + dt_ChiTiet.Rows.Count));
                //border_ChiTiet.Borders.LineStyle = XlLineStyle.xlContinuous;

                //Range row_Border_Top = worksheet.get_Range("B2", "K2");
                //row_Border_Top.Borders[XlBordersIndex.xlEdgeTop].LineStyle = XlLineStyle.xlContinuous;

                //Range row_Border_Right = worksheet.get_Range("K2", "K" + (17 + dt_ChiTiet.Rows.Count));
                //row_Border_Right.Borders[XlBordersIndex.xlEdgeRight].LineStyle = XlLineStyle.xlContinuous;

                //Range row_Border_Bottom = worksheet.get_Range("B" + (17 + dt_ChiTiet.Rows.Count), "K" + (17 + dt_ChiTiet.Rows.Count));
                //row_Border_Bottom.Borders[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;

                //Range row_Border_Left = worksheet.get_Range("B2", "B" + (17 + dt_ChiTiet.Rows.Count));
                //row_Border_Left.Borders[XlBordersIndex.xlEdgeLeft].LineStyle = XlLineStyle.xlContinuous;

                //End. Đổ dữ liệu vào Sheet

                app.Visible = true;
            }
            else
            {
                MessageBox.Show("Chưa khởi tạo hóa đơn không thể tiến hành xuất kho!");
            }
        }

        private void comboBox_MaHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Hoadonban INNER JOIN Nhanvien ON Nhanvien.MaNV = Hoadonban.MaNV WHERE MaHDBan = '" + comboBox_MaHoaDon.Text + "'", con);
                System.Data.DataTable dt = new System.Data.DataTable();
                sda.Fill(dt);

                SqlDataAdapter sda_ChiTiet = new SqlDataAdapter("SELECT MaHDBan, Mahang, Soluong FROM Chitiet_HDBan WHERE MaHDBan = '" + comboBox_MaHoaDon.Text + "'", con);
                System.Data.DataTable dt_ChiTiet = new System.Data.DataTable();
                sda_ChiTiet.Fill(dt_ChiTiet);
            try
            {
                txb_MaNV.Text = dt.Rows[0]["MaNV"].ToString();
                dateTimePicker_NgayXuatHang.Text = Convert.ToDateTime(dt.Rows[0]["Ngayban"]).ToString("dd/MM/yyyy");
                comboBox_MaKH.Text = dt.Rows[0]["MaKH"].ToString();
                comboBox_TenNhanVien.Text = dt.Rows[0]["TenNV"].ToString();

            }
            catch { }
            dataGridView1.DataSource = dt_ChiTiet;
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            comboBox_MaHoaDon_SelectedIndexChanged(sender, e);
        }

        private void numericUpDown_SoLuong_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT TOP(1) Giaban FROM Mathang WHERE Mahang = N'" + comboBox_MaMatHang.Text + "'", con);
                System.Data.DataTable dt = new System.Data.DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    comboBox_DonGia.Text = dt.Rows[0][0].ToString();
                    textBox_ThanhTien.Text = (Convert.ToDouble(numericUpDown_SoLuong.Value) * Convert.ToDouble(dt.Rows[0][0])).ToString();
                }
            }
            catch { }
        }
    }
}
