using QuanLyNhanSu.DOITUONG;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.MOHINH
{
    class TaiKhoanMH
    {
        KCSDL conn = new KCSDL();
        SqlCommand cmd = new SqlCommand();

        public bool KiemTraDangNhap(TaiKhoanDT dtTK)
        {
            bool result = false;
            cmd.CommandText = "SELECT COUNT(*) FROM taikhoan WHERE tendangnhap = '" + dtTK.Tendangnhap + "' AND matkhau = '" + dtTK.Matkhau + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn.Connection;
            Debug.WriteLine(cmd.CommandText);
            try
            {
                //mở kết nối
                conn.OpenConn();
                if ((int)cmd.ExecuteScalar() > 0)
                {
                    result = true;
                }
                conn.CloseConn();

            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();//xóa bỏ phiên làm việc,loại bỏ ra khỏi hẳn bộ nhớ
                conn.CloseConn();
            }
            return result;
        }

        public bool DoiMatKhau(TaiKhoanDT dtTKm, string matkhaumoi)
        {
            cmd.CommandText = "UPDATE taikhoan SET matkhau = '" + matkhaumoi + "' WHERE tendangnhap = '" + dtTKm.Tendangnhap + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn.Connection;
            try
            {
                conn.OpenConn();
                cmd.ExecuteNonQuery();
                conn.CloseConn();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                conn.CloseConn();
            }
            return false;
        }
    }
}
