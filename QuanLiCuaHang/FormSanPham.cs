using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace QuanLiCuaHang
{
    public partial class FormSanPham : Form
    {
        public FormSanPham()
        {
            InitializeComponent();
        }
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
            command.CommandText = "select * from Mathang";
            adapter.SelectCommand = command;
            dataTable.Clear();
            adapter.Fill(dataTable);
            dgv_Mathang.DataSource = dataTable;
            dinh_dang_tieu_de();
        }
        private void dinh_dang_tieu_de()
        {
            dgv_Mathang.Columns[0].HeaderText = "Mã hàng";
            dgv_Mathang.Columns[0].Width = 80;
            dgv_Mathang.Columns[1].HeaderText = "Tên hàng";
            dgv_Mathang.Columns[1].Width = 150;
            dgv_Mathang.Columns[2].HeaderText = "Số lượng";
            dgv_Mathang.Columns[2].Width = 100;
            dgv_Mathang.Columns[3].HeaderText = "Giá nhập";
            dgv_Mathang.Columns[3].Width = 80;
            dgv_Mathang.Columns[4].HeaderText = "Giá bán";
            dgv_Mathang.Columns[4].Width = 100;
            dgv_Mathang.Columns[5].HeaderText = "Ảnh";
            dgv_Mathang.Columns[5].Width = 100;
            dgv_Mathang.Columns[6].HeaderText = "Ghi chú";
            dgv_Mathang.Columns[6].Width = 200;

        }
        private void btn_AddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDiaLog = new OpenFileDialog();
            openFileDiaLog.Title = "Chọn ảnh";
            openFileDiaLog.Filter = "Image Files(*.jpg; *.png; *.gif ) | *.jpg; *.png; *.gif";
            if (openFileDiaLog.ShowDialog() == DialogResult.OK)
            {
                pictureBox_Anh.ImageLocation = openFileDiaLog.FileName;
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            byte[] image = null;
            string filepath = pictureBox_Anh.ImageLocation;
            FileStream fs = new FileStream(filepath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            image = br.ReadBytes((int)fs.Length);

            command = connection.CreateCommand();
            command.CommandText = "insert into Mathang values ('" + txb_Masp.Text + "',N'" + txb_Tensp.Text + "','" + txb_Soluong.Text + "','" + txb_Dongianhap.Text + "',N'" + txb_Dongiaban.Text + "', @Image, N'" + txb_Ghichu.Text + "')";
            command.Parameters.AddWithValue("@Image", image);
            command.ExecuteNonQuery();
            chay_du_lieu_len_bang();
        }

        private void FormSanPham_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
            chay_du_lieu_len_bang();
            dgv_Mathang.ColumnHeadersDefaultCellStyle.Font = new Font("Comic Sans MS", 11, FontStyle.Regular);
        }

        private void dgv_Mathang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txb_Masp.Text = dgv_Mathang.Rows[e.RowIndex].Cells[0].Value.ToString();
            txb_Tensp.Text = dgv_Mathang.Rows[e.RowIndex].Cells[1].Value.ToString();
            txb_Soluong.Text = dgv_Mathang.Rows[e.RowIndex].Cells[2].Value.ToString();
            txb_Dongianhap.Text = dgv_Mathang.Rows[e.RowIndex].Cells[3].Value.ToString();
            txb_Dongiaban.Text = dgv_Mathang.Rows[e.RowIndex].Cells[4].Value.ToString();
            try
            {
                MemoryStream ms = new MemoryStream((byte[])dgv_Mathang.Rows[e.RowIndex].Cells[5].Value);
                pictureBox_Anh.Image = Image.FromStream(ms);
            }
            catch { }
            txb_Ghichu.Text = dgv_Mathang.Rows[e.RowIndex].Cells[6].Value.ToString();

            //Cach 2
            //SqlCommand cmd = new SqlCommand();
            //cmd = connection.CreateCommand();
            //cmd.CommandText = "select * from Mathang WHERE Mahang = '" + txb_Masp.Text + "'";
            //SqlDataAdapter sqladapter = new SqlDataAdapter();
            //sqladapter.SelectCommand = cmd;
            //DataTable dt = new DataTable();
            //dt.Clear();
            //sqladapter.Fill(dt);
            //if (dt.Rows.Count > 0)
            //{
            //    byte[] data = (byte[])dt.Rows[0]["Anh"];
            //    MemoryStream ms = new MemoryStream(data);
            //    pictureBox_Anh.Image = Image.FromStream(ms);
            //}
        }

        private void dgv_Mathang_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
           
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            Image img = pictureBox_Anh.Image;
            MemoryStream ms = new MemoryStream();
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] image = ms.ToArray();

            command = connection.CreateCommand();
            command.CommandText = "update Mathang set Tenhang = N'" + txb_Tensp.Text + "', Soluong = '" + txb_Soluong.Text + "', Gianhap = N'" + txb_Dongianhap.Text + "', Giaban = N'" + txb_Dongiaban.Text + "', Anh = @Image, Ghichu = N'" + txb_Ghichu.Text + "' where Mahang = '" + txb_Masp.Text + "' ";
            command.Parameters.AddWithValue("@Image", image);
            command.ExecuteNonQuery();
            chay_du_lieu_len_bang();
        }

        private void rjButton7_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from Mathang where Mahang = '" + txb_Masp.Text + "' ";
            command.ExecuteNonQuery();
            chay_du_lieu_len_bang();
            txb_Tensp.Clear();
            txb_Soluong.Clear();
            txb_Ghichu.Clear();
            txb_Dongiaban.Clear();
            txb_Dongianhap.Clear();
            pictureBox_Anh.Image = null;
        }

        private void rjButton8_Click(object sender, EventArgs e)
        {
            chay_du_lieu_len_bang();
            txb_Tensp.Clear();
            txb_Soluong.Clear();
            txb_Ghichu.Clear();
            txb_Dongiaban.Clear();
            txb_Dongianhap.Clear();
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from Mathang where Tenhang like N'%" + textBox_TimKiem.Text.Trim() + "%' ";
            adapter.SelectCommand = command;
            dataTable.Clear();
            adapter.Fill(dataTable);
            dgv_Mathang.DataSource = dataTable;
            dinh_dang_tieu_de();
        }

        private void dgv_Mathang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    } 
}
