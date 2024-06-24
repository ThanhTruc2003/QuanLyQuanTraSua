using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanTraSua.DTO
{
	public class ThongKeSanPham
	{
		public ThongKeSanPham(string maSanPham, string tenSanPham, int SoLuongBanDuoc)
		{
			this.MaSanPham = maSanPham;
			this.TenSanPham = tenSanPham;
			this.SoLuongBanDuoc = SoLuongBanDuoc;
		}

		public string MaSanPham { get; set; }
		public string TenSanPham { get; set; }
		public int SoLuongBanDuoc { get; set; }


	}
}
