using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanTraSua.DAL
{
	public class ConnectDB
	{
		private static SqlConnection conn;
		public static void Start()
		{
			conn = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=QLQUANTRASUA;Integrated Security=True");
		}
		public static SqlConnection GetConnection()
		{
			return conn;
		}
		public static void Close()
		{
			conn.Close();
		}
	}
}
