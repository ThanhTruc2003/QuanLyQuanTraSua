using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoanDTO
    {
        public string MaTaiKhoan { get; set; }
        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public string MaQuyen { get; set; }
        public string MaNhanVien {  get; set; }

        public TaiKhoanDTO(string MaTaiKhoan, string TaiKhoan, string MatKhau, string MaQuyen, string MaNhanVien)
        {
            this.MaTaiKhoan = MaTaiKhoan;
            this.TaiKhoan = TaiKhoan;
            this.MatKhau = MatKhau;
            this.MaQuyen = MaQuyen;
            this.MaNhanVien = MaNhanVien;
        }
    }
}
