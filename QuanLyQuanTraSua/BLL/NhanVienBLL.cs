using DAL;
using DTO;
using System.Data;

namespace BLL
{
    public class NhanVienBLL
    {
        private NhanVienDAL dal = new NhanVienDAL();

        public DataTable getAllEmployee()
        {
            return dal.getAllEmployee();
        }

        public DataTable getDataByName(string TenNhanVien)
        {
            return dal.getDataByName(TenNhanVien);
        }

        public bool Insert(NhanVienDTO dto_nhanvien)
        {
            return dal.Insert(dto_nhanvien);
        }

        public DataTable getChucVu()
        {
            return dal.getChucVu();
        }

        public bool Delete(string MaNhanVien)
        {
            return dal.Delete(MaNhanVien);
        }

        public bool Update(NhanVienDTO dto_nhanvien)
        {
            return dal.Update(dto_nhanvien);
        }

        public void CloseConnection()
        {
            dal.CloseConnection();
        }
    }
}
