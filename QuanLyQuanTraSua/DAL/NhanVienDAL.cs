﻿using System;
using System.Data.SqlClient;
using System.Data;
using DTO;
using DAL;
using QuanLyQuanTraSua.DAL;

namespace DAL
{
    public class NhanVienDAL
    {
		private SqlConnection conn = ConnectDB.GetConnection();
		public DataTable getAllEmployee()
        {
            string query = @"SELECT nv.MaNhanVien, nv.HoTen, nv.NgaySinh, nv.GioiTinh, nv.SoDienThoai, q.TenQuyen 
                             FROM NHANVIEN nv
                             LEFT JOIN TAIKHOAN tk ON nv.MaNhanVien = tk.MaNhanVien
                             LEFT JOIN QUYEN q ON tk.MaQuyen = q.MaQuyen";
            SqlDataAdapter ada = new SqlDataAdapter(query, conn);
            DataTable table = new DataTable();
            ada.Fill(table);
            return table;
        }

        public DataTable getDataByName(string TenNhanVien)
        {
            string query = @"SELECT nv.MaNhanVien, nv.HoTen, nv.NgaySinh, nv.GioiTinh, nv.SoDienThoai, q.TenQuyen 
                             FROM NHANVIEN nv
                             LEFT JOIN TAIKHOAN tk ON nv.MaNhanVien = tk.MaNhanVien
                             LEFT JOIN QUYEN q ON tk.MaQuyen = q.MaQuyen
                             WHERE nv.HoTen LIKE @TenNhanVien";
            SqlDataAdapter ada = new SqlDataAdapter(query, conn);
            ada.SelectCommand.Parameters.AddWithValue("@TenNhanVien", "%" + TenNhanVien + "%");
            DataTable table = new DataTable();
            ada.Fill(table);
            return table;
        }

        public bool Insert(NhanVienDTO dto_nhanvien)
        {
            string sql = @"INSERT INTO NHANVIEN (MaNhanVien, HoTen, NgaySinh, GioiTinh, SoDienThoai)
                   VALUES (@MaNhanVien, @HoTen, @NgaySinh, @GioiTinh, @SoDienThoai)";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaNhanVien", dto_nhanvien.MaNhanVien);
            cmd.Parameters.AddWithValue("@HoTen", dto_nhanvien.HoTen);
            cmd.Parameters.AddWithValue("@NgaySinh", dto_nhanvien.NgaySinh);
            cmd.Parameters.AddWithValue("@GioiTinh", dto_nhanvien.GioiTinh);
            cmd.Parameters.AddWithValue("@SoDienThoai", dto_nhanvien.SoDienThoai);
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

        public bool Delete(string MaNhanVien)
        {
            string sb = string.Format(@"Delete from NHANVIEN
                                     where MaNhanVien = '{0}'", MaNhanVien);
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

        public bool Update(NhanVienDTO dto_nhanvien)
        {
            string query = @"Update NHANVIEN set  
                     HoTen = @HoTen,
                     NgaySinh = @NgaySinh,
                     GioiTinh = @GioiTinh,
                     SoDienThoai = @SoDienThoai
                     where MaNhanVien = @MaNhanVien";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@HoTen", dto_nhanvien.HoTen);
                cmd.Parameters.AddWithValue("@NgaySinh", dto_nhanvien.NgaySinh);
                cmd.Parameters.AddWithValue("@GioiTinh", dto_nhanvien.GioiTinh);
                cmd.Parameters.AddWithValue("@SoDienThoai", dto_nhanvien.SoDienThoai);
                cmd.Parameters.AddWithValue("@MaNhanVien", dto_nhanvien.MaNhanVien);

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
