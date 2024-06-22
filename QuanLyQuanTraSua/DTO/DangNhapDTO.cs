using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DangNhapDTO
    {
        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }

        public DangNhapDTO(string TaiKhoan, string MatKhau)
        {
            this.TaiKhoan = TaiKhoan;
            this.MatKhau = MatKhau;
        }
    }
}
