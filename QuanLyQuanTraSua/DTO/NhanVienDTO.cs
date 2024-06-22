using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVienDTO
    {
        public string MaNhanVien { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string SoDienThoai { get; set; }
        public string ChucVu { get; set; }

        public NhanVienDTO(string MaNhanVien, string HoTen, DateTime NgaySinh, string GioiTinh, string SoDienThoai, string ChucVu)
        {
            this.MaNhanVien = MaNhanVien;
            this.HoTen = HoTen;
            this.NgaySinh = NgaySinh;
            this.GioiTinh = GioiTinh;
            this.SoDienThoai = SoDienThoai;
            this.ChucVu = ChucVu;
        }
    }
}
