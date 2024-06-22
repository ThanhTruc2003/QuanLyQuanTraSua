using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DanhMucSanPhamDTO
    {
        public string MaDanhMuc { get; set; }
        public string TenDanhMuc { get; set; }

        public DanhMucSanPhamDTO(string MaDanhMuc, string TenDanhMuc)
        {
            this.MaDanhMuc = MaDanhMuc;
            this.TenDanhMuc = TenDanhMuc;
        }
    }

}
