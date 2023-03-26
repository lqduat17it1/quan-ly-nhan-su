using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DOITUONG
{
    class TaiKhoanDT
    {
        string tendangnhap, matkhau;

        public TaiKhoanDT()
        {
        }

        public TaiKhoanDT(string tendangnhap, string matkhau)
        {
            this.tendangnhap = tendangnhap;
            this.matkhau = matkhau;
        }

        public string Tendangnhap { get => tendangnhap; set => tendangnhap = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }
    }
}
