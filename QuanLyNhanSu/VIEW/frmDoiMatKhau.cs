using QuanLyNhanSu.CONTROL;
using QuanLyNhanSu.DOITUONG;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu.VIEW
{
    public partial class frmDoiMatKhau : Form
    {
        TaiKhoanCTRL tkCTRL = new TaiKhoanCTRL();

        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            TaiKhoanDT tkDT = new TaiKhoanDT(BienDungChung.tendangnhaphientai, txtMatKhauCu.Text);
            if (tkCTRL.KiemTraDangNhap(tkDT))
            {
                if (tkCTRL.DoiMatKhau(tkDT, txtMatKhauMoi.Text))
                {
                    MessageBox.Show("Đổi mật khẩu thành công ", "thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Thoat();
                }
                else
                    MessageBox.Show("Đổi mật khẩu thất bại ", "thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Mật Khẩu cũ không đúng!", "Thông báo");
                txtMatKhauCu.Clear();
                txtMatKhauCu.Focus();//di chuyển trỏ vào textbox
            }
        }

        private void Thoat()
        {
            this.Hide();
            frmQuanLyNhanSu ql = new frmQuanLyNhanSu();
            ql.Show();
        }

        private void frmDoiMatKhau_FormClosed(object sender, FormClosedEventArgs e)
        {
            Thoat();
        }
    }
}
