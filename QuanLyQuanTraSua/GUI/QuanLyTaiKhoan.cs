using BLL;
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyQuanTraSua.GUI
{
    public partial class FormQuanLyTaiKhoan : Form
    {
        private TaiKhoanBLL taikhoanBLL;
        public FormQuanLyTaiKhoan()
        {
            InitializeComponent();
        }

        private void FormQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            taikhoanBLL = new TaiKhoanBLL();
            dgvTaiKhoan.DataSource = taikhoanBLL.getAllUser();

            DataTable dt = taikhoanBLL.getTypeUser();
            cbLoaiTK.DataSource = dt;
            cbLoaiTK.DisplayMember = "TenQuyen";
            cbLoaiTK.ValueMember = "MaQuyen";
            DataRow newRow = dt.NewRow();
            newRow["MaQuyen"] = "";
            newRow["TenQuyen"] = "Tất cả";
            dt.Rows.InsertAt(newRow, 0);
            cbLoaiTK.SelectedIndex = -1;

            DataTable cb_dt = taikhoanBLL.getTypeUser();
            cbLoaiTaiKhoan.DataSource = cb_dt;
            cbLoaiTaiKhoan.DisplayMember = "TenQuyen";
            cbLoaiTaiKhoan.ValueMember = "MaQuyen";
            cbLoaiTaiKhoan.SelectedIndex = -1;

            DataTable cbMaNhanVien_dt = taikhoanBLL.getMaNhanVien();
            cbMaNhanVien.DataSource = cbMaNhanVien_dt;
            cbMaNhanVien.ValueMember = "MaNhanVien";
            cbMaNhanVien.SelectedIndex = -1;

            LoadUser("");
        }

        private void LoadUser(string MaQuyen)
        {
            taikhoanBLL = new TaiKhoanBLL();
            DataTable TK;
            if (MaQuyen == "")
            {
                TK = taikhoanBLL.getAllUser();
            }
            else
            {
                TK = taikhoanBLL.getUser(MaQuyen);
            }
            dgvTaiKhoan.DataSource = TK;
        }

        private void cbLoaiTK_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLoaiTK.SelectedIndex == -1 || cbLoaiTK.SelectedItem.ToString() == "")
            {
                LoadUser("");
            }
            else
            {
                string MaQuyen = cbLoaiTK.SelectedValue.ToString();
                LoadUser(MaQuyen);
            }
        }

        private void txbTimKiemTK_TextChanged(object sender, EventArgs e)
        {
            taikhoanBLL = new TaiKhoanBLL();
            string tenNhanVien = txbTimKiemTK.Text;
            dgvTaiKhoan.DataSource = taikhoanBLL.getDataByName(tenNhanVien);
        }

        private bool IsTaiKhoanAndNhanVienExistInDataGridView(string MaTaiKhoan, string MaNhanVien)
        {
            foreach (DataGridViewRow row in dgvTaiKhoan.Rows)
            {
                if (row.Cells["MaTaiKhoan"].Value != null)
                {
                    var maNhanVienCell = row.Cells["MaNhanVien"] as DataGridViewComboBoxCell;

                    if (maNhanVienCell != null && row.Cells["MaTaiKhoan"].Value.ToString().Trim() == MaTaiKhoan)
                    {
                        if (maNhanVienCell.Value != null && maNhanVienCell.Value.ToString().Trim() == MaNhanVien)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        private void btThemTaiKhoan_Click(object sender, EventArgs e)
        {
            taikhoanBLL = new TaiKhoanBLL();
            if (txbMaTaiKhoan.Text == "" && txbTaiKhoan.Text == "" && txbMatKhau.Text == "" && cbLoaiTaiKhoan.Text == "" && cbMaNhanVien.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txbMaTaiKhoan.Text == "" || txbTaiKhoan.Text == "" || txbMatKhau.Text == "" || cbLoaiTaiKhoan.Text == "" || cbMaNhanVien.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (IsTaiKhoanAndNhanVienExistInDataGridView(txbMaTaiKhoan.Text, cbMaNhanVien.SelectedValue.ToString()))
                {
                    MessageBox.Show("Tài khoản đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    bool isSuccess = taikhoanBLL.Insert(new TaiKhoanDTO(txbMaTaiKhoan.Text, txbTaiKhoan.Text, txbMatKhau.Text, cbLoaiTaiKhoan.SelectedValue.ToString(), cbMaNhanVien.SelectedValue.ToString()));
                    if (isSuccess)
                    {
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvTaiKhoan.DataSource = taikhoanBLL.getAllUser();
                        txbMaTaiKhoan.Clear();
                        txbTaiKhoan.Clear();
                        txbMatKhau.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
