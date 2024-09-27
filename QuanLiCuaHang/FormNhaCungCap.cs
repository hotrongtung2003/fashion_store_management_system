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
    public partial class FormNhaCungCap : Form
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
            command.CommandText = "select * from Nhacungcap";
            adapter.SelectCommand = command;
            dataTable.Clear();
            adapter.Fill(dataTable);
            dgv_NhaCC.DataSource = dataTable;
            dinh_dang_tieu_de();
        }
        private void dinh_dang_tieu_de()
        {
            dgv_NhaCC.Columns[0].HeaderText = "Mã nhà cung cấp:";
            dgv_NhaCC.Columns[0].Width = 160;
            dgv_NhaCC.Columns[1].HeaderText = "Tên nhà cung cấp:";
            dgv_NhaCC.Columns[1].Width = 200;
            dgv_NhaCC.Columns[2].HeaderText = "Địa chỉ:";
            dgv_NhaCC.Columns[2].Width = 250;
            dgv_NhaCC.Columns[3].HeaderText = "Số điện thoại:";
            dgv_NhaCC.Columns[3].Width = 150;
        }
        public FormNhaCungCap()
        {
            InitializeComponent();
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
            chay_du_lieu_len_bang();
            dgv_NhaCC.ColumnHeadersDefaultCellStyle.Font = new Font("Comic Sans MS", 11, FontStyle.Regular);
        }
        private void btn_ThemNV_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into Nhacungcap values ('" + txb_MaNhaCC.Text + "',N'" + txb_TenNhaCC.Text + "',N'" + txb_Diachi.Text + "',N'" + txb_Sdt.Text + "')";
            command.ExecuteNonQuery();
            chay_du_lieu_len_bang();
        }

        private void btn_SuaKH_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update Nhacungcap set TenNCC = N'" + txb_TenNhaCC.Text + "', SDT = '" + txb_Sdt.Text + "', Diachi = N'" + txb_Diachi.Text + "' where MaNCC = '" + txb_MaNhaCC.Text + "' ";
            command.ExecuteNonQuery();
            chay_du_lieu_len_bang();
        }

        private void btn_XoaNV_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from Nhacungcap where MaNCC = '" + txb_MaNhaCC.Text + "' ";
            command.ExecuteNonQuery();
            chay_du_lieu_len_bang();
            txb_MaNhaCC.Clear();
            txb_TenNhaCC.Clear();
            txb_Sdt.Clear();
            txb_Diachi.Clear();
            txb_MaNhaCC.Focus();
        }

        private void dgv_Nhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //txb_MaNV = dgv_Nhanvien.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void dgv_Nhanvien_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txb_MaNhaCC.Text = dgv_NhaCC.Rows[e.RowIndex].Cells[0].Value.ToString();
            txb_TenNhaCC.Text = dgv_NhaCC.Rows[e.RowIndex].Cells[1].Value.ToString();
            txb_Sdt.Text = dgv_NhaCC.Rows[e.RowIndex].Cells[2].Value.ToString();
            txb_Diachi.Text = dgv_NhaCC.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btn_Lammoi_Click(object sender, EventArgs e)
        {
            chay_du_lieu_len_bang();
            txb_MaNhaCC.Clear();
            txb_TenNhaCC.Clear();
            txb_Sdt.Clear();
            txb_Diachi.Clear();
            txb_MaNhaCC.Focus();
            txb_Timkiem.Clear();
        }

        private void btn_Timkiem_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from Nhacungcap where TenNCC like N'%" + txb_Timkiem.Text.Trim() + "%' ";
            adapter.SelectCommand = command;
            dataTable.Clear();
            adapter.Fill(dataTable);
            dgv_NhaCC.DataSource = dataTable;
            dinh_dang_tieu_de();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
