using QuanLyQuanTraSua.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanTraSua.DAL
{
	public class HoaDonDAL
	{
		SqlConnection conn; 
		public HoaDonDAL() { 
			conn = ConnectDB.GetConnection();
		}

		public DataTable getAllHoaDon()
		{
			string query = @"SELECT MaHoaDon, NHANVIEN.HoTen as NguoiLapHoaDon, NgayLapHoaDon, TongTien  
							FROM HOADON
							JOIN NHANVIEN ON HOADON.NguoiLapHoaDon = NHANVIEN.MaNhanVien;";
			SqlDataAdapter ada = new SqlDataAdapter(query, conn);
			DataTable table = new DataTable();
			ada.Fill(table);
			return table;
		}
		public HoaDon getHoaDonById(int maHoaDon)
		{
			HoaDon hoaDon = null;
			try
			{
				string query = @"SELECT MaHoaDon, NHANVIEN.HoTen as NguoiLapHoaDon, NgayLapHoaDon, TongTien  
                         FROM HOADON
                         JOIN NHANVIEN ON HOADON.NguoiLapHoaDon = NHANVIEN.MaNhanVien
                         WHERE HOADON.MaHoaDon = @MaHoaDon";
				SqlCommand cmd = new SqlCommand(query, conn);
				cmd.Parameters.AddWithValue("@MaHoaDon", maHoaDon);
				conn.Open();
				SqlDataReader reader = cmd.ExecuteReader();


				if (reader.Read())
				{
					int id = reader.GetInt32(reader.GetOrdinal("MaHoaDon"));
					string nguoiLap = reader.GetString(reader.GetOrdinal("NguoiLapHoaDon"));
					DateTime ngayLap = reader.GetDateTime(reader.GetOrdinal("NgayLapHoaDon"));
					decimal tongTien = reader.GetDecimal(reader.GetOrdinal("TongTien"));

					hoaDon = new HoaDon(id, nguoiLap, ngayLap, tongTien);
				}
				conn.Close();
				reader.Close();
			}catch (Exception ex)
			{
				throw ex;
			}
			return hoaDon;
		}
		public DataTable getChiTietHoaDonTheoMaHoaDon(int maHoaDon)
		{
			string query = @"SELECT CHITIETHOADON.MaSanPham, 
								SANPHAM.TenSanPham, 
								SANPHAM.Size,
								CHITIETHOADON.SoLuong, 
								CHITIETHOADON.DonGia
							FROM CHITIETHOADON
							JOIN HOADON ON CHITIETHOADON.MaHoaDon = HOADON.MaHoaDon
							JOIN SANPHAM ON SANPHAM.MaSanPham = CHITIETHOADON.MaSanPham 
							WHERE HOADON.MaHoaDon = @MaHoaDon";
			SqlDataAdapter ada = new SqlDataAdapter(query, conn);
			ada.SelectCommand.Parameters.AddWithValue("@MaHoaDon", maHoaDon);
			DataTable table = new DataTable();
			ada.Fill(table);
			return table;
		}
	}
}
