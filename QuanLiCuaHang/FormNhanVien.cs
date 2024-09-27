using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;// gọi thư viện để kết nói với database
namespace QuanLiCuaHang
{
    public partial class FormNhanVien : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string chuoiketnoi = @"Data Source=DESKTOP-3DQNFS9;Initial Catalog=QLCH;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dataTable = new DataTable();
        private void ketnoicsdl()
        {
            try
            {
                connection = new SqlConnection(chuoiketnoi); //Truyền vào chuỗi kết nối 
                connection.Open(); // mở kết nối
                //MessageBox.Show("Kết nối thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Kết nối thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void chay_du_lieu_len_bang()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from Nhanvien";
            adapter.SelectCommand = command;
            dataTable.Clear();
            adapter.Fill(dataTable);
            dgv_Nhanvien.DataSource = dataTable;
            dinh_dang_tieu_de();
        }
        private void dinh_dang_tieu_de()
        {
            dgv_Nhanvien.Columns[0].HeaderText = "Mã nhân viên";
            dgv_Nhanvien.Columns[0].Width = 160;
            dgv_Nhanvien.Columns[1].HeaderText = "Tên nhân viên";
            dgv_Nhanvien.Columns[1].Width = 200;
            dgv_Nhanvien.Columns[2].HeaderText = "Số điện thoại";
            dgv_Nhanvien.Columns[2].Width = 150;
            dgv_Nhanvien.Columns[3].HeaderText = "Địa chỉ";
            dgv_Nhanvien.Columns[3].Width = 250;
        }
        public FormNhanVien()
        {
            InitializeComponent();
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
            chay_du_lieu_len_bang();
            dgv_Nhanvien.ColumnHeadersDefaultCellStyle.Font = new Font("Comic Sans MS", 11, FontStyle.Regular);
        }
        private void btn_ThemNV_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into Nhanvien values ('" + txb_MaNV.Text + "',N'" + txb_TenNV.Text + "','" + txb_Sdt.Text + "',N'" + txb_Diachi.Text + "')";
            command.ExecuteNonQuery();
            chay_du_lieu_len_bang();
        }

        private void btn_SuaKH_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update Nhanvien set TenNV = N'" + txb_TenNV.Text + "', SDT = '" + txb_Sdt.Text + "', Diachi = N'" + txb_Diachi.Text + "' where MaNV = '" + txb_MaNV.Text + "' ";
            command.ExecuteNonQuery();
            chay_du_lieu_len_bang();
        }

        private void btn_XoaNV_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from Nhanvien where MaNV = '" + txb_MaNV.Text + "' ";
            command.ExecuteNonQuery();
            chay_du_lieu_len_bang();
            txb_MaNV.Clear();
            txb_TenNV.Clear();
            txb_Sdt.Clear();
            txb_Diachi.Clear();
            txb_MaNV.Focus();
        }

        private void dgv_Nhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //txb_MaNV = dgv_Nhanvien.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void dgv_Nhanvien_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txb_MaNV.Text = dgv_Nhanvien.Rows[e.RowIndex].Cells[0].Value.ToString();
            txb_TenNV.Text = dgv_Nhanvien.Rows[e.RowIndex].Cells[1].Value.ToString();
            txb_Sdt.Text = dgv_Nhanvien.Rows[e.RowIndex].Cells[2].Value.ToString();
            txb_Diachi.Text = dgv_Nhanvien.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btn_Lammoi_Click(object sender, EventArgs e)
        {
            chay_du_lieu_len_bang();
            txb_MaNV.Clear();
            txb_TenNV.Clear();
            txb_Sdt.Clear();
            txb_Diachi.Clear();
            txb_MaNV.Focus();
            txb_Timkiem.Clear();
        }

        private void btn_Timkiem_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from Nhanvien where TenNV like N'%" + txb_Timkiem.Text.Trim() + "%' ";
            adapter.SelectCommand = command;
            dataTable.Clear();
            adapter.Fill(dataTable);
            dgv_Nhanvien.DataSource = dataTable;
            dinh_dang_tieu_de();
        }
    }
}
