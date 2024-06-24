using QuanLyQuanTraSua.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanTraSua.DAL
{
	public class ThongKeDAL
	{
		private SqlConnection conn = ConnectDB.GetConnection();

		public List<ThongKeDoanhThu> ThongKeDoanhTHuTheoNgay(int month, int year)
		{
			List<ThongKeDoanhThu> thongke = new List<ThongKeDoanhThu>();
			try
			{
				string query = @"SELECT 
									CONVERT(date, NgayLapHoaDon) AS Ngay,
									SUM(TongTien) AS DoanhThu
								FROM 
									HOADON
								WHERE 
									MONTH(NgayLapHoaDon) = @Month
									AND YEAR(NgayLapHoaDon) = @Year
								GROUP BY 
									CONVERT(date, NgayLapHoaDon)
								ORDER BY 
									Ngay;";
				SqlCommand cmd = new SqlCommand(query, conn);
				cmd.Parameters.AddWithValue("Month", month);
				cmd.Parameters.AddWithValue("Year", year);
				conn.Open();
				SqlDataReader reader = cmd.ExecuteReader();

				while (reader.Read())
				{

					DateTime ngay = reader.GetDateTime(reader.GetOrdinal("Ngay"));
					decimal doanhThu = reader.GetDecimal(reader.GetOrdinal("DoanhThu"));

					thongke.Add(new ThongKeDoanhThu(ngay, doanhThu));
				}
				conn.Close();
				reader.Close();
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return thongke;
		}
		public List<ThongKeDoanhThu> ThongKeDoanhTHuTheoNam(int year)
		{
			List<ThongKeDoanhThu> thongke = new List<ThongKeDoanhThu>();
			try
			{
				string query = @"SELECT 
									MONTH(NgayLapHoaDon) AS Thang,
									SUM(TongTien) AS DoanhThu
								FROM 
									HOADON
								WHERE 
									YEAR(NgayLapHoaDon) = @Year
								GROUP BY 
									MONTH(NgayLapHoaDon)
								ORDER BY 
									Thang;";
				SqlCommand cmd = new SqlCommand(query, conn);
				cmd.Parameters.AddWithValue("Year", year);
				conn.Open();
				SqlDataReader reader = cmd.ExecuteReader();

				while (reader.Read())
				{

					int thang = reader.GetInt32(reader.GetOrdinal("Thang"));
					decimal doanhThu = reader.GetDecimal(reader.GetOrdinal("DoanhThu"));

					thongke.Add(new ThongKeDoanhThu(thang, doanhThu));
				}
				conn.Close();
				reader.Close();
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return thongke;
		}

		// format date '2024-06-01' 'year-month-day'
		public List<ThongKeSanPham> ThongKeSanPham(string startDate, string endDate)
		{
			List<ThongKeSanPham> thongke = new List<ThongKeSanPham>();
			try
			{
				string query = @"SELECT 
									SP.MaSanPham,
									SP.TenSanPham,
									SUM(CTHD.SoLuong) AS SoLuongBanDuoc
								FROM 
									SANPHAM SP
									INNER JOIN CHITIETHOADON CTHD ON SP.MaSanPham = CTHD.MaSanPham
									INNER JOIN HOADON HD ON CTHD.MaHoaDon = HD.MaHoaDon
								WHERE 
									HD.NgayLapHoaDon >= @StartDate 
									AND HD.NgayLapHoaDon <= @EndDate
								GROUP BY 
									SP.MaSanPham,
									SP.TenSanPham
								ORDER BY 
									SoLuongBanDuoc DESC;";
				SqlCommand cmd = new SqlCommand(query, conn);
				cmd.Parameters.AddWithValue("StartDate", startDate);
				cmd.Parameters.AddWithValue("EndDate", endDate);
				conn.Open();
				SqlDataReader reader = cmd.ExecuteReader();

				while (reader.Read())
				{

					string maSanPham = reader.GetString(reader.GetOrdinal("MaSanPham"));
					string tenSanPham = reader.GetString(reader.GetOrdinal("TenSanPham"));
					int soLuongBanDuoc = reader.GetInt32(reader.GetOrdinal("SoLuongBanDuoc"));

					thongke.Add(new ThongKeSanPham(maSanPham, tenSanPham, soLuongBanDuoc));
				}
				conn.Close();
				reader.Close();
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return thongke;
		}
	}
}
