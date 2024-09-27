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
    public partial class FormDangnhap : Form
    {
        public FormDangnhap()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel_Header_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            SqlConnection connection;
            connection = new SqlConnection(@"Data Source=DESKTOP-3DQNFS9;Initial Catalog=QLCH;Integrated Security=True");
            connection.Open();
            string sql = "select * from Dangnhap where Tendangnhap = '" + txb_Username.Text + "' and Matkhau = '" + txb_Password.Text + "' ";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader dataReader = command.ExecuteReader();
            if (txb_Username.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập họ tên !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txb_Password.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (dataReader.Read() == true)
                {
                    MainForm mainForm = new MainForm(Convert.ToBoolean(dataReader["Isadmin"]));
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sai họ tên hoặc mật khẩu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void btn_Resgister_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDangKi formDangKi = new FormDangKi();
            formDangKi.Show();
        }

        private void txb_Username_Click(object sender, EventArgs e)
        {
            panel_Username.BackColor = Color.FromArgb(0, 137, 155);
            panel_Password.BackColor = Color.White;
        }

        private void txb_Password_Click(object sender, EventArgs e)
        {
            panel_Password.BackColor = Color.FromArgb(0, 137, 155);
            panel_Username.BackColor = Color.White;
        }
        private void pictureBox_ShowPassword_Click(object sender, EventArgs e)
        {
            txb_Password.UseSystemPasswordChar = true;
            pictureBox_HidePassword.BringToFront();
        }
        private void pictureBox_HidePassword_Click(object sender, EventArgs e)
        {
            txb_Password.UseSystemPasswordChar = false;
            pictureBox_ShowPassword.BringToFront();
        }
    }
}
