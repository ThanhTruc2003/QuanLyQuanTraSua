using System;
using System.Data.SqlClient;
using System.Data;
using DTO;
using DAL;


namespace DAL
{
    public class ChiTietHoaDonDAL
    {
        SqlConnection conn = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=QLQUANTRASUA;Integrated Security=True");
        public bool Insert(ChiTietHoaDonDTO dto_chitiethoadon)
        {
            string query = @"Insert into CHITIETHOADON(MaSanPham, MaHoaDon, SoLuong, DonGia) 
                     values (@MaSanPham, @MaHoaDon, @SoLuong, @DonGia)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@MaSanPham", dto_chitiethoadon.MaSanPham);
            cmd.Parameters.AddWithValue("@MaHoaDon", dto_chitiethoadon.MaHoaDon);
            cmd.Parameters.AddWithValue("@SoLuong", dto_chitiethoadon.SoLuong);
            cmd.Parameters.AddWithValue("@DonGia", dto_chitiethoadon.DonGia);
            try
            {
                conn.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
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
            return true;
        }
    }
}
