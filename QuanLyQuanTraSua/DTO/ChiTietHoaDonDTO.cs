using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietHoaDonDTO
    {
        public string MaSanPham { get; set; }
        public string MaHoaDon { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }

        public ChiTietHoaDonDTO(string MaSanPham, string MaHoaDon, int SoLuong, decimal DonGia)
        {
            this.MaSanPham = MaSanPham;
            this.MaHoaDon = MaHoaDon;
            this.SoLuong = SoLuong;
            this.DonGia = DonGia;
        }

        public ChiTietHoaDonDTO() 
        {

        }
    }
}
