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
using System.Globalization;

namespace QuanLiCuaHang
{
    public partial class MainForm : Form
    {
        public MainForm(bool Isadmin)
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            customerDesign();
            btn_NhanVien.Visible = Isadmin;
        }
        private Form currentFormchild;
        private void OpenChildForm(Form childForm)
        {
            if(currentFormchild != null)
            {
                currentFormchild.Close();
            }
            currentFormchild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Main.Controls.Add(childForm);
            panel_Main.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        // ==> Dòng từ 22 đến dòng 32 dùng để nhập chuột và di chuyển cả trang theo ý muốn !!!!!
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelHeader_MouseMove_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        /////////////////////////////////////////////////////////////////////////////////////////
        private void customerDesign()
        {
            panelHoaDon.Visible = false;

        }
        private void hideMenu()
        {
            if(panelHoaDon.Visible == true)
            {
                panelHoaDon.Visible = false;
            }
        }
        private void showMenu(Panel menuHoaDon)
        {
            if (menuHoaDon.Visible == false)
            {
                hideMenu();
                menuHoaDon.Visible = true;
            }
            else
            {
                menuHoaDon.Visible = false;
            }
        }

        private void btn_Sanpham_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormSanPham());
            label_Home.Text = btn_Sanpham.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormKhachHang());
            label_Home.Text = button_Client.Text;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            showMenu(panelHoaDon);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormNhanVien());
            label_Home.Text = btn_NhanVien.Text;
        }
        private void btnBanhang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormBanHang());
            label_Home.Text = btn_Banhang.Text;
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn đăng xuất không ?","Thông báo",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            panelHeader.DoDragDrop(btn_ThongKe.Text, DragDropEffects.Copy | DragDropEffects.Move);  
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Maximize_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            FormDangnhap formLogin = new FormDangnhap();
            this.Close();
            formLogin.Show();
        }

        private void btn_Nhaphang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormNhapHang());
            label_Home.Text = btn_Nhaphang.Text;
        }

        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormThongKe());
            label_Home.Text = btn_ThongKe.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormNhaCungCap());
            label_Home.Text = btn_NhaCC.Text;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DateTime nowDate = DateTime.Now;
            
            label_Time.Text = nowDate.ToString("dddd, dd/MM/yyyy");
        }
    }
}
