using System;
using System.Data.SqlClient;
using System.Data;
using DTO;
using DAL;
using QuanLyQuanTraSua.DAL;

namespace DAL
{
    public class DangNhapDAL
    {
		private SqlConnection conn = ConnectDB.GetConnection();
		public bool checkDangNhap(string TaiKhoan, string MatKhau)
        {
            string querry = "SELECT * FROM TAIKHOAN WHERE Username = '" + TaiKhoan + "'AND Password = '" + MatKhau + "'";

            SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

            DataTable dtable = new DataTable();
            sda.Fill(dtable);

            if (dtable.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
    }
}
