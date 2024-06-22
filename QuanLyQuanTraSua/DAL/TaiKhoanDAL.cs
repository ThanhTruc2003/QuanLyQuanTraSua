using System;
using System.Data.SqlClient;
using System.Data;
using DTO;
using DAL;

namespace DAL
{
    public class TaiKhoanDAL
    {
        SqlConnection conn = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=QLQUANTRASUA;Integrated Security=True");

        public DataTable getAllUser()
        {
            string query = @"SELECT tk.MaTaiKhoan, tk.Username, tk.Password, q.TenQuyen, tk.MaNhanVien
                             FROM TAIKHOAN tk, NHANVIEN nv, QUYEN q
                             WHERE tk.MaNhanVien = nv.MaNhanVien AND tk.MaQuyen = q.MaQuyen
                             ORDER BY CAST(tk.MaTaiKhoan AS INT) ASC";
            SqlDataAdapter ada = new SqlDataAdapter(query, conn);
            DataTable table = new DataTable();
            ada.Fill(table);
            return table;
        }

        public DataTable getTypeUser()
        {
            string query = "SELECT MaQuyen, TenQuyen FROM QUYEN";
            SqlDataAdapter ada = new SqlDataAdapter(query, conn);
            DataTable table = new DataTable();
            ada.Fill(table);
            return table;
        }

        public DataTable getUser(string MaQuyen)
        {
            string query = @"SELECT tk.MaTaiKhoan, tk.Username, tk.Password, q.TenQuyen, tk.MaNhanVien FROM TAIKHOAN tk, NHANVIEN nv, QUYEN q
                             WHERE tk.MaNhanVien = nv.MaNhanVien AND tk.MaQuyen = q.MaQuyen AND q.MaQuyen = '" + MaQuyen + "' ORDER BY CAST(tk.MaTaiKhoan AS INT) ASC";
            SqlDataAdapter ada = new SqlDataAdapter(query, conn);
            DataTable table = new DataTable();
            ada.Fill(table);
            return table;
        }

        public DataTable getDataByName(string TenNhanVien)
        {
            string query = @"SELECT tk.MaTaiKhoan, tk.Username, tk.Password, q.TenQuyen, tk.MaNhanVien FROM TAIKHOAN tk, NHANVIEN nv, QUYEN q
                             WHERE tk.MaNhanVien = nv.MaNhanVien AND tk.MaQuyen = q.MaQuyen AND nv.HoTen LIKE @TenNhanVien ORDER BY CAST(tk.MaTaiKhoan AS INT) ASC";
            SqlDataAdapter ada = new SqlDataAdapter(query, conn);
            ada.SelectCommand.Parameters.AddWithValue("@TenNhanVien", "%" + TenNhanVien + "%");
            DataTable table = new DataTable();
            ada.Fill(table);
            return table;
        }

        public DataTable getMaNhanVien()
        {
            string query = "SELECT MaNhanVien FROM NHANVIEN";
            SqlDataAdapter ada = new SqlDataAdapter(query, conn);
            DataTable table = new DataTable();
            ada.Fill(table);
            return table;
        }

        public bool Insert(TaiKhoanDTO dto_taikhoan)
        {
            string sql = @"INSERT INTO TAIKHOAN (MaTaiKhoan, Username, Password, MaQuyen, MaNhanVien)
                           VALUES (@MaTaiKhoan, @Username, @Password, @MaQuyen, @MaNhanVien)";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaTaiKhoan", dto_taikhoan.MaTaiKhoan);
            cmd.Parameters.AddWithValue("@Username", dto_taikhoan.TaiKhoan);
            cmd.Parameters.AddWithValue("@Password", dto_taikhoan.MatKhau);
            cmd.Parameters.AddWithValue("@MaQuyen", dto_taikhoan.MaQuyen);
            cmd.Parameters.AddWithValue("@MaNhanVien", dto_taikhoan.MaNhanVien);
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

        public bool Delete(string MaDanhMuc)
        {
            string sb = string.Format(@"Delete from DANHMUCSANPHAM
                                     where MaDanhMuc = '{0}'", MaDanhMuc);
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

        public bool Update(DanhMucSanPhamDTO dto_danhmucsanpham)
        {
            string sb = string.Format(@"Update DANHMUCSANPHAM set  
                                TenDanhMuc = N'{0}'
                                where MaDanhMuc = '{1}'",
                                dto_danhmucsanpham.TenDanhMuc, dto_danhmucsanpham.MaDanhMuc);
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

        public void CloseConnection()
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
