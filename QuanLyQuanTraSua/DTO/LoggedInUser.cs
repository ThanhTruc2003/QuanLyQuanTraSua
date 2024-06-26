using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanTraSua.DTO
{
    public class LoggedInUser
    {
        public LoggedInUser(string maNhanVien, string tenNhanVien, string tenQuyen, string maTaiKhoan)
        {
            MaNhanVien = maNhanVien;
            TenNhanVien = tenNhanVien;
            TenQuyen = tenQuyen;
            MaTaiKhoan = maTaiKhoan;
        }

        public string MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public string TenQuyen { get; set; }
        public string MaTaiKhoan { get; set; }
    }
}
