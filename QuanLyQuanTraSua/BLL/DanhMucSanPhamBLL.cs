using DAL;
using DTO;
using System.Data;


namespace BLL
{
    public class DanhMucSanPhamBLL
    {
        private DanhMucSanPhamDAL dal = new DanhMucSanPhamDAL();
        public DataTable getData()
        {
            return dal.getData();
        }

        public DataTable getDataByName(string tenDanhMuc)
        {
            return dal.getDataByName(tenDanhMuc);
        }

        public bool Insert(DanhMucSanPhamDTO dto_danhmucsanpham)
        {
            return dal.Insert(dto_danhmucsanpham);
        }

        public bool Delete(string MaDanhMuc)
        {
            return dal.Delete(MaDanhMuc);
        }

        public bool Update(DanhMucSanPhamDTO dto_danhmucsanpham)
        {
            return dal.Update(dto_danhmucsanpham);
        }

        public void CloseConnection()
        {
            dal.CloseConnection();
        }
    }
}
