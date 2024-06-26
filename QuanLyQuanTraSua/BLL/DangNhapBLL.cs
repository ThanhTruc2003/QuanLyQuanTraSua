using DTO;
using DAL;
using System.Data;
using QuanLyQuanTraSua.DTO;

namespace BLL
{
    public class DangNhapBLL
    {
        private DangNhapDAL dal = new DangNhapDAL();
        public LoggedInUser Check(DangNhapDTO dto_DangNhap)
        {
            return dal.checkDangNhap(dto_DangNhap.TaiKhoan, dto_DangNhap.MatKhau);
        }
    }
}
