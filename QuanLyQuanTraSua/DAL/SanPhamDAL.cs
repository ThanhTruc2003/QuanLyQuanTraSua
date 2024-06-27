using System;
using System.Data.SqlClient;
using System.Data;
using DTO;
using DAL;
using QuanLyQuanTraSua.DAL;

namespace DAL
{
    public class SanPhamDAL
    {
		private SqlConnection conn = ConnectDB.GetConnection();
		public DataTable getProduct(string MaDanhMuc)
        {
            string query = @"SELECT sp.MaSanPham, sp.TenSanPham, sp.Size, sp.DonGia, dm.TenDanhMuc AS LoaiSanPham, sp.HinhAnh FROM SANPHAM sp INNER JOIN DANHMUCSANPHAM dm ON sp.MaDanhMuc = dm.MaDanhMuc
                             WHERE sp.MaDanhMuc = '" + MaDanhMuc + "'";
            SqlDataAdapter ada = new SqlDataAdapter(query, conn);
            DataTable table = new DataTable();
            ada.Fill(table);
            return table;
        }

        public DataTable getAllProduct()
        {
            string query = @"SELECT sp.MaSanPham, sp.TenSanPham, sp.Size, sp.DonGia, dm.TenDanhMuc AS LoaiSanPham, sp.HinhAnh FROM SANPHAM sp, DANHMUCSANPHAM dm WHERE sp.MaDanhMuc = dm.MaDanhMuc";
            SqlDataAdapter ada = new SqlDataAdapter(query, conn);
            DataTable table = new DataTable();
            ada.Fill(table);
            return table;
        }

        public DataTable getCategories()
        {
            string query = "SELECT MaDanhMuc, TenDanhMuc FROM DANHMUCSANPHAM";
            SqlDataAdapter ada = new SqlDataAdapter(query, conn);
            DataTable table = new DataTable();
            ada.Fill(table);
            return table;
        }

        public DataTable getDataByName(string tenSanPham)
        {
            string query = @"SELECT sp.MaSanPham, sp.TenSanPham, sp.Size, sp.DonGia, dm.TenDanhMuc AS LoaiSanPham, sp.HinhAnh FROM SANPHAM sp, DANHMUCSANPHAM dm 
                             WHERE sp.MaDanhMuc = dm.MaDanhMuc AND TenSanPham LIKE @tenSanPham";
            SqlDataAdapter ada = new SqlDataAdapter(query, conn);
            ada.SelectCommand.Parameters.AddWithValue("@tenSanPham", "%" + tenSanPham + "%");
            DataTable table = new DataTable();
            ada.Fill(table);
            return table;
        }

        public bool Insert(SanPhamDTO dto_sanpham)
        {
            string query = @"Insert into SANPHAM(MaSanPham, TenSanPham, Size, DonGia, MaDanhMuc, HinhAnh) 
                     values (@MaSanPham, @TenSanPham, @Size, @DonGia, @MaDanhMuc, @HinhAnh)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@MaSanPham", dto_sanpham.MaSanPham);
            cmd.Parameters.AddWithValue("@TenSanPham", dto_sanpham.TenSanPham);
            cmd.Parameters.AddWithValue("@Size", dto_sanpham.Size);
            cmd.Parameters.AddWithValue("@DonGia", dto_sanpham.DonGia);
            cmd.Parameters.AddWithValue("@MaDanhMuc", dto_sanpham.MaDanhMuc);
            cmd.Parameters.AddWithValue("@HinhAnh", dto_sanpham.HinhAnh);
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

        public bool Delete(string MaSanPham)
        {
            string sb = string.Format(@"Delete from SANPHAM
                                     where MaSanPham = '{0}'", MaSanPham);
            SqlCommand cmd = new SqlCommand(sb, conn);
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

        public bool Update(SanPhamDTO dto_sanpham)
        {
            string query = @"Update SANPHAM set  
                     TenSanPham = @TenSanPham,
                     Size = @Size,
                     DonGia = @DonGia,
                     MaDanhMuc = @MaDanhMuc,
                     HinhAnh = @HinhAnh
                     where MaSanPham = @MaSanPham";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@TenSanPham", dto_sanpham.TenSanPham);
                cmd.Parameters.AddWithValue("@Size", dto_sanpham.Size);
                cmd.Parameters.AddWithValue("@DonGia", dto_sanpham.DonGia);
                cmd.Parameters.AddWithValue("@MaDanhMuc", dto_sanpham.MaDanhMuc);
                cmd.Parameters.AddWithValue("@HinhAnh", dto_sanpham.HinhAnh);
                cmd.Parameters.AddWithValue("@MaSanPham", dto_sanpham.MaSanPham);

                try
                {
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
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

        public void CloseConnection()
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
