using BLL;
using DAL;
using DTO;
using QuanLyQuanTraSua.GUI;

namespace QuanLyQuanTraSua
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btShowEye_Click(object sender, EventArgs e)
        {
            if (txbMatKhau.PasswordChar == '*')
            {
                btHideEye.BringToFront();
                txbMatKhau.PasswordChar = '\0';
            }
        }

        private void btHideEye_Click(object sender, EventArgs e)
        {
            if (txbMatKhau.PasswordChar == '\0')
            {
                btShowEye.BringToFront();
                txbMatKhau.PasswordChar = '*';
            }
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            string TaiKhoan, MatKhau;
            TaiKhoan = txbTaiKhoan.Text;
            MatKhau = txbMatKhau.Text;
            if (txbTaiKhoan.Text == "" && txbMatKhau.Text == "")
            {
                MessageBox.Show("Vui lòng điền thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txbTaiKhoan.Text == "" || txbMatKhau.Text == "")
            {
                MessageBox.Show("Vui lòng điền thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DangNhapBLL bll = new DangNhapBLL();
                bool checkDangNhap = bll.Check(new DangNhapDTO(TaiKhoan, MatKhau));
                if (checkDangNhap)
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormTrangChu Home = new FormTrangChu();
                    Home.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Đăng nhập không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult ketqua = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ketqua == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}