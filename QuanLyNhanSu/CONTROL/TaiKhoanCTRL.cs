using QuanLyNhanSu.DOITUONG;
using QuanLyNhanSu.MOHINH;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.CONTROL
{
    class TaiKhoanCTRL
    {
        TaiKhoanMH tkMH = new TaiKhoanMH();

        public bool KiemTraDangNhap(TaiKhoanDT dtTK)
        {
            return tkMH.KiemTraDangNhap(dtTK);
        }

        public bool DoiMatKhau(TaiKhoanDT dtTK, string matkhaumoi) 
        {
            if (KiemTraDangNhap(dtTK))
                return tkMH.DoiMatKhau(dtTK, matkhaumoi);
            else
                return false;
        }
    }
}
