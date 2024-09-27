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
using System.Data.SqlClient;
namespace QuanLiCuaHang
{
    
    public partial class FormKhachHang : Form
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
            command.CommandText = "select * from Khachhang";
            adapter.SelectCommand = command;
            dataTable.Clear();
            adapter.Fill(dataTable);
            dgv_Khachhang.DataSource = dataTable;
            dinh_dang_tieu_de();
        }
        private void dinh_dang_tieu_de()
        {
            dgv_Khachhang.Columns[0].HeaderText = "Mã khách hàng";
            dgv_Khachhang.Columns[0].Width = 160;
            dgv_Khachhang.Columns[1].HeaderText = "Tên khách hàng";
            dgv_Khachhang.Columns[1].Width = 200;
            dgv_Khachhang.Columns[2].HeaderText = "Số điện thoại";
            dgv_Khachhang.Columns[2].Width = 150;
            dgv_Khachhang.Columns[3].HeaderText = "Địa chỉ";
            dgv_Khachhang.Columns[3].Width = 250;
        }
        public FormKhachHang()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
            chay_du_lieu_len_bang();
            dgv_Khachhang.ColumnHeadersDefaultCellStyle.Font = new Font("Comic Sans MS", 11, FontStyle.Regular);
        }
        private void btn_ThemKH_Click_1(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into Khachhang values ('" + txb_MaKH.Text + "',N'" + txb_TenKH.Text + "','" + txb_Sdt.Text + "',N'" + txb_Diachi.Text + "')";
            command.ExecuteNonQuery();
            chay_du_lieu_len_bang();
        }

        private void btn_SuaKH_Click_1(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update Khachhang set TenKH = N'" + txb_TenKH.Text + "', SDT = '" + txb_Sdt.Text + "', Diachi = N'" + txb_Diachi.Text + "' where MaKH = '" + txb_MaKH.Text + "' ";
            command.ExecuteNonQuery();
            chay_du_lieu_len_bang();
        }

        private void btn_XoaKH_Click_1(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from Khachhang where MaKH = '" + txb_MaKH.Text + "' ";
            command.ExecuteNonQuery();
            chay_du_lieu_len_bang();
        }
        private void btn_Lammoi_Click_1(object sender, EventArgs e)
        {
            chay_du_lieu_len_bang();
            txb_MaKH.Clear();
            txb_TenKH.Clear();
            txb_Sdt.Clear();
            txb_Diachi.Clear();
            txb_MaKH.Focus();
            txb_Timkiem.Clear();
        }

        private void dgv_Khachhang_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(dgv_Khachhang.Rows.Count > 0)
            {
                txb_MaKH.Text = dgv_Khachhang.Rows[e.RowIndex].Cells[0].Value.ToString();
                txb_TenKH.Text = dgv_Khachhang.Rows[e.RowIndex].Cells[1].Value.ToString();
                txb_Sdt.Text = dgv_Khachhang.Rows[e.RowIndex].Cells[2].Value.ToString();
                txb_Diachi.Text = dgv_Khachhang.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }
        private void btn_Timkiem_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from Khachhang where TenKH like N'%" + txb_Timkiem.Text.Trim() + "%' ";
            adapter.SelectCommand = command;
            dataTable.Clear();
            adapter.Fill(dataTable);
            dgv_Khachhang.DataSource = dataTable;
            dinh_dang_tieu_de();
        }
    }
}
