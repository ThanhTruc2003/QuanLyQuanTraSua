using QuanLyQuanTraSua.DAL;
using QuanLyQuanTraSua.DTO;
using System.Data;

namespace QuanLyQuanTraSua.BLL
{
	public class HoaDonBLL
	{
		private HoaDonDAL dal = new HoaDonDAL();
		public DataTable getAllHoaDon()
		{
			return dal.getAllHoaDon();
		}
		public HoaDon getHoaDonById(int maHoaDon)
		{
			return dal.getHoaDonById(maHoaDon);
		}
		public DataTable getChiTietHoaDonTheoMaHoaDon(int maHoaDon)
		{
			return dal.getChiTietHoaDonTheoMaHoaDon(maHoaDon);
		}
	}
}
