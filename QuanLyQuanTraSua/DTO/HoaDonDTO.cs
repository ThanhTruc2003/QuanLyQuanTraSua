namespace QuanLyQuanTraSua.DTO
{
	public class HoaDonDTO
	{
		public HoaDonDTO()
		{
			
		}
		public HoaDonDTO (int maHoaDon, string nguoiLapHoaDon, DateTime ngayLapHoaDon, decimal tongTien)
		{
			MaHoaDon = maHoaDon;
			NguoiLapHoaDon = nguoiLapHoaDon;
			NgayLapHoaDon = ngayLapHoaDon;
			TongTien = tongTien;
		}

		public int MaHoaDon { get; set; }
		public string NguoiLapHoaDon { get; set; }
		public DateTime NgayLapHoaDon { get; set; }
		public decimal TongTien { get; set; }
		
	}
}
