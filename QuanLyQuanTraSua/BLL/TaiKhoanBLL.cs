using DAL;
using DTO;
using System.Data;

namespace BLL
{
    public class TaiKhoanBLL
    {
        private TaiKhoanDAL dal = new TaiKhoanDAL();

        public DataTable getAllUser()
        {
            return dal.getAllUser();
        }

        public DataTable getTypeUser()
        {
            return dal.getTypeUser();
        }

        public DataTable getUser(string MaQuyen)
        {
            return dal.getUser(MaQuyen);
        }

        public DataTable getMaNhanVien()
        {
            return dal.getMaNhanVien();
        }

        public bool Insert(TaiKhoanDTO dto_taikhoan)
        {
            return dal.Insert(dto_taikhoan);
        }

        public bool Delete(string MaTaiKhoan)
        {
            return dal.Delete(MaTaiKhoan);
        }

        public bool Update(TaiKhoanDTO dto_taikhoan)
        {
            return dal.Update(dto_taikhoan);
        }

        public void CloseConnection()
        {
            dal.CloseConnection();
        }
    }
}
