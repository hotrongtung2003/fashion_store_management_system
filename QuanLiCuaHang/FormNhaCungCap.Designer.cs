namespace QuanLiCuaHang
{
    partial class FormNhaCungCap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNhaCungCap));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Timkiem = new CustomControls.RJControls.RJButton();
            this.txb_Timkiem = new System.Windows.Forms.TextBox();
            this.btn_SuaKH = new CustomControls.RJControls.RJButton();
            this.btn_XoaNV = new CustomControls.RJControls.RJButton();
            this.btn_Lammoi = new CustomControls.RJControls.RJButton();
            this.btn_ThemNV = new CustomControls.RJControls.RJButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txb_Diachi = new System.Windows.Forms.TextBox();
            this.txb_Sdt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_TenNhaCC = new System.Windows.Forms.TextBox();
            this.txb_MaNhaCC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_NhaCC = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhaCC)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_Timkiem);
            this.panel1.Controls.Add(this.txb_Timkiem);
            this.panel1.Controls.Add(this.btn_SuaKH);
            this.panel1.Controls.Add(this.btn_XoaNV);
            this.panel1.Controls.Add(this.btn_Lammoi);
            this.panel1.Controls.Add(this.btn_ThemNV);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.txb_Diachi);
            this.panel1.Controls.Add(this.txb_Sdt);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txb_TenNhaCC);
            this.panel1.Controls.Add(this.txb_MaNhaCC);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 174);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(84)))));
            this.label1.Location = new System.Drawing.Point(496, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 19);
            this.label1.TabIndex = 35;
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
            this.btn_Timkiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btn_Timkiem.Image = ((System.Drawing.Image)(resources.GetObject("btn_Timkiem.Image")));
            this.btn_Timkiem.Location = new System.Drawing.Point(685, 116);
            this.btn_Timkiem.Name = "btn_Timkiem";
            this.btn_Timkiem.Size = new System.Drawing.Size(35, 33);
            this.btn_Timkiem.TabIndex = 34;
            this.btn_Timkiem.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btn_Timkiem.UseVisualStyleBackColor = false;
            this.btn_Timkiem.Click += new System.EventHandler(this.btn_Timkiem_Click);
            // 
            // txb_Timkiem
            // 
            this.txb_Timkiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txb_Timkiem.BackColor = System.Drawing.Color.White;
            this.txb_Timkiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Timkiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txb_Timkiem.Location = new System.Drawing.Point(499, 119);
            this.txb_Timkiem.Name = "txb_Timkiem";
            this.txb_Timkiem.Size = new System.Drawing.Size(180, 26);
            this.txb_Timkiem.TabIndex = 33;
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
            this.btn_SuaKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btn_SuaKH.Image = ((System.Drawing.Image)(resources.GetObject("btn_SuaKH.Image")));
            this.btn_SuaKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SuaKH.Location = new System.Drawing.Point(142, 115);
            this.btn_SuaKH.Name = "btn_SuaKH";
            this.btn_SuaKH.Size = new System.Drawing.Size(96, 34);
            this.btn_SuaKH.TabIndex = 32;
            this.btn_SuaKH.Text = "   Sửa";
            this.btn_SuaKH.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btn_SuaKH.UseVisualStyleBackColor = false;
            this.btn_SuaKH.Click += new System.EventHandler(this.btn_SuaKH_Click);
            // 
            // btn_XoaNV
            // 
            this.btn_XoaNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_XoaNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(84)))));
            this.btn_XoaNV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(84)))));
            this.btn_XoaNV.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_XoaNV.BorderRadius = 16;
            this.btn_XoaNV.BorderSize = 0;
            this.btn_XoaNV.FlatAppearance.BorderSize = 0;
            this.btn_XoaNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_XoaNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btn_XoaNV.Image = ((System.Drawing.Image)(resources.GetObject("btn_XoaNV.Image")));
            this.btn_XoaNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_XoaNV.Location = new System.Drawing.Point(252, 115);
            this.btn_XoaNV.Name = "btn_XoaNV";
            this.btn_XoaNV.Size = new System.Drawing.Size(97, 34);
            this.btn_XoaNV.TabIndex = 31;
            this.btn_XoaNV.Text = "   Xóa";
            this.btn_XoaNV.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btn_XoaNV.UseVisualStyleBackColor = false;
            this.btn_XoaNV.Click += new System.EventHandler(this.btn_XoaNV_Click);
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
            this.btn_Lammoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btn_Lammoi.Image = ((System.Drawing.Image)(resources.GetObject("btn_Lammoi.Image")));
            this.btn_Lammoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Lammoi.Location = new System.Drawing.Point(363, 115);
            this.btn_Lammoi.Name = "btn_Lammoi";
            this.btn_Lammoi.Size = new System.Drawing.Size(97, 34);
            this.btn_Lammoi.TabIndex = 30;
            this.btn_Lammoi.Text = "Làm mới";
            this.btn_Lammoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Lammoi.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btn_Lammoi.UseVisualStyleBackColor = false;
            this.btn_Lammoi.Click += new System.EventHandler(this.btn_Lammoi_Click);
            // 
            // btn_ThemNV
            // 
            this.btn_ThemNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ThemNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(84)))));
            this.btn_ThemNV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(84)))));
            this.btn_ThemNV.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_ThemNV.BorderRadius = 16;
            this.btn_ThemNV.BorderSize = 0;
            this.btn_ThemNV.FlatAppearance.BorderSize = 0;
            this.btn_ThemNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThemNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btn_ThemNV.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThemNV.Image")));
            this.btn_ThemNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ThemNV.Location = new System.Drawing.Point(35, 115);
            this.btn_ThemNV.Name = "btn_ThemNV";
            this.btn_ThemNV.Size = new System.Drawing.Size(93, 34);
            this.btn_ThemNV.TabIndex = 29;
            this.btn_ThemNV.Text = "    Thêm";
            this.btn_ThemNV.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btn_ThemNV.UseVisualStyleBackColor = false;
            this.btn_ThemNV.Click += new System.EventHandler(this.btn_ThemNV_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.panel4.Location = new System.Drawing.Point(499, 86);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(0, 0);
            this.panel4.TabIndex = 23;
            // 
            // txb_Diachi
            // 
            this.txb_Diachi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txb_Diachi.BackColor = System.Drawing.Color.White;
            this.txb_Diachi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Diachi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txb_Diachi.Location = new System.Drawing.Point(500, 63);
            this.txb_Diachi.Name = "txb_Diachi";
            this.txb_Diachi.Size = new System.Drawing.Size(220, 26);
            this.txb_Diachi.TabIndex = 15;
            // 
            // txb_Sdt
            // 
            this.txb_Sdt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txb_Sdt.BackColor = System.Drawing.Color.White;
            this.txb_Sdt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Sdt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txb_Sdt.Location = new System.Drawing.Point(500, 10);
            this.txb_Sdt.Name = "txb_Sdt";
            this.txb_Sdt.Size = new System.Drawing.Size(220, 26);
            this.txb_Sdt.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(84)))));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(406, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Địa chỉ:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(84)))));
            this.label4.Location = new System.Drawing.Point(406, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Số điện thoại:";
            // 
            // txb_TenNhaCC
            // 
            this.txb_TenNhaCC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txb_TenNhaCC.BackColor = System.Drawing.Color.White;
            this.txb_TenNhaCC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_TenNhaCC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txb_TenNhaCC.Location = new System.Drawing.Point(159, 63);
            this.txb_TenNhaCC.Name = "txb_TenNhaCC";
            this.txb_TenNhaCC.Size = new System.Drawing.Size(214, 26);
            this.txb_TenNhaCC.TabIndex = 11;
            // 
            // txb_MaNhaCC
            // 
            this.txb_MaNhaCC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txb_MaNhaCC.BackColor = System.Drawing.Color.White;
            this.txb_MaNhaCC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_MaNhaCC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txb_MaNhaCC.Location = new System.Drawing.Point(159, 10);
            this.txb_MaNhaCC.Name = "txb_MaNhaCC";
            this.txb_MaNhaCC.Size = new System.Drawing.Size(214, 26);
            this.txb_MaNhaCC.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(84)))));
            this.label3.Location = new System.Drawing.Point(35, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tên nhà cung cấp:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(84)))));
            this.label2.Location = new System.Drawing.Point(35, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mã nhà cung cấp:";
            // 
            // dgv_NhaCC
            // 
            this.dgv_NhaCC.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.dgv_NhaCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NhaCC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_NhaCC.Location = new System.Drawing.Point(0, 174);
            this.dgv_NhaCC.Name = "dgv_NhaCC";
            this.dgv_NhaCC.ReadOnly = true;
            this.dgv_NhaCC.Size = new System.Drawing.Size(760, 237);
            this.dgv_NhaCC.TabIndex = 4;
            this.dgv_NhaCC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Nhanvien_CellContentClick);
            this.dgv_NhaCC.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_Nhanvien_CellMouseClick);
            // 
            // FormNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 411);
            this.Controls.Add(this.dgv_NhaCC);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(631, 367);
            this.Name = "FormNhaCungCap";
            this.Text = "FormNhanVien";
            this.Load += new System.EventHandler(this.FormNhanVien_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhaCC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txb_Diachi;
        private System.Windows.Forms.TextBox txb_Sdt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_TenNhaCC;
        private System.Windows.Forms.TextBox txb_MaNhaCC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_NhaCC;
        private System.Windows.Forms.Panel panel4;
        private CustomControls.RJControls.RJButton btn_SuaKH;
        private CustomControls.RJControls.RJButton btn_XoaNV;
        private CustomControls.RJControls.RJButton btn_Lammoi;
        private CustomControls.RJControls.RJButton btn_ThemNV;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJButton btn_Timkiem;
        private System.Windows.Forms.TextBox txb_Timkiem;
    }
}