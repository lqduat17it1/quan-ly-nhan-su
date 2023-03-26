namespace QuanLyNhanSu.VIEW
{
    partial class frmQuanLyNhanSu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyNhanSu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.trangChủToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuChucVu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPhongBan = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHopDongLD = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTrinhDoHocVan = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLuong = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânViênToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.hướngDẫnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHuongDan = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLuong = new System.Windows.Forms.Button();
            this.btnTrinhDoHocVan = new System.Windows.Forms.Button();
            this.btnHopDongLaoDong = new System.Windows.Forms.Button();
            this.btnPhongBan = new System.Windows.Forms.Button();
            this.btnChucVu = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDanhSachNhanVien = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDoiMatKhau = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trangChủToolStripMenuItem,
            this.nhânViênToolStripMenuItem,
            this.nhânViênToolStripMenuItem1,
            this.hướngDẫnToolStripMenuItem,
            this.đổiMậtKhẩuToolStripMenuItem,
            this.menuDangXuat,
            this.menuThoat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(635, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // trangChủToolStripMenuItem
            // 
            this.trangChủToolStripMenuItem.Checked = true;
            this.trangChủToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.trangChủToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("trangChủToolStripMenuItem.Image")));
            this.trangChủToolStripMenuItem.Name = "trangChủToolStripMenuItem";
            this.trangChủToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.trangChủToolStripMenuItem.Text = "Trang chủ";
            // 
            // nhânViênToolStripMenuItem
            // 
            this.nhânViênToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.nhânViênToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuChucVu,
            this.menuPhongBan,
            this.menuHopDongLD,
            this.menuTrinhDoHocVan,
            this.menuLuong});
            this.nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            this.nhânViênToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.nhânViênToolStripMenuItem.Text = "Thông Tin Nhân Viên";
            // 
            // menuChucVu
            // 
            this.menuChucVu.Name = "menuChucVu";
            this.menuChucVu.Size = new System.Drawing.Size(166, 22);
            this.menuChucVu.Text = "Chức Vụ";
            this.menuChucVu.Click += new System.EventHandler(this.menuChucVu_Click);
            // 
            // menuPhongBan
            // 
            this.menuPhongBan.Name = "menuPhongBan";
            this.menuPhongBan.Size = new System.Drawing.Size(166, 22);
            this.menuPhongBan.Text = "Phòng Ban";
            this.menuPhongBan.Click += new System.EventHandler(this.menuPhongBan_Click);
            // 
            // menuHopDongLD
            // 
            this.menuHopDongLD.Name = "menuHopDongLD";
            this.menuHopDongLD.Size = new System.Drawing.Size(166, 22);
            this.menuHopDongLD.Text = "Hợp Đồng Lao ";
            this.menuHopDongLD.Click += new System.EventHandler(this.menuHopDongLD_Click);
            // 
            // menuTrinhDoHocVan
            // 
            this.menuTrinhDoHocVan.Name = "menuTrinhDoHocVan";
            this.menuTrinhDoHocVan.Size = new System.Drawing.Size(166, 22);
            this.menuTrinhDoHocVan.Text = "Trình Độ Học Vấn";
            this.menuTrinhDoHocVan.Click += new System.EventHandler(this.menuTrinhDoHocVan_Click);
            // 
            // menuLuong
            // 
            this.menuLuong.Name = "menuLuong";
            this.menuLuong.Size = new System.Drawing.Size(166, 22);
            this.menuLuong.Text = "Lương";
            this.menuLuong.Click += new System.EventHandler(this.menuLuong_Click);
            // 
            // nhânViênToolStripMenuItem1
            // 
            this.nhânViênToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNhanVien});
            this.nhânViênToolStripMenuItem1.Name = "nhânViênToolStripMenuItem1";
            this.nhânViênToolStripMenuItem1.Size = new System.Drawing.Size(74, 20);
            this.nhânViênToolStripMenuItem1.Text = "Nhân Viên";
            // 
            // menuNhanVien
            // 
            this.menuNhanVien.Name = "menuNhanVien";
            this.menuNhanVien.Size = new System.Drawing.Size(130, 22);
            this.menuNhanVien.Text = "Danh Sách";
            this.menuNhanVien.Click += new System.EventHandler(this.menuNhanVien_Click);
            // 
            // hướngDẫnToolStripMenuItem
            // 
            this.hướngDẫnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHuongDan});
            this.hướngDẫnToolStripMenuItem.Name = "hướngDẫnToolStripMenuItem";
            this.hướngDẫnToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.hướngDẫnToolStripMenuItem.Text = "Hướng Dẫn";
            // 
            // menuHuongDan
            // 
            this.menuHuongDan.Name = "menuHuongDan";
            this.menuHuongDan.Size = new System.Drawing.Size(178, 22);
            this.menuHuongDan.Text = "Hướng Dẫn Chi Tiết";
            this.menuHuongDan.Click += new System.EventHandler(this.menuHuongDan_Click);
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            this.đổiMậtKhẩuToolStripMenuItem.Click += new System.EventHandler(this.đổiMậtKhẩuToolStripMenuItem_Click);
            // 
            // menuDangXuat
            // 
            this.menuDangXuat.Name = "menuDangXuat";
            this.menuDangXuat.Size = new System.Drawing.Size(74, 20);
            this.menuDangXuat.Text = "Đăng Xuất";
            this.menuDangXuat.Click += new System.EventHandler(this.menuDangXuat_Click);
            // 
            // menuThoat
            // 
            this.menuThoat.Name = "menuThoat";
            this.menuThoat.Size = new System.Drawing.Size(49, 20);
            this.menuThoat.Text = "Thoát";
            this.menuThoat.Click += new System.EventHandler(this.menuThoat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(619, 353);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.groupBox1.Controls.Add(this.btnLuong);
            this.groupBox1.Controls.Add(this.btnTrinhDoHocVan);
            this.groupBox1.Controls.Add(this.btnHopDongLaoDong);
            this.groupBox1.Controls.Add(this.btnPhongBan);
            this.groupBox1.Controls.Add(this.btnChucVu);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 326);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản lý dữ liệu";
            // 
            // btnLuong
            // 
            this.btnLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuong.Location = new System.Drawing.Point(20, 279);
            this.btnLuong.Name = "btnLuong";
            this.btnLuong.Size = new System.Drawing.Size(208, 32);
            this.btnLuong.TabIndex = 3;
            this.btnLuong.Text = "Lương";
            this.btnLuong.UseVisualStyleBackColor = true;
            this.btnLuong.Click += new System.EventHandler(this.btnLuong_Click);
            // 
            // btnTrinhDoHocVan
            // 
            this.btnTrinhDoHocVan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrinhDoHocVan.Location = new System.Drawing.Point(20, 217);
            this.btnTrinhDoHocVan.Name = "btnTrinhDoHocVan";
            this.btnTrinhDoHocVan.Size = new System.Drawing.Size(208, 32);
            this.btnTrinhDoHocVan.TabIndex = 3;
            this.btnTrinhDoHocVan.Text = "Trình độ học vấn";
            this.btnTrinhDoHocVan.UseVisualStyleBackColor = true;
            this.btnTrinhDoHocVan.Click += new System.EventHandler(this.btnTrinhDoHocVan_Click);
            // 
            // btnHopDongLaoDong
            // 
            this.btnHopDongLaoDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHopDongLaoDong.Location = new System.Drawing.Point(20, 154);
            this.btnHopDongLaoDong.Name = "btnHopDongLaoDong";
            this.btnHopDongLaoDong.Size = new System.Drawing.Size(208, 32);
            this.btnHopDongLaoDong.TabIndex = 3;
            this.btnHopDongLaoDong.Text = "Hợp đồng lao động";
            this.btnHopDongLaoDong.UseVisualStyleBackColor = true;
            this.btnHopDongLaoDong.Click += new System.EventHandler(this.btnHopDongLaoDong_Click);
            // 
            // btnPhongBan
            // 
            this.btnPhongBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhongBan.Location = new System.Drawing.Point(20, 94);
            this.btnPhongBan.Name = "btnPhongBan";
            this.btnPhongBan.Size = new System.Drawing.Size(208, 32);
            this.btnPhongBan.TabIndex = 3;
            this.btnPhongBan.Text = "Phòng ban";
            this.btnPhongBan.UseVisualStyleBackColor = true;
            this.btnPhongBan.Click += new System.EventHandler(this.btnPhongBan_Click);
            // 
            // btnChucVu
            // 
            this.btnChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChucVu.Location = new System.Drawing.Point(20, 36);
            this.btnChucVu.Name = "btnChucVu";
            this.btnChucVu.Size = new System.Drawing.Size(208, 32);
            this.btnChucVu.TabIndex = 3;
            this.btnChucVu.Text = "Chức vụ";
            this.btnChucVu.UseVisualStyleBackColor = true;
            this.btnChucVu.Click += new System.EventHandler(this.btnChucVu_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDanhSachNhanVien);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(312, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 92);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quản lý nhân viên";
            // 
            // btnDanhSachNhanVien
            // 
            this.btnDanhSachNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhSachNhanVien.Location = new System.Drawing.Point(20, 36);
            this.btnDanhSachNhanVien.Name = "btnDanhSachNhanVien";
            this.btnDanhSachNhanVien.Size = new System.Drawing.Size(208, 32);
            this.btnDanhSachNhanVien.TabIndex = 3;
            this.btnDanhSachNhanVien.Text = "Danh sách nhân viên";
            this.btnDanhSachNhanVien.UseVisualStyleBackColor = true;
            this.btnDanhSachNhanVien.Click += new System.EventHandler(this.btnDanhSachNhanVien_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDoiMatKhau);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(312, 168);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(278, 92);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cài đặt cá nhân";
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiMatKhau.Location = new System.Drawing.Point(20, 36);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(208, 32);
            this.btnDoiMatKhau.TabIndex = 3;
            this.btnDoiMatKhau.Text = "Đổi mật khẩu";
            this.btnDoiMatKhau.UseVisualStyleBackColor = true;
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(328, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Trường Tiểu học Tiên Phong";
            // 
            // frmQuanLyNhanSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 379);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmQuanLyNhanSu";
            this.Text = "PHẦN MỀM QUẢN LÝ NHÂN SỰ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmQuanLyNhanSu_FormClosed);
            this.Load += new System.EventHandler(this.frmQuanLyNhanSu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem trangChủToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuChucVu;
        private System.Windows.Forms.ToolStripMenuItem menuPhongBan;
        private System.Windows.Forms.ToolStripMenuItem menuHopDongLD;
        private System.Windows.Forms.ToolStripMenuItem menuTrinhDoHocVan;
        private System.Windows.Forms.ToolStripMenuItem menuLuong;
        private System.Windows.Forms.ToolStripMenuItem nhânViênToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuNhanVien;
        private System.Windows.Forms.ToolStripMenuItem hướngDẫnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuThoat;
        private System.Windows.Forms.ToolStripMenuItem menuHuongDan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem menuDangXuat;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLuong;
        private System.Windows.Forms.Button btnTrinhDoHocVan;
        private System.Windows.Forms.Button btnHopDongLaoDong;
        private System.Windows.Forms.Button btnPhongBan;
        private System.Windows.Forms.Button btnChucVu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDanhSachNhanVien;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDoiMatKhau;
        private System.Windows.Forms.Label label1;
    }
}