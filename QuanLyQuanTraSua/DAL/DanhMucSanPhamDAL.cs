using System;
using System.Data.SqlClient;
using System.Data;
using DTO;
using DAL;
using QuanLyQuanTraSua.DAL;

namespace DAL
{
    public class DanhMucSanPhamDAL
    {
		private SqlConnection conn = ConnectDB.GetConnection();
		public DataTable getData()
        {
            string querry = "SELECT * FROM DANHMUCSANPHAM";
            SqlDataAdapter ada = new SqlDataAdapter(querry, conn);
            DataTable table = new DataTable();
            ada.Fill(table);
            return table;
        }

        public DataTable getDataByName(string tenDanhMuc)
        {
            string querry = "SELECT * FROM DANHMUCSANPHAM WHERE TenDanhMuc LIKE @tenDanhMuc";
            SqlDataAdapter ada = new SqlDataAdapter(querry, conn);
            ada.SelectCommand.Parameters.AddWithValue("@tenDanhMuc", "%" + tenDanhMuc + "%");
            DataTable table = new DataTable();
            ada.Fill(table);
            return table;
        }

        public bool Insert(DanhMucSanPhamDTO dto_danhmucsanpham)
        {
            string sb = string.Format(@"Insert into DANHMUCSANPHAM(MaDanhMuc, TenDanhMuc) values 
                                    ('{0}',N'{1}')", dto_danhmucsanpham.MaDanhMuc, dto_danhmucsanpham.TenDanhMuc);
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
