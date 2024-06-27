using BLL;
using QuanLyQuanTraSua.BLL;
using QuanLyQuanTraSua.DTO;
using System.Data;

namespace QuanLyQuanTraSua.GUI
{
    public partial class FormChiTietHoaDon : Form
    {
        private HoaDonBLL hoaDonBLL;
        private HoaDonDTO hoaDon;
        public FormChiTietHoaDon(int orderId)
        {
            InitializeComponent();
            this.hoaDonBLL = new HoaDonBLL();
            this.hoaDon = hoaDonBLL.getHoaDonById(orderId);
        }

        private void FormQuanLySanPham_Load(object sender, EventArgs e)
        {
            dgvSanPham.DataSource = hoaDonBLL.getChiTietHoaDonTheoMaHoaDon(hoaDon.MaHoaDon);
            txtMaHoaDon.Text = hoaDon.MaHoaDon.ToString();
            txtNguoiLapHoaDon.Text = hoaDon.NguoiLapHoaDon;
            txtThoiGian.Text = hoaDon.NgayLapHoaDon.ToString("dd/MM/yyyy HH:mm");
            txtTongTien.Text = hoaDon.TongTien.ToString();
        }
    }
}
