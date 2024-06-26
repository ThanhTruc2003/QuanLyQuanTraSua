using System;
using System.Data.SqlClient;
using System.Data;
using DTO;
using DAL;
using QuanLyQuanTraSua.DAL;
using QuanLyQuanTraSua.DTO;

namespace DAL
{
    public class DangNhapDAL
    {
        private SqlConnection conn = ConnectDB.GetConnection();
        public LoggedInUser checkDangNhap(string TaiKhoan, string MatKhau)
        {
            LoggedInUser loggedInUser = null;
            string query = @"Select nv.MaNhanVien, nv.HoTen, q.TenQuyen, tk.MaTaiKhoan
                            from NHANVIEN nv, TAIKHOAN tk, QUYEN Q
                            where nv.MaNhanVien = tk.MaNhanVien
                            and tk.MaQuyen = q.MaQuyen
                            and tk.Username  = @Username
                            and tk.Password = @Password";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Username", TaiKhoan);
            cmd.Parameters.AddWithValue("@Password", MatKhau);

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();


            if (reader.Read())
            {
                string maNhanvien = reader.GetString(reader.GetOrdinal("MaNhanVien"));
                string tenNhanvien = reader.GetString(reader.GetOrdinal("HoTen"));
                string tenQuyen = reader.GetString(reader.GetOrdinal("TenQuyen"));
                string maTaikhoan = reader.GetString(reader.GetOrdinal("MaTaiKhoan"));

                loggedInUser = new LoggedInUser(maNhanvien, tenNhanvien, tenQuyen, maTaikhoan);
            }
            conn.Close();
            reader.Close();
            return loggedInUser;
        }
    }
}
