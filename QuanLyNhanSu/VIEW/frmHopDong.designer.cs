﻿namespace QuanLyNhanSu.VIEW
{
    partial class frmHopDong
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHopDong));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.cmbTenNhanVien = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLoaiHopDong = new System.Windows.Forms.TextBox();
            this.txtMaHopDong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvHopDong = new System.Windows.Forms.DataGridView();
            this.mahopdong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaihopdong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tungay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manhanvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennhanvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.btnHuy = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCapNhat = new System.Windows.Forms.ToolStripButton();
            this.btnThoat = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHopDong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.dtpTuNgay);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpDenNgay);
            this.groupBox1.Controls.Add(this.cmbTenNhanVien);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtLoaiHopDong);
            this.groupBox1.Controls.Add(this.txtMaHopDong);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(626, 144);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Của Hợp Đồng Lao Động";
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Enabled = false;
            this.dtpTuNgay.Location = new System.Drawing.Point(439, 32);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(167, 22);
            this.dtpTuNgay.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(350, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Từ Ngày:";
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Enabled = false;
            this.dtpDenNgay.Location = new System.Drawing.Point(439, 65);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(167, 22);
            this.dtpDenNgay.TabIndex = 25;
            // 
            // cmbTenNhanVien
            // 
            this.cmbTenNhanVien.Enabled = false;
            this.cmbTenNhanVien.FormattingEnabled = true;
            this.cmbTenNhanVien.Location = new System.Drawing.Point(105, 100);
            this.cmbTenNhanVien.Name = "cmbTenNhanVien";
            this.cmbTenNhanVien.Size = new System.Drawing.Size(198, 24);
            this.cmbTenNhanVien.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(9, 108);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Tên Nhân Viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(350, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Đến Ngày:";
            // 
            // txtLoaiHopDong
            // 
            this.txtLoaiHopDong.Enabled = false;
            this.txtLoaiHopDong.Location = new System.Drawing.Point(105, 64);
            this.txtLoaiHopDong.Name = "txtLoaiHopDong";
            this.txtLoaiHopDong.Size = new System.Drawing.Size(198, 22);
            this.txtLoaiHopDong.TabIndex = 3;
            // 
            // txtMaHopDong
            // 
            this.txtMaHopDong.Enabled = false;
            this.txtMaHopDong.Location = new System.Drawing.Point(105, 32);
            this.txtMaHopDong.Name = "txtMaHopDong";
            this.txtMaHopDong.Size = new System.Drawing.Size(198, 22);
            this.txtMaHopDong.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Hợp Đồng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Loại Hợp Đồng:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvHopDong);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 189);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(626, 169);
            this.groupBox2.TabIndex = 61;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Hợp Đồng Lao Động";
            // 
            // dgvHopDong
            // 
            this.dgvHopDong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHopDong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahopdong,
            this.loaihopdong,
            this.tungay,
            this.denngay,
            this.manhanvien,
            this.tennhanvien});
            this.dgvHopDong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHopDong.Location = new System.Drawing.Point(3, 18);
            this.dgvHopDong.Name = "dgvHopDong";
            this.dgvHopDong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHopDong.Size = new System.Drawing.Size(620, 148);
            this.dgvHopDong.TabIndex = 0;
            // 
            // mahopdong
            // 
            this.mahopdong.DataPropertyName = "mahopdong";
            this.mahopdong.HeaderText = "Mã Hợp Đồng";
            this.mahopdong.Name = "mahopdong";
            // 
            // loaihopdong
            // 
            this.loaihopdong.DataPropertyName = "loaihopdong";
            this.loaihopdong.HeaderText = "Loại Hợp Đồng";
            this.loaihopdong.Name = "loaihopdong";
            // 
            // tungay
            // 
            this.tungay.DataPropertyName = "tungay";
            this.tungay.HeaderText = "Từ Ngày";
            this.tungay.Name = "tungay";
            // 
            // denngay
            // 
            this.denngay.DataPropertyName = "denngay";
            this.denngay.HeaderText = "Đến Ngày";
            this.denngay.Name = "denngay";
            // 
            // manhanvien
            // 
            this.manhanvien.DataPropertyName = "manhanvien";
            this.manhanvien.HeaderText = "Mã Nhân Viên";
            this.manhanvien.Name = "manhanvien";
            // 
            // tennhanvien
            // 
            this.tennhanvien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tennhanvien.DataPropertyName = "tennhanvien";
            this.tennhanvien.HeaderText = "Tên Nhân Viên";
            this.tennhanvien.Name = "tennhanvien";
            this.tennhanvien.Width = 111;
            // 
            // bindingNavigator2
            // 
            this.bindingNavigator2.AddNewItem = null;
            this.bindingNavigator2.CountItem = null;
            this.bindingNavigator2.DeleteItem = null;
            this.bindingNavigator2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThem,
            this.toolStripSeparator5,
            this.btnSua,
            this.toolStripSeparator6,
            this.btnXoa,
            this.toolStripSeparator7,
            this.btnHuy,
            this.toolStripSeparator8,
            this.btnCapNhat,
            this.btnThoat});
            this.bindingNavigator2.Location = new System.Drawing.Point(0, 368);
            this.bindingNavigator2.MoveFirstItem = null;
            this.bindingNavigator2.MoveLastItem = null;
            this.bindingNavigator2.MoveNextItem = null;
            this.bindingNavigator2.MovePreviousItem = null;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = null;
            this.bindingNavigator2.Size = new System.Drawing.Size(650, 25);
            this.bindingNavigator2.TabIndex = 69;
            this.bindingNavigator2.Text = "bindingNavigator2";
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(57, 22);
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // btnSua
            // 
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(46, 22);
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(47, 22);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // btnHuy
            // 
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(49, 22);
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.Image")));
            this.btnCapNhat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(77, 22);
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(81, 22);
            this.btnThoat.Text = "Trang Chủ";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 393);
            this.Controls.Add(this.bindingNavigator2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmHopDong";
            this.Text = "HỢP ĐỒNG LAO ĐỘNG";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmHopDong_FormClosed);
            this.Load += new System.EventHandler(this.frmHopDong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHopDong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.ComboBox cmbTenNhanVien;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLoaiHopDong;
        private System.Windows.Forms.TextBox txtMaHopDong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvHopDong;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahopdong;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaihopdong;
        private System.Windows.Forms.DataGridViewTextBoxColumn tungay;
        private System.Windows.Forms.DataGridViewTextBoxColumn denngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn manhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennhanvien;
        private System.Windows.Forms.BindingNavigator bindingNavigator2;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton btnHuy;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton btnCapNhat;
        private System.Windows.Forms.ToolStripButton btnThoat;
    }
}