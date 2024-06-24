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
    public partial class FormQuanLyNhanVien : Form
    {
        private NhanVienBLL nhanvienBLL;
        public FormQuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void FormQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            nhanvienBLL = new NhanVienBLL();
            dgvNhanVien.DataSource = nhanvienBLL.getAllEmployee();
        }

        private void txbTimKiemNV_TextChanged(object sender, EventArgs e)
        {
            string tenNhanVien = txbTimKiemNV.Text;
            dgvNhanVien.DataSource = nhanvienBLL.getDataByName(tenNhanVien);
        }

        private bool IsMaNhanVienExistInDataGridView(string MaNhanVien)
        {
            foreach (DataGridViewRow row in dgvNhanVien.Rows)
            {
                if (row.Cells["MaNhanVien"].Value != null && row.Cells["MaNhanVien"].Value.ToString().Trim() == MaNhanVien)
                {
                    return true;
                }
            }
            return false;
        }

        private void btThemNhanVien_Click(object sender, EventArgs e)
        {
            nhanvienBLL = new NhanVienBLL();
            if (txbMaNhanVien.Text == "" && txbTenNhanVien.Text == "" && txbSoDienThoai.Text == "" && !rbNam.Checked && !rbNu.Checked)
            {
                MessageBox.Show("Vui lòng nhập thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txbMaNhanVien.Text == "" || txbTenNhanVien.Text == "" || txbSoDienThoai.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (IsMaNhanVienExistInDataGridView(txbMaNhanVien.Text))
                {
                    MessageBox.Show("Mã nhân viên đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string gioiTinh = "";

                    if (rbNam.Checked)
                    {
                        gioiTinh = "Nam";
                    }
                    else if (rbNu.Checked)
                    {
                        gioiTinh = "Nữ";
                    }
                    bool isSuccess = nhanvienBLL.Insert(new NhanVienDTO(txbMaNhanVien.Text, txbTenNhanVien.Text, dtpNgaySinh.Value, gioiTinh, txbSoDienThoai.Text));
                    if (isSuccess)
                    {
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvNhanVien.DataSource = nhanvienBLL.getAllEmployee();
                        txbMaNhanVien.Clear();
                        txbTenNhanVien.Clear();
                        txbSoDienThoai.Clear();
                        rbNam.Checked = false;
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private string Selected()
        {
            int selectedIndex = dgvNhanVien.SelectedCells[0].RowIndex;
            DataGridViewRow selected = dgvNhanVien.Rows[selectedIndex];
            string selectedID = selected.Cells[0].Value.ToString();
            return selectedID;
        }

        private void btXoaNhanVien_Click(object sender, EventArgs e)
        {
            string nhanvien_selected = Selected();
            nhanvienBLL = new NhanVienBLL();
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                nhanvienBLL.Delete(nhanvien_selected);
                dgvNhanVien.DataSource = nhanvienBLL.getAllEmployee();
                txbMaNhanVien.Clear();
                txbTenNhanVien.Clear();
                txbSoDienThoai.Clear();
                rbNam.Checked = false;
                rbNu.Checked = false;
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selected = dgvNhanVien.Rows[index];
            txbMaNhanVien.Text = selected.Cells[0].Value.ToString();
            txbTenNhanVien.Text = selected.Cells[1].Value.ToString();
            object cellValue = selected.Cells[2].Value;
            if (cellValue != null && cellValue != DBNull.Value && DateTime.TryParse(cellValue.ToString(), out DateTime dateValue))
            {
                dtpNgaySinh.Value = dateValue;
            }
            object gioitinh = selected.Cells[3].Value.ToString();
            if (gioitinh != null && gioitinh.ToString() == "Nam")
            {
                rbNam.Checked = true;
                rbNu.Checked = false;
            }
            else if (gioitinh != null && gioitinh.ToString() == "Nữ")
            {
                rbNam.Checked = false;
                rbNu.Checked = true;
            }
            else
            {
                rbNam.Checked = false;
                rbNu.Checked = false;
            }
            txbSoDienThoai.Text = selected.Cells[4].Value.ToString();
        }

        private void btSuaNhanVien_Click(object sender, EventArgs e)
        {
            nhanvienBLL = new NhanVienBLL();
            if (txbMaNhanVien.Text == "" && txbTenNhanVien.Text == "" && txbSoDienThoai.Text == "" && !rbNam.Checked && !rbNu.Checked)
            {
                MessageBox.Show("Vui lòng nhập thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txbMaNhanVien.Text == "" || txbTenNhanVien.Text == "" || txbSoDienThoai.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string gioiTinh = "";

                if (rbNam.Checked)
                {
                    gioiTinh = "Nam";
                }
                else if (rbNu.Checked)
                {
                    gioiTinh = "Nữ";
                }
                bool isSuccess = nhanvienBLL.Update(new NhanVienDTO(txbMaNhanVien.Text, txbTenNhanVien.Text, dtpNgaySinh.Value, gioiTinh, txbSoDienThoai.Text));
                if (isSuccess == true)
                {
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvNhanVien.DataSource = nhanvienBLL.getAllEmployee();
                    txbMaNhanVien.Clear();
                    txbTenNhanVien.Clear();
                    txbSoDienThoai.Clear();
                    rbNam.Checked = false;
                    rbNu.Checked = false;
                }
                else
                {
                    MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FormQuanLyNhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            nhanvienBLL.CloseConnection();
        }
    }
}
