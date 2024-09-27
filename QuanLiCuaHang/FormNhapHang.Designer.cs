namespace QuanLiCuaHang
{
    partial class FormNhapHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNhapHang));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txb_TenNhaCC = new System.Windows.Forms.ComboBox();
            this.btn_ThemHangHoa = new CustomControls.RJControls.RJButton();
            this.btn_In = new CustomControls.RJControls.RJButton();
            this.btn_XoaHD = new CustomControls.RJControls.RJButton();
            this.btn_ThemHD = new CustomControls.RJControls.RJButton();
            this.textBox_ThanhTien = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox_DonGia = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDown_SoLuong = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox_MaHang = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox_TenNhanVien = new System.Windows.Forms.ComboBox();
            this.textBox_SDTNCC = new System.Windows.Forms.TextBox();
            this.textBox_DiaChiNhaCC = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker_NgayNhap = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_MaNV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_TimKiem = new CustomControls.RJControls.RJButton();
            this.comboBox_MaHoaDon = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dgv_Nhanvien = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Nhanvien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.panel1.Controls.Add(this.txb_TenNhaCC);
            this.panel1.Controls.Add(this.btn_ThemHangHoa);
            this.panel1.Controls.Add(this.btn_In);
            this.panel1.Controls.Add(this.btn_XoaHD);
            this.panel1.Controls.Add(this.btn_ThemHD);
            this.panel1.Controls.Add(this.textBox_ThanhTien);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.comboBox_DonGia);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.numericUpDown_SoLuong);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.comboBox_MaHang);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.comboBox_TenNhanVien);
            this.panel1.Controls.Add(this.textBox_SDTNCC);
            this.panel1.Controls.Add(this.textBox_DiaChiNhaCC);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dateTimePicker_NgayNhap);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txb_MaNV);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_TimKiem);
            this.panel1.Controls.Add(this.comboBox_MaHoaDon);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(749, 286);
            this.panel1.TabIndex = 9;
            // 
            // txb_TenNhaCC
            // 
            this.txb_TenNhaCC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txb_TenNhaCC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_TenNhaCC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txb_TenNhaCC.FormattingEnabled = true;
            this.txb_TenNhaCC.Location = new System.Drawing.Point(547, 6);
            this.txb_TenNhaCC.Name = "txb_TenNhaCC";
            this.txb_TenNhaCC.Size = new System.Drawing.Size(183, 27);
            this.txb_TenNhaCC.TabIndex = 106;
            this.txb_TenNhaCC.SelectedIndexChanged += new System.EventHandler(this.txb_TenNhaCC_SelectedIndexChanged);
            // 
            // btn_ThemHangHoa
            // 
            this.btn_ThemHangHoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ThemHangHoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(84)))));
            this.btn_ThemHangHoa.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(84)))));
            this.btn_ThemHangHoa.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_ThemHangHoa.BorderRadius = 14;
            this.btn_ThemHangHoa.BorderSize = 0;
            this.btn_ThemHangHoa.FlatAppearance.BorderSize = 0;
            this.btn_ThemHangHoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThemHangHoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemHangHoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_ThemHangHoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThemHangHoa.Image")));
            this.btn_ThemHangHoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ThemHangHoa.Location = new System.Drawing.Point(225, 198);
            this.btn_ThemHangHoa.Name = "btn_ThemHangHoa";
            this.btn_ThemHangHoa.Size = new System.Drawing.Size(131, 30);
            this.btn_ThemHangHoa.TabIndex = 105;
            this.btn_ThemHangHoa.Text = "Thêm hàng hóa";
            this.btn_ThemHangHoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ThemHangHoa.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_ThemHangHoa.UseCompatibleTextRendering = true;
            this.btn_ThemHangHoa.UseVisualStyleBackColor = false;
            this.btn_ThemHangHoa.Click += new System.EventHandler(this.btn_ThemHangHoa_Click);
            // 
            // btn_In
            // 
            this.btn_In.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_In.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(84)))));
            this.btn_In.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(84)))));
            this.btn_In.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_In.BorderRadius = 16;
            this.btn_In.BorderSize = 0;
            this.btn_In.FlatAppearance.BorderSize = 0;
            this.btn_In.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_In.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_In.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_In.Image = ((System.Drawing.Image)(resources.GetObject("btn_In.Image")));
            this.btn_In.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_In.Location = new System.Drawing.Point(623, 198);
            this.btn_In.Name = "btn_In";
            this.btn_In.Size = new System.Drawing.Size(107, 30);
            this.btn_In.TabIndex = 102;
            this.btn_In.Text = "In hóa đơn";
            this.btn_In.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_In.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_In.UseCompatibleTextRendering = true;
            this.btn_In.UseVisualStyleBackColor = false;
            this.btn_In.Click += new System.EventHandler(this.btn_In_Click);
            // 
            // btn_XoaHD
            // 
            this.btn_XoaHD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_XoaHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(84)))));
            this.btn_XoaHD.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(84)))));
            this.btn_XoaHD.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_XoaHD.BorderRadius = 16;
            this.btn_XoaHD.BorderSize = 0;
            this.btn_XoaHD.FlatAppearance.BorderSize = 0;
            this.btn_XoaHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_XoaHD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaHD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_XoaHD.Image = ((System.Drawing.Image)(resources.GetObject("btn_XoaHD.Image")));
            this.btn_XoaHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_XoaHD.Location = new System.Drawing.Point(431, 198);
            this.btn_XoaHD.Name = "btn_XoaHD";
            this.btn_XoaHD.Size = new System.Drawing.Size(117, 30);
            this.btn_XoaHD.TabIndex = 100;
            this.btn_XoaHD.Text = " Hủy hóa đơn";
            this.btn_XoaHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_XoaHD.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_XoaHD.UseCompatibleTextRendering = true;
            this.btn_XoaHD.UseVisualStyleBackColor = false;
            this.btn_XoaHD.Click += new System.EventHandler(this.btn_XoaHD_Click);
            // 
            // btn_ThemHD
            // 
            this.btn_ThemHD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ThemHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(84)))));
            this.btn_ThemHD.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(84)))));
            this.btn_ThemHD.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_ThemHD.BorderRadius = 14;
            this.btn_ThemHD.BorderSize = 0;
            this.btn_ThemHD.FlatAppearance.BorderSize = 0;
            this.btn_ThemHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThemHD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemHD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_ThemHD.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThemHD.Image")));
            this.btn_ThemHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ThemHD.Location = new System.Drawing.Point(32, 198);
            this.btn_ThemHD.Name = "btn_ThemHD";
            this.btn_ThemHD.Size = new System.Drawing.Size(114, 30);
            this.btn_ThemHD.TabIndex = 99;
            this.btn_ThemHD.Text = "Tạo hóa đơn";
            this.btn_ThemHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ThemHD.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_ThemHD.UseCompatibleTextRendering = true;
            this.btn_ThemHD.UseVisualStyleBackColor = false;
            this.btn_ThemHD.Click += new System.EventHandler(this.btn_ThemHD_Click);
            // 
            // textBox_ThanhTien
            // 
            this.textBox_ThanhTien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_ThanhTien.BackColor = System.Drawing.Color.White;
            this.textBox_ThanhTien.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox_ThanhTien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ThanhTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox_ThanhTien.Location = new System.Drawing.Point(547, 151);
            this.textBox_ThanhTien.Name = "textBox_ThanhTien";
            this.textBox_ThanhTien.ReadOnly = true;
            this.textBox_ThanhTien.Size = new System.Drawing.Size(183, 26);
            this.textBox_ThanhTien.TabIndex = 98;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(84)))));
            this.label8.Location = new System.Drawing.Point(394, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 23);
            this.label8.TabIndex = 97;
            this.label8.Text = "Thành tiền:";
            this.label8.UseCompatibleTextRendering = true;
            // 
            // comboBox_DonGia
            // 
            this.comboBox_DonGia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_DonGia.BackColor = System.Drawing.Color.White;
            this.comboBox_DonGia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBox_DonGia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_DonGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBox_DonGia.FormattingEnabled = true;
            this.comboBox_DonGia.Location = new System.Drawing.Point(547, 112);
            this.comboBox_DonGia.Name = "comboBox_DonGia";
            this.comboBox_DonGia.Size = new System.Drawing.Size(183, 26);
            this.comboBox_DonGia.TabIndex = 96;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(84)))));
            this.label9.Location = new System.Drawing.Point(394, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 23);
            this.label9.TabIndex = 95;
            this.label9.Text = "Đơn giá:";
            this.label9.UseCompatibleTextRendering = true;
            // 
            // numericUpDown_SoLuong
            // 
            this.numericUpDown_SoLuong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown_SoLuong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_SoLuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numericUpDown_SoLuong.Location = new System.Drawing.Point(146, 112);
            this.numericUpDown_SoLuong.Name = "numericUpDown_SoLuong";
            this.numericUpDown_SoLuong.Size = new System.Drawing.Size(217, 26);
            this.numericUpDown_SoLuong.TabIndex = 94;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(84)))));
            this.label7.Location = new System.Drawing.Point(32, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 23);
            this.label7.TabIndex = 93;
            this.label7.Text = "Số lượng:";
            this.label7.UseCompatibleTextRendering = true;
            // 
            // comboBox_MaHang
            // 
            this.comboBox_MaHang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_MaHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_MaHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBox_MaHang.FormattingEnabled = true;
            this.comboBox_MaHang.Location = new System.Drawing.Point(146, 151);
            this.comboBox_MaHang.Name = "comboBox_MaHang";
            this.comboBox_MaHang.Size = new System.Drawing.Size(217, 27);
            this.comboBox_MaHang.TabIndex = 92;
            this.comboBox_MaHang.SelectedIndexChanged += new System.EventHandler(this.comboBox_MaHang_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(84)))));
            this.label12.Location = new System.Drawing.Point(32, 153);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 23);
            this.label12.TabIndex = 91;
            this.label12.Text = "Mã hàng:";
            this.label12.UseCompatibleTextRendering = true;
            // 
            // comboBox_TenNhanVien
            // 
            this.comboBox_TenNhanVien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_TenNhanVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_TenNhanVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBox_TenNhanVien.FormattingEnabled = true;
            this.comboBox_TenNhanVien.Location = new System.Drawing.Point(146, 75);
            this.comboBox_TenNhanVien.Name = "comboBox_TenNhanVien";
            this.comboBox_TenNhanVien.Size = new System.Drawing.Size(217, 27);
            this.comboBox_TenNhanVien.TabIndex = 90;
            this.comboBox_TenNhanVien.SelectedIndexChanged += new System.EventHandler(this.comboBox_TenNhanVien_SelectedIndexChanged);
            // 
            // textBox_SDTNCC
            // 
            this.textBox_SDTNCC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_SDTNCC.BackColor = System.Drawing.Color.White;
            this.textBox_SDTNCC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SDTNCC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox_SDTNCC.Location = new System.Drawing.Point(547, 75);
            this.textBox_SDTNCC.Name = "textBox_SDTNCC";
            this.textBox_SDTNCC.Size = new System.Drawing.Size(183, 26);
            this.textBox_SDTNCC.TabIndex = 88;
            // 
            // textBox_DiaChiNhaCC
            // 
            this.textBox_DiaChiNhaCC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_DiaChiNhaCC.BackColor = System.Drawing.Color.White;
            this.textBox_DiaChiNhaCC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_DiaChiNhaCC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox_DiaChiNhaCC.Location = new System.Drawing.Point(547, 40);
            this.textBox_DiaChiNhaCC.Name = "textBox_DiaChiNhaCC";
            this.textBox_DiaChiNhaCC.Size = new System.Drawing.Size(183, 26);
            this.textBox_DiaChiNhaCC.TabIndex = 86;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(84)))));
            this.label6.Location = new System.Drawing.Point(394, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 23);
            this.label6.TabIndex = 85;
            this.label6.Text = "Số điện thoại: ";
            this.label6.UseCompatibleTextRendering = true;
            // 
            // dateTimePicker_NgayNhap
            // 
            this.dateTimePicker_NgayNhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker_NgayNhap.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dateTimePicker_NgayNhap.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dateTimePicker_NgayNhap.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker_NgayNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_NgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_NgayNhap.Location = new System.Drawing.Point(146, 40);
            this.dateTimePicker_NgayNhap.Name = "dateTimePicker_NgayNhap";
            this.dateTimePicker_NgayNhap.Size = new System.Drawing.Size(218, 26);
            this.dateTimePicker_NgayNhap.TabIndex = 84;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(84)))));
            this.label1.Location = new System.Drawing.Point(32, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 19);
            this.label1.TabIndex = 83;
            this.label1.Text = "Người nhập:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(84)))));
            this.label5.Location = new System.Drawing.Point(394, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 23);
            this.label5.TabIndex = 79;
            this.label5.Text = "Địa chỉ nhà cung cấp:";
            this.label5.UseCompatibleTextRendering = true;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(84)))));
            this.label4.Location = new System.Drawing.Point(394, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 19);
            this.label4.TabIndex = 78;
            this.label4.Text = "Tên nhà cung cấp:";
            // 
            // txb_MaNV
            // 
            this.txb_MaNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txb_MaNV.BackColor = System.Drawing.Color.White;
            this.txb_MaNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_MaNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txb_MaNV.Location = new System.Drawing.Point(146, 5);
            this.txb_MaNV.Name = "txb_MaNV";
            this.txb_MaNV.ReadOnly = true;
            this.txb_MaNV.Size = new System.Drawing.Size(217, 26);
            this.txb_MaNV.TabIndex = 77;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(84)))));
            this.label3.Location = new System.Drawing.Point(32, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 19);
            this.label3.TabIndex = 76;
            this.label3.Text = "Ngày nhập hàng:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(84)))));
            this.label2.Location = new System.Drawing.Point(32, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 75;
            this.label2.Text = "Mã nhân viên:";
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_TimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(84)))));
            this.btn_TimKiem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(84)))));
            this.btn_TimKiem.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_TimKiem.BorderRadius = 16;
            this.btn_TimKiem.BorderSize = 0;
            this.btn_TimKiem.FlatAppearance.BorderSize = 0;
            this.btn_TimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_TimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btn_TimKiem.Image")));
            this.btn_TimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TimKiem.Location = new System.Drawing.Point(530, 245);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(102, 30);
            this.btn_TimKiem.TabIndex = 74;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_TimKiem.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_TimKiem.UseCompatibleTextRendering = true;
            this.btn_TimKiem.UseVisualStyleBackColor = false;
            // 
            // comboBox_MaHoaDon
            // 
            this.comboBox_MaHoaDon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_MaHoaDon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_MaHoaDon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBox_MaHoaDon.FormattingEnabled = true;
            this.comboBox_MaHoaDon.Location = new System.Drawing.Point(216, 247);
            this.comboBox_MaHoaDon.Name = "comboBox_MaHoaDon";
            this.comboBox_MaHoaDon.Size = new System.Drawing.Size(284, 27);
            this.comboBox_MaHoaDon.TabIndex = 73;
            this.comboBox_MaHoaDon.SelectedIndexChanged += new System.EventHandler(this.comboBox_MaHoaDon_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(84)))));
            this.label10.Location = new System.Drawing.Point(108, 251);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 19);
            this.label10.TabIndex = 72;
            this.label10.Text = "Mã hóa đơn : ";
            // 
            // dgv_Nhanvien
            // 
            this.dgv_Nhanvien.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Nhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Nhanvien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Nhanvien.Location = new System.Drawing.Point(0, 0);
            this.dgv_Nhanvien.Name = "dgv_Nhanvien";
            this.dgv_Nhanvien.Size = new System.Drawing.Size(749, 483);
            this.dgv_Nhanvien.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 286);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(749, 197);
            this.dataGridView1.TabIndex = 11;
            // 
            // FormNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 483);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_Nhanvien);
            this.Name = "FormNhapHang";
            this.Text = "FormNhapHang";
            this.Load += new System.EventHandler(this.FormNhapHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Nhanvien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_Nhanvien;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox_TenNhanVien;
        private System.Windows.Forms.TextBox textBox_SDTNCC;
        private System.Windows.Forms.TextBox textBox_DiaChiNhaCC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker_NgayNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_MaNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private CustomControls.RJControls.RJButton btn_TimKiem;
        private System.Windows.Forms.ComboBox comboBox_MaHoaDon;
        private System.Windows.Forms.Label label10;
        private CustomControls.RJControls.RJButton btn_In;
        private CustomControls.RJControls.RJButton btn_XoaHD;
        private CustomControls.RJControls.RJButton btn_ThemHD;
        private System.Windows.Forms.TextBox textBox_ThanhTien;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox_DonGia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDown_SoLuong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_MaHang;
        private System.Windows.Forms.Label label12;
        private CustomControls.RJControls.RJButton btn_ThemHangHoa;
        private System.Windows.Forms.ComboBox txb_TenNhaCC;
    }
}