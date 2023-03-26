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
    public partial class frmHelp : Form
    {
        public frmHelp()
        {
            InitializeComponent();
        }

        private void tvThongTinNhanVien_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Text == "Chức Vụ")
                webBrowser1.Navigate(@"C:\Users\HueLK\Documents\GitHub\quanlynhansu\Help\Hướng Dẫn Chức Vụ.htm");
            if (e.Node.Text == "Phòng Ban")
                webBrowser1.Navigate(@"C:\Users\HueLK\Documents\GitHub\quanlynhansu\Help\Hướng Dẫn Về Phòng Ban.htm");
            if (e.Node.Text == "Trình Độ Học Vấn")
                webBrowser1.Navigate(@"C:\Users\HueLK\Documents\GitHub\quanlynhansu\Help\Hướng Dẫn Trình Độ Học Vấn.htm");
            if (e.Node.Text == "Lương")
                webBrowser1.Navigate(@"C:\Users\HueLK\Documents\GitHub\quanlynhansu\Help\Hướng Dẫn Lương.htm");
            if (e.Node.Text == "Hợp Đồng Lao Động")
                webBrowser1.Navigate(@"C:\Users\HueLK\Documents\GitHub\quanlynhansu\Help\Hướng Dẫn Hợp Đồng.htm");
            if (e.Node.Text == "Nhân Viên")
                webBrowser1.Navigate(@"C:\Users\HueLK\Documents\GitHub\quanlynhansu\Help\Hướng Dẫn Nhân Viên.htm");
           
        }

        private void frmHelp_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQuanLyNhanSu ql = new frmQuanLyNhanSu();
            ql.Show();
        }

        private void frmHelp_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            frmQuanLyNhanSu ql = new frmQuanLyNhanSu();
            ql.Show();
        }
    }
}
