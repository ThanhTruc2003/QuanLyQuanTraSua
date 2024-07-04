using BLL;
using DAL;
using DTO;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyQuanTraSua.GUI
{
    public partial class FormQuanLyDanhMuc : Form
    {
        private DanhMucSanPhamBLL danhmucBLL;

        public FormQuanLyDanhMuc()
        {
            InitializeComponent();
        }

        private void FormQuanLyDanhMuc_Load(object sender, EventArgs e)
        {
            danhmucBLL = new DanhMucSanPhamBLL();
            dgvDanhMuc.DataSource = danhmucBLL.getData();
        }

        private void txbTimKiem_TextChanged(object sender, EventArgs e)
        {
            string tenDanhMuc = txbTimKiem.Text;
            dgvDanhMuc.DataSource = danhmucBLL.getDataByName(tenDanhMuc);
        }

        private bool IsMaDanhMucExistInDataGridView(string MaDanhMuc)
        {
            foreach (DataGridViewRow row in dgvDanhMuc.Rows)
            {
                if (row.Cells["MaDanhMuc"].Value != null && row.Cells["MaDanhMuc"].Value.ToString().Trim() == MaDanhMuc)
                {
                    return true;
                }
            }
            return false;
        }

        private void btThemDanhMuc_Click(object sender, EventArgs e)
        {
            danhmucBLL = new DanhMucSanPhamBLL();
            if (txbMaDanhMuc.Text == "" && txbTenDanhMuc.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txbMaDanhMuc.Text == "" || txbTenDanhMuc.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (IsMaDanhMucExistInDataGridView(txbMaDanhMuc.Text))
                {
                    MessageBox.Show("Danh mục đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    bool isSuccess = danhmucBLL.Insert(new DanhMucSanPhamDTO(txbMaDanhMuc.Text, txbTenDanhMuc.Text));
                    if (isSuccess)
                    {
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DanhMucSanPhamBLL danhMucSanPhamBLL = new DanhMucSanPhamBLL();
                        dgvDanhMuc.DataSource = danhMucSanPhamBLL.getData();
                        txbMaDanhMuc.Clear();
                        txbTenDanhMuc.Clear();
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
            int selectedIndex = dgvDanhMuc.SelectedCells[0].RowIndex;
            DataGridViewRow selected = dgvDanhMuc.Rows[selectedIndex];
            string selectedID = selected.Cells[0].Value.ToString();
            return selectedID;
        }

        private void btXoaDanhMuc_Click(object sender, EventArgs e)
        {
            string danhmuc_selected = Selected();
            danhmucBLL = new DanhMucSanPhamBLL();
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    danhmucBLL.Delete(danhmuc_selected);
                    dgvDanhMuc.DataSource = danhmucBLL.getData();
                    txbMaDanhMuc.Clear();
                    txbTenDanhMuc.Clear();
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvDanhMuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selected = dgvDanhMuc.Rows[index];
            txbMaDanhMuc.Text = selected.Cells[0].Value.ToString();
            txbTenDanhMuc.Text = selected.Cells[1].Value.ToString();
        }

        private void btSuaDanhMuc_Click(object sender, EventArgs e)
        {
            danhmucBLL = new DanhMucSanPhamBLL();
            if (txbMaDanhMuc.Text == "" && txbTenDanhMuc.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txbMaDanhMuc.Text == "" || txbTenDanhMuc.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                bool isSuccess = danhmucBLL.Update(new DanhMucSanPhamDTO(txbMaDanhMuc.Text, txbTenDanhMuc.Text));
                if (isSuccess == true)
                {
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvDanhMuc.DataSource = danhmucBLL.getData();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FormQuanLyDanhMuc_FormClosed(object sender, FormClosedEventArgs e)
        {
            danhmucBLL.CloseConnection();
        }
    }
}
