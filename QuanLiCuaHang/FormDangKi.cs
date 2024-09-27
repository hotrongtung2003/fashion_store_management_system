using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace QuanLiCuaHang
{
    public partial class FormDangKi : Form
    {
        public FormDangKi()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Text = string.Empty;
        }

        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-3DQNFS9;Initial Catalog=QLCH;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            FormDangnhap formLogin = new FormDangnhap();
            formLogin.Show();
        }

        private void btn_Minimize_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Register_MouseMove(object sender, MouseEventArgs e)
        {
            btn_Register.BackColor = Color.FromArgb(7, 95, 96);
        }

        private void btn_Register_MouseLeave(object sender, EventArgs e)
        {
            btn_Register.BackColor = Color.FromArgb(26, 177, 136);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            if (txb_Username.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập họ tên tối thiểu 6 kí tự !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txb_Password.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txb_Sodienthoai.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số điện thoại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txb_Gmail.Text == "")
            {
                MessageBox.Show("Vui lòng nhập gmail !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (comboBox_PhanQuyen.Text == "")
            {
                MessageBox.Show("Vui lòng chọn quyền tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                bool admin = false;
                if (comboBox_PhanQuyen.Text == "Quản trị viên")
                    admin = true;
                connection.Open();
                string query = "insert into Dangnhap (Tendangnhap, Matkhau, Isadmin) values('" + txb_Username.Text + "', '" + txb_Password.Text + "', '"+ admin +"') ";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, connection);
                sqlDataAdapter.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Đăng kí tài khoản thành công !\nVui lòng đăng nhập lại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                this.Close();
                FormDangnhap formLogin = new FormDangnhap();
                formLogin.Show();
            }
        }
    }
}
