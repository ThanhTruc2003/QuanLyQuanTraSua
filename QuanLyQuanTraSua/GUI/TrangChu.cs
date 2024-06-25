using BLL;
using DAL;
using DTO;
using System.Data;
using System.Windows.Forms;

namespace QuanLyQuanTraSua.GUI
{
    public partial class FormTrangChu : Form
    {
        private bool isCollapsed;
        private FormGoiMon goiMon;
        private FormQuanLyNhanVien quanlyNhanVien;
        private FormQuanLyDanhMuc quanlyDanhMuc;
        private FormQuanLySanPham quanlySanPham;
        private FormQuanLyHoaDon quanlyHoaDon;
        private FormQuanLyTaiKhoan quanlyTaiKhoan;

        public FormTrangChu()
        {
            InitializeComponent();
        }

        private void AnForm()
        {
            if (goiMon != null)
            {
                goiMon.Hide();
            }
            if (quanlyNhanVien != null)
            {
                quanlyNhanVien.Hide();
            }
            if (quanlyDanhMuc != null)
            {
                quanlyDanhMuc.Hide();
            }
            if (quanlySanPham != null)
            {
                quanlySanPham.Hide();
            }
            if (quanlyHoaDon != null)
            {
                quanlyHoaDon.Hide();
            }
            if (quanlyTaiKhoan != null)
            {
                quanlyTaiKhoan.Hide();
            }
        }

        private void PanelGoiMon_MouseEnter(object sender, EventArgs e)
        {
            PanelGoiMon.BackColor = Color.Pink;
        }

        private void PanelGoiMon_MouseLeave(object sender, EventArgs e)
        {
            PanelGoiMon.BackColor = Color.MistyRose;
        }

        private void PanelGoiMon_Click(object sender, EventArgs e)
        {
            AnForm();
            goiMon = new FormGoiMon();
            goiMon.TopLevel = false;
            PanelAnhNen.Controls.Add(goiMon);
            goiMon.BringToFront();
            goiMon.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                PanelQuanLy.Height += 10;
                if (PanelQuanLy.Size == PanelQuanLy.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                PanelQuanLy.Height -= 10;
                if (PanelQuanLy.Size == PanelQuanLy.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void PanelQuanLy_MouseEnter(object sender, EventArgs e)
        {
            PanelQuanLy.BackColor = Color.Pink;
        }

        private void PanelQuanLy_MouseLeave(object sender, EventArgs e)
        {
            PanelQuanLy.BackColor = Color.MistyRose;
        }

        private void PanelQuanLy_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btQLNhanVien_Click(object sender, EventArgs e)
        {
            AnForm();
            quanlyNhanVien = new FormQuanLyNhanVien();
            quanlyNhanVien.TopLevel = false;
            PanelAnhNen.Controls.Add(quanlyNhanVien);
            quanlyNhanVien.BringToFront();
            quanlyNhanVien.Show();
        }

        private void btQLDanhMuc_Click(object sender, EventArgs e)
        {
            AnForm();
            quanlyDanhMuc = new FormQuanLyDanhMuc();
            quanlyDanhMuc.TopLevel = false;
            PanelAnhNen.Controls.Add(quanlyDanhMuc);
            PanelAnhNen.BackgroundImage = null;
            int x = (PanelAnhNen.Width - quanlyDanhMuc.Width) / 2;
            int y = (PanelAnhNen.Height - quanlyDanhMuc.Height) / 2;
            quanlyDanhMuc.Location = new Point(x, y);
            quanlyDanhMuc.Show();
        }

        private void btQLSanPham_Click(object sender, EventArgs e)
        {
            AnForm();
            quanlySanPham = new FormQuanLySanPham();
            quanlySanPham.TopLevel = false;
            PanelAnhNen.Controls.Add(quanlySanPham);
            quanlySanPham.BringToFront();
            quanlySanPham.Show();
        }

        private void btQLHoaDon_Click(object sender, EventArgs e)
        {
            AnForm();
            quanlyHoaDon = new FormQuanLyHoaDon();
            quanlyHoaDon.TopLevel = false;
            PanelAnhNen.Controls.Add(quanlyHoaDon);
            quanlyHoaDon.BringToFront();
            quanlyHoaDon.Show();
        }

        private void btQLTaiKhoan_Click(object sender, EventArgs e)
        {
            AnForm();
            quanlyTaiKhoan = new FormQuanLyTaiKhoan();
            quanlyTaiKhoan.TopLevel = false;
            PanelAnhNen.Controls.Add(quanlyTaiKhoan);
            quanlyTaiKhoan.BringToFront();
            quanlyTaiKhoan.Show();
        }

        private void PanelThongKe_MouseEnter(object sender, EventArgs e)
        {
            PanelThongKe.BackColor = Color.Pink;
        }

        private void PanelThongKe_MouseLeave(object sender, EventArgs e)
        {
            PanelThongKe.BackColor = Color.MistyRose;
        }

        private void PanelThongKe_Click(object sender, EventArgs e)
        {
            timerToCollapseThongKe.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                PanelHeThong.Height += 10;
                if (PanelHeThong.Size == PanelHeThong.MaximumSize)
                {
                    timer2.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                PanelHeThong.Height -= 10;
                if (PanelHeThong.Size == PanelHeThong.MinimumSize)
                {
                    timer2.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void PanelHeThong_MouseEnter(object sender, EventArgs e)
        {
            PanelHeThong.BackColor = Color.Pink;
        }

        private void PanelHeThong_MouseLeave(object sender, EventArgs e)
        {
            PanelHeThong.BackColor = Color.MistyRose;
        }

        private void PanelHeThong_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void btDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult ketqua = MessageBox.Show("Bạn có muốn đăng xuất không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ketqua == DialogResult.Yes)
            {
                FormLogin DangNhap = new FormLogin();
                this.Hide();
                DangNhap.Show();
            }
        }

        private void PanelThoat_MouseEnter(object sender, EventArgs e)
        {
            PanelThoat.BackColor = Color.Pink;
        }

        private void PanelThoat_MouseLeave(object sender, EventArgs e)
        {
            PanelThoat.BackColor = Color.MistyRose;
        }

        private void PanelThoat_Click(object sender, EventArgs e)
        {
            DialogResult ketqua = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ketqua == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void timerToCollapseThongKe_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                PanelThongKe.Height += 10;
                if (PanelThongKe.Size == PanelThongKe.MaximumSize)
                {
                    timerToCollapseThongKe.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                PanelThongKe.Height -= 10;
                if (PanelThongKe.Size == PanelThongKe.MinimumSize)
                {
                    timerToCollapseThongKe.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void btThongKeSanPham_Click(object sender, EventArgs e)
        {
            FormThongKeSanPham thongKe = new FormThongKeSanPham();
            thongKe.TopLevel = false;
            PanelAnhNen.Controls.Add(thongKe);
            thongKe.BringToFront();
            thongKe.Show();
        }

        private void btDoanhThu_Click(object sender, EventArgs e)
        {
            FormThongKe thongKe = new FormThongKe();
            thongKe.TopLevel = false;
            PanelAnhNen.Controls.Add(thongKe);
            thongKe.BringToFront();
            thongKe.Show();
        }

    }
}
