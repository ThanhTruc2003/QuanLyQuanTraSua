using DTO;
using QuanLyQuanTraSua.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyQuanTraSua.DAL;


namespace DAL
{
    public class ChiTietHoaDonDAL
    {
        private SqlConnection conn = ConnectDB.GetConnection();
        public bool Insert(List<ChiTietHoaDonDTO> chiTietHoaDonList)
        {
            string sql = @"INSERT INTO CHITIETHOADON (MaHoaDon, MaSanPham, SoLuong, DonGia)
                   VALUES (@MaHoaDon, @MaSanPham, @SoLuong, @DonGia)";

            SqlCommand cmd = new SqlCommand(sql, conn);

            try
            {
                conn.Open();

                foreach (var chiTiet in chiTietHoaDonList)
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@MaHoaDon", chiTiet.MaHoaDon);
                    cmd.Parameters.AddWithValue("@MaSanPham", chiTiet.MaSanPham);
                    cmd.Parameters.AddWithValue("@SoLuong", chiTiet.SoLuong);
                    cmd.Parameters.AddWithValue("@DonGia", chiTiet.DonGia);

                    if (cmd.ExecuteNonQuery() <= 0)
                    {
                        return false; 
                    }
                }
                return true; 
            }
            catch (SqlException ex1)
            {
                throw ex1;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
