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

        public DataTable getMaNhanVien()
        {
            string query = "SELECT nv.MaNhanVien FROM NHANVIEN nv LEFT JOIN TAIKHOAN tk ON nv.MaNhanVien = tk.MaNhanVien " +
                           " WHERE tk.MaNhanVien IS NULL";
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

        public bool Delete(string MaTaiKhoan)
        {
            string sb = string.Format(@"Delete from TAIKHOAN
                                     where MaTaiKhoan = '{0}'", MaTaiKhoan);
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

        public bool Update(TaiKhoanDTO dto_taikhoan)
        {
            string query = @"Update TAIKHOAN set  
                     Username = @Username,
                     Password = @Password,
                     MaQuyen = @MaQuyen,
                     MaNhanVien = @MaNhanVien
                     where MaTaiKhoan = @MaTaiKhoan";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Username", dto_taikhoan.TaiKhoan);
                cmd.Parameters.AddWithValue("@Password", dto_taikhoan.MatKhau);
                cmd.Parameters.AddWithValue("@MaQuyen", dto_taikhoan.MaQuyen);
                cmd.Parameters.AddWithValue("@MaNhanVien", dto_taikhoan.MaNhanVien);
                cmd.Parameters.AddWithValue("@MaTaiKhoan", dto_taikhoan.MaTaiKhoan);

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
