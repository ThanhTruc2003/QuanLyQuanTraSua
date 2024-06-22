using DTO;
using DAL;
using System.Data;

namespace BLL
{
    public class DangNhapBLL
    {
        private DangNhapDAL dal = new DangNhapDAL();
        public bool Check(DangNhapDTO dto_DangNhap)
        {
            if (dal.checkDangNhap(dto_DangNhap.TaiKhoan, dto_DangNhap.MatKhau))
            {
                return true;
            }
            return false;
        }
    }
}
