using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyNhanSu.MOHINH;
using QuanLyNhanSu.CONTROL;
using QuanLyNhanSu.DOITUONG;

namespace QuanLyNhanSu.VIEW
{
    public partial class frmDangNhap : Form
    {
        public bool dangnhapthanhcong = false;
        TaiKhoanCTRL tkCTRL = new TaiKhoanCTRL();

        public frmDangNhap()
        {
            InitializeComponent();
        }
        
       

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("bạn có muốn thoát không?", "thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            //Kiểm tra dữ liệu đăng nhập
            TaiKhoanDT tkDT = new TaiKhoanDT(txtTen.Text, txtMatKhau.Text);
            if (tkCTRL.KiemTraDangNhap(tkDT))
            {

                MessageBox.Show("Đăng nhập thành công!", "Thông báo");
                dangnhapthanhcong = true;
                BienDungChung.tendangnhaphientai = tkDT.Tendangnhap;
                this.Hide();
                frmQuanLyNhanSu Nv = new frmQuanLyNhanSu(); // mở form chính
                Nv.ShowDialog();
               
            }
            else
            {
                MessageBox.Show("Thông tin đăng nhập không hợp lệ!", "Thông báo");
                txtMatKhau.Clear();
                txtMatKhau.Focus();//di chuyển trỏ vào textbox
            }
        }

        private void Dangnhap_Load(object sender, EventArgs e)
        {

        }
        
       
    }
}
