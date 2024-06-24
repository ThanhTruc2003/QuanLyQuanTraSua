using QuanLyQuanTraSua.DAL;
using QuanLyQuanTraSua.DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanTraSua.BLL
{
	public class ThongKeBLL
	{
		private ThongKeDAL thongKeDAL = new ThongKeDAL();

		public List<ThongKeDoanhThu> ThongKeDoanhTHuTheoNgay(int month, int year)
		{
			return thongKeDAL.ThongKeDoanhTHuTheoNgay(month, year);
		}
		public List<ThongKeDoanhThu> ThongKeDoanhTHuTheoNam(int year)
		{
			return thongKeDAL.ThongKeDoanhTHuTheoNam(year);
		}
		public List<ThongKeSanPham> ThongKeSanPham(DateTime startDate, DateTime endDate)
		{
			return thongKeDAL.ThongKeSanPham(startDate.ToString("yyyy-MM-dd"), endDate.ToString("yyyy-MM-dd"));
		}
	}
}
