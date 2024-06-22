using DAL;
using DTO;
using System.Data;

namespace BLL
{
    public class SanPhamBLL
    {
        private SanPhamDAL dal = new SanPhamDAL();
        public DataTable getProduct(string MaDanhMuc)
        {
            return dal.getProduct(MaDanhMuc);
        }

        public DataTable getAllProduct()
        {
            return dal.getAllProduct();
        }

        public DataTable getCategories()
        {
            return dal.getCategories();
        }

        public DataTable getDataByName(string tenSanPham)
        {
            return dal.getDataByName(tenSanPham);
        }

        public bool Insert(SanPhamDTO dto_sanpham)
        {
            return dal.Insert(dto_sanpham);
        }

        public bool Delete(string MaSanPham)
        {
            return dal.Delete(MaSanPham);
        }

        public bool Update(SanPhamDTO dto_sanpham)
        {
            return dal.Update(dto_sanpham);
        }

        public void CloseConnection()
        {
            dal.CloseConnection();
        }
    }
}
