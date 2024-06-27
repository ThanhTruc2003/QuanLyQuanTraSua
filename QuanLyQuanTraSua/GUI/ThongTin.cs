using BLL;
using DAL;
using DTO;
using QuanLyQuanTraSua.BLL;
using QuanLyQuanTraSua.DTO;
using QuanLyQuanTraSua.Properties;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace QuanLyQuanTraSua.GUI
{
    public partial class FormThongTin : Form
    {
        private NhanVienBLL nhanVienBLL;
        private TaiKhoanBLL taiKhoanBLL;
        public FormThongTin()
        {
            InitializeComponent();
        }

        private void FormThongTin_Load(object sender, EventArgs e)
        {
            nhanVienBLL = new NhanVienBLL();
            txbMaNV.Text = Authentication.loggedInUser.MaNhanVien;
            txbTenNV.Text = Authentication.loggedInUser.TenNhanVien;
            DataTable dt = nhanVienBLL.getDataByName(txbTenNV.Text);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0]; // Lấy hàng dữ liệu đầu tiên

                if (row["NgaySinh"] != DBNull.Value)
                {
                    dpNgaySinh.Value = Convert.ToDateTime(row["NgaySinh"]);
                }

                // Gán giá trị vào RadioButton
                if (row["GioiTinh"] != DBNull.Value)
                {
                    string gioiTinh = row["GioiTinh"].ToString();
                    if (gioiTinh == "Nam")
                    {
                        rbNam.Checked = true;
                    }
                    else if (gioiTinh == "Nữ")
                    {
                        rbNu.Checked = true;
                    }
                }
                txbSDT.Text = row["SoDienThoai"].ToString();
            }

            taiKhoanBLL = new TaiKhoanBLL();
            txbTK.Text = Authentication.loggedInUser.MaTaiKhoan;
            DataTable dt1 = taiKhoanBLL.getAllUser();
            if (dt1.Rows.Count > 0)
            {
                DataRow row = dt1.Rows[0];
                txbMK.PasswordChar = '*';
                txbMK.Text = row["Password"].ToString();
            }    
        }
    }
}
