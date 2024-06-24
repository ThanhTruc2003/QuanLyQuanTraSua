using DAL;
using DTO;
using System.Data;
using System.Windows.Forms;

namespace BLL
{
    public class ChiTietHoaDonBLL
    {
        private ChiTietHoaDonDAL dal = new ChiTietHoaDonDAL();
        public bool Insert(ChiTietHoaDonDTO dto_chitiethoadon)
        {
            return dal.Insert(dto_chitiethoadon);
        }
    }
}
