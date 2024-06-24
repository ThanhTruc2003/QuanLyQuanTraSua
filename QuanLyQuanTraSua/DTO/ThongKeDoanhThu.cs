
namespace QuanLyQuanTraSua.DTO
{
	public class ThongKeDoanhThu
	{
		public ThongKeDoanhThu(DateTime ngay, decimal doanhThu)
		{
			Ngay = ngay;
			DoanhThu = doanhThu;
		}
		public ThongKeDoanhThu(int thang, decimal doanhThu)
		{
			Thang = thang;
			DoanhThu = doanhThu;
		}
		public ThongKeDoanhThu(DateTime ngay, decimal doanhThu, int thang)
		{
			Ngay = ngay;
			DoanhThu = doanhThu;
			Thang = thang;
		}

		public DateTime Ngay { get; set; }
		public decimal DoanhThu { get; set; }
		public int Thang { get; set; }

	}
}
