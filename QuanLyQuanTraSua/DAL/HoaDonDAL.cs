using DTO;
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
		public HoaDonDAL() 
		{ 
			conn = ConnectDB.GetConnection();
		}

		public DataTable getAllHoaDon()
		{
			string query = @"SELECT MaHoaDon, NHANVIEN.HoTen as NguoiLapHoaDon, NgayLapHoaDon, TongTien  
							FROM HOADON
							JOIN NHANVIEN ON HOADON.NguoiLapHoaDon = NHANVIEN.MaNhanVien ORDER BY MaHoaDon ASC";
			SqlDataAdapter ada = new SqlDataAdapter(query, conn);
			DataTable table = new DataTable();
			ada.Fill(table);
			return table;
		}

		public HoaDonDTO getHoaDonById(int maHoaDon)
		{
			HoaDonDTO hoaDon = null;
			try
			{
				string query = @"SELECT MaHoaDon, NHANVIEN.HoTen as NguoiLapHoaDon, NgayLapHoaDon, TongTien  
                         FROM HOADON
                         JOIN NHANVIEN ON HOADON.NguoiLapHoaDon = NHANVIEN.MaNhanVien
                         WHERE HOADON.MaHoaDon = @MaHoaDon ORDER BY MaHoaDon ASC";
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

					hoaDon = new HoaDonDTO(id, nguoiLap, ngayLap, tongTien);
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
							WHERE HOADON.MaHoaDon = @MaHoaDon ORDER BY CHITIETHOADON.MaHoaDon ASC";
			SqlDataAdapter ada = new SqlDataAdapter(query, conn);
			ada.SelectCommand.Parameters.AddWithValue("@MaHoaDon", maHoaDon);
			DataTable table = new DataTable();
			ada.Fill(table);
			return table;
		}

        public int Insert(HoaDonDTO dto_hoadon)
        {
            DateTime NgayLapHoaDon = DateTime.Now;
            string sql = @"INSERT INTO HOADON (NguoiLapHoaDon, NgayLapHoaDon, TongTien)
                   OUTPUT INSERTED.MaHoaDon
                   VALUES (@NguoiLapHoaDon, @NgayLapHoaDon, @TongTien)";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@NguoiLapHoaDon", dto_hoadon.NguoiLapHoaDon);
            cmd.Parameters.AddWithValue("@NgayLapHoaDon", NgayLapHoaDon);
            cmd.Parameters.AddWithValue("@TongTien", dto_hoadon.TongTien);

            try
            {
                conn.Open();
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    return Convert.ToInt32(result);
                }
            }
            catch (SqlException ex1)
            {
                throw ex1;
            }
            finally
            {
                conn.Close();
            }
            return -1; 
        }
    }
}
