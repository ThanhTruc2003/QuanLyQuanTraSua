using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SanPhamDTO
    {
        public string MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public string Size { get; set; }
        public int DonGia { get; set; }
        public string MaDanhMuc { get; set; }
        public string HinhAnh { get; set; }

        public SanPhamDTO(string MaSanPham, string TenSanPham, string Size, int DonGia, string MaDanhMuc, string HinhAnh)
        {
            this.MaSanPham = MaSanPham;
            this.TenSanPham = TenSanPham;
            this.Size = Size;
            this.DonGia = DonGia;
            this.MaDanhMuc = MaDanhMuc;
            this.HinhAnh = HinhAnh;
        }
    }
}
