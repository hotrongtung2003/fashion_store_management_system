namespace QuanLiCuaHang
{
    partial class FormKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKhachHang));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Timkiem = new CustomControls.RJControls.RJButton();
            this.txb_Timkiem = new System.Windows.Forms.TextBox();
            this.btn_ThemKH = new CustomControls.RJControls.RJButton();
            this.btn_SuaKH = new CustomControls.RJControls.RJButton();
            this.btn_XoaKH = new CustomControls.RJControls.RJButton();
            this.btn_Lammoi = new CustomControls.RJControls.RJButton();
            this.txb_Diachi = new System.Windows.Forms.TextBox();
            this.txb_Sdt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_TenKH = new System.Windows.Forms.TextBox();
            this.txb_MaKH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_Khachhang = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Khachhang)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_Timkiem);
            this.panel1.Controls.Add(this.txb_Timkiem);
            this.panel1.Controls.Add(this.btn_ThemKH);
            this.panel1.Controls.Add(this.btn_SuaKH);
            this.panel1.Controls.Add(this.btn_XoaKH);
            this.panel1.Controls.Add(this.btn_Lammoi);
            this.panel1.Controls.Add(this.txb_Diachi);
            this.panel1.Controls.Add(this.txb_Sdt);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txb_TenKH);
            this.panel1.Controls.Add(this.txb_MaKH);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(811, 178);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(84)))));
            this.label1.Location = new System.Drawing.Point(510, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 19);
            this.label1.TabIndex = 32;
            this.label1.Text = "Tìm kiếm theo tên";
            // 
            // btn_Timkiem
            // 
            this.btn_Timkiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Timkiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(84)))));
            this.btn_Timkiem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(84)))));
            this.btn_Timkiem.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Timkiem.BorderRadius = 16;
            this.btn_Timkiem.BorderSize = 0;
            this.btn_Timkiem.FlatAppearance.BorderSize = 0;
            this.btn_Timkiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Timkiem.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Timkiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Timkiem.Image = ((System.Drawing.Image)(resources.GetObject("btn_Timkiem.Image")));
            this.btn_Timkiem.Location = new System.Drawing.Point(713, 125);
            this.btn_Timkiem.Name = "btn_Timkiem";
            this.btn_Timkiem.Size = new System.Drawing.Size(36, 33);
            this.btn_Timkiem.TabIndex = 31;
            this.btn_Timkiem.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Timkiem.UseVisualStyleBackColor = false;
            this.btn_Timkiem.Click += new System.EventHandler(this.btn_Timkiem_Click);
            // 
            // txb_Timkiem
            // 
            this.txb_Timkiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txb_Timkiem.BackColor = System.Drawing.Color.White;
            this.txb_Timkiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Timkiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txb_Timkiem.Location = new System.Drawing.Point(513, 128);
            this.txb_Timkiem.Name = "txb_Timkiem";
            this.txb_Timkiem.Size = new System.Drawing.Size(183, 26);
            this.txb_Timkiem.TabIndex = 30;
            // 
            // btn_ThemKH
            // 
            this.btn_ThemKH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ThemKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(84)))));
            this.btn_ThemKH.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(84)))));
            this.btn_ThemKH.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_ThemKH.BorderRadius = 16;
            this.btn_ThemKH.BorderSize = 0;
            this.btn_ThemKH.FlatAppearance.BorderSize = 0;
            this.btn_ThemKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThemKH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_ThemKH.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThemKH.Image")));
            this.btn_ThemKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ThemKH.Location = new System.Drawing.Point(40, 119);
            this.btn_ThemKH.Name = "btn_ThemKH";
            this.btn_ThemKH.Size = new System.Drawing.Size(97, 34);
            this.btn_ThemKH.TabIndex = 28;
            this.btn_ThemKH.Text = "   Thêm";
            this.btn_ThemKH.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_ThemKH.UseVisualStyleBackColor = false;
            this.btn_ThemKH.Click += new System.EventHandler(this.btn_ThemKH_Click_1);
            // 
            // btn_SuaKH
            // 
            this.btn_SuaKH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_SuaKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(84)))));
            this.btn_SuaKH.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(84)))));
            this.btn_SuaKH.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_SuaKH.BorderRadius = 16;
            this.btn_SuaKH.BorderSize = 0;
            this.btn_SuaKH.FlatAppearance.BorderSize = 0;
            this.btn_SuaKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SuaKH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SuaKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_SuaKH.Image = ((System.Drawing.Image)(resources.GetObject("btn_SuaKH.Image")));
            this.btn_SuaKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SuaKH.Location = new System.Drawing.Point(155, 119);
            this.btn_SuaKH.Name = "btn_SuaKH";
            this.btn_SuaKH.Size = new System.Drawing.Size(97, 34);
            this.btn_SuaKH.TabIndex = 27;
            this.btn_SuaKH.Text = "   Sửa";
            this.btn_SuaKH.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_SuaKH.UseVisualStyleBackColor = false;
            this.btn_SuaKH.Click += new System.EventHandler(this.btn_SuaKH_Click_1);
            // 
            // btn_XoaKH
            // 
            this.btn_XoaKH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_XoaKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(84)))));
            this.btn_XoaKH.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(84)))));
            this.btn_XoaKH.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_XoaKH.BorderRadius = 16;
            this.btn_XoaKH.BorderSize = 0;
            this.btn_XoaKH.FlatAppearance.BorderSize = 0;
            this.btn_XoaKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_XoaKH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_XoaKH.Image = ((System.Drawing.Image)(resources.GetObject("btn_XoaKH.Image")));
            this.btn_XoaKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_XoaKH.Location = new System.Drawing.Point(270, 119);
            this.btn_XoaKH.Name = "btn_XoaKH";
            this.btn_XoaKH.Size = new System.Drawing.Size(97, 34);
            this.btn_XoaKH.TabIndex = 26;
            this.btn_XoaKH.Text = "   Xóa";
            this.btn_XoaKH.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_XoaKH.UseVisualStyleBackColor = false;
            this.btn_XoaKH.Click += new System.EventHandler(this.btn_XoaKH_Click_1);
            // 
            // btn_Lammoi
            // 
            this.btn_Lammoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Lammoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(84)))));
            this.btn_Lammoi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(84)))));
            this.btn_Lammoi.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Lammoi.BorderRadius = 16;
            this.btn_Lammoi.BorderSize = 0;
            this.btn_Lammoi.FlatAppearance.BorderSize = 0;
            this.btn_Lammoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Lammoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Lammoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Lammoi.Image = ((System.Drawing.Image)(resources.GetObject("btn_Lammoi.Image")));
            this.btn_Lammoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Lammoi.Location = new System.Drawing.Point(385, 119);
            this.btn_Lammoi.Name = "btn_Lammoi";
            this.btn_Lammoi.Size = new System.Drawing.Size(97, 34);
            this.btn_Lammoi.TabIndex = 25;
            this.btn_Lammoi.Text = "Làm mới";
            this.btn_Lammoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Lammoi.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Lammoi.UseVisualStyleBackColor = false;
            this.btn_Lammoi.Click += new System.EventHandler(this.btn_Lammoi_Click_1);
            // 
            // txb_Diachi
            // 
            this.txb_Diachi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txb_Diachi.BackColor = System.Drawing.Color.White;
            this.txb_Diachi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Diachi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txb_Diachi.Location = new System.Drawing.Point(513, 73);
            this.txb_Diachi.Name = "txb_Diachi";
            this.txb_Diachi.Size = new System.Drawing.Size(236, 26);
            this.txb_Diachi.TabIndex = 15;
            // 
            // txb_Sdt
            // 
            this.txb_Sdt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txb_Sdt.BackColor = System.Drawing.Color.White;
            this.txb_Sdt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Sdt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txb_Sdt.Location = new System.Drawing.Point(513, 21);
            this.txb_Sdt.Name = "txb_Sdt";
            this.txb_Sdt.Size = new System.Drawing.Size(236, 26);
            this.txb_Sdt.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(84)))));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(412, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 23);
            this.label5.TabIndex = 13;
            this.label5.Text = "Địa chỉ:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.UseCompatibleTextRendering = true;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(84)))));
            this.label4.Location = new System.Drawing.Point(412, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "Điện thoại:";
            this.label4.UseCompatibleTextRendering = true;
            // 
            // txb_TenKH
            // 
            this.txb_TenKH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txb_TenKH.BackColor = System.Drawing.Color.White;
            this.txb_TenKH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_TenKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txb_TenKH.Location = new System.Drawing.Point(164, 73);
            this.txb_TenKH.Name = "txb_TenKH";
            this.txb_TenKH.Size = new System.Drawing.Size(197, 26);
            this.txb_TenKH.TabIndex = 11;
            // 
            // txb_MaKH
            // 
            this.txb_MaKH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txb_MaKH.BackColor = System.Drawing.Color.White;
            this.txb_MaKH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_MaKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txb_MaKH.Location = new System.Drawing.Point(164, 21);
            this.txb_MaKH.Name = "txb_MaKH";
            this.txb_MaKH.Size = new System.Drawing.Size(197, 26);
            this.txb_MaKH.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(84)))));
            this.label3.Location = new System.Drawing.Point(40, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tên khách hàng:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(84)))));
            this.label2.Location = new System.Drawing.Point(40, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mã khách hàng:";
            // 
            // dgv_Khachhang
            // 
            this.dgv_Khachhang.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.dgv_Khachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Khachhang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Khachhang.Location = new System.Drawing.Point(0, 178);
            this.dgv_Khachhang.Name = "dgv_Khachhang";
            this.dgv_Khachhang.ReadOnly = true;
            this.dgv_Khachhang.Size = new System.Drawing.Size(811, 239);
            this.dgv_Khachhang.TabIndex = 2;
            this.dgv_Khachhang.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_Khachhang_CellMouseClick);
            // 
            // FormKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 417);
            this.Controls.Add(this.dgv_Khachhang);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormKhachHang";
            this.Text = "Danh mục khách hàng";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Khachhang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txb_Diachi;
        private System.Windows.Forms.TextBox txb_Sdt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_TenKH;
        private System.Windows.Forms.TextBox txb_MaKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_Khachhang;
        private CustomControls.RJControls.RJButton btn_Lammoi;
        private CustomControls.RJControls.RJButton btn_ThemKH;
        private CustomControls.RJControls.RJButton btn_SuaKH;
        private CustomControls.RJControls.RJButton btn_XoaKH;
        private CustomControls.RJControls.RJButton btn_Timkiem;
        private System.Windows.Forms.TextBox txb_Timkiem;
        private System.Windows.Forms.Label label1;

    }
}

