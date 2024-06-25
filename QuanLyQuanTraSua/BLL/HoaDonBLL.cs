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
		public HoaDonDTO getHoaDonById(int maHoaDon)
		{
			return dal.getHoaDonById(maHoaDon);
		}
		public DataTable getChiTietHoaDonTheoMaHoaDon(int maHoaDon)
		{
			return dal.getChiTietHoaDonTheoMaHoaDon(maHoaDon);
		}
		public int Insert(HoaDonDTO dto_hoadon)
		{
			return dal.Insert(dto_hoadon);
		}
    }
}
