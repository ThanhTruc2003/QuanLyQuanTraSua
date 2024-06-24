using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanTraSua.Helper
{
	public class Currency
	{
		public static string convertToVND(decimal amount)
		{
			return amount.ToString("C0", CultureInfo.GetCultureInfo("vi-VN"));
		}
	}
}
