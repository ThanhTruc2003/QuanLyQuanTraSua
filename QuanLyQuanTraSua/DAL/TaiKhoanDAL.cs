using System;
using System.Data.SqlClient;
using System.Data;
using DTO;
using DAL;
using QuanLyQuanTraSua.DAL;

namespace DAL
{
    public class TaiKhoanDAL
    {
		private SqlConnection conn = ConnectDB.GetConnection();

		public DataTable getAllUser()
        {
            string query = @"SELECT tk.MaTaiKhoan, tk.Username, tk.Password, q.TenQuyen, nv.HoTen
                             FROM TAIKHOAN tk, NHANVIEN nv, QUYEN q
                             WHERE tk.MaNhanVien = nv.MaNhanVien AND tk.MaQuyen = q.MaQuyen";
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
            string query = @"SELECT tk.MaTaiKhoan, tk.Username, tk.Password, q.TenQuyen, nv.HoTen FROM TAIKHOAN tk, NHANVIEN nv, QUYEN q
                             WHERE tk.MaNhanVien = nv.MaNhanVien AND tk.MaQuyen = q.MaQuyen AND q.MaQuyen = '" + MaQuyen + "'";
            SqlDataAdapter ada = new SqlDataAdapter(query, conn);
            DataTable table = new DataTable();
            ada.Fill(table);
            return table;
        }

        public DataTable getMaNhanVien()
        {
            string query = "SELECT nv.MaNhanVien, nv.HoTen FROM NHANVIEN nv LEFT JOIN TAIKHOAN tk ON nv.MaNhanVien = tk.MaNhanVien " +
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
                     Password = @Password
                     where MaTaiKhoan = @MaTaiKhoan";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Username", dto_taikhoan.TaiKhoan);
                cmd.Parameters.AddWithValue("@Password", dto_taikhoan.MatKhau);
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

        public bool isValidPassword(string maTk,  string password)
        {
			string querry = "SELECT * FROM TAIKHOAN WHERE MaTaiKhoan = '" + maTk + "'AND Password = '" + password + "'";

			SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

			DataTable dtable = new DataTable();
			sda.Fill(dtable);

			if (dtable.Rows.Count > 0)
			{
				return true;
			}
			return false;
		}
		public bool ChangePassword(string maTk, string password)
		{
			string query = @"Update TAIKHOAN set  
                     Password = @Password
                     where MaTaiKhoan = @MaTaiKhoan";

			using (SqlCommand cmd = new SqlCommand(query, conn))
			{
				cmd.Parameters.AddWithValue("@Password", password);
				cmd.Parameters.AddWithValue("@MaTaiKhoan", maTk);

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
