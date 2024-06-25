using BLL;
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

			LoadNhanVienChuaCoTaiKhoan();

			LoadUser("");
		}

		private void LoadNhanVienChuaCoTaiKhoan()
		{
			DataTable cbMaNhanVien_dt = taikhoanBLL.getMaNhanVien();
			cbMaNhanVien.DataSource = cbMaNhanVien_dt;
			cbMaNhanVien.ValueMember = "MaNhanVien";
			cbMaNhanVien.SelectedIndex = -1;
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

		private bool IsTaiKhoanExistInDataGridView(string MaTaiKhoan)
		{
			foreach (DataGridViewRow row in dgvTaiKhoan.Rows)
			{
				if (row.Cells["MaTaiKhoan"].Value != null && row.Cells["MaTaiKhoan"].Value.ToString().Trim() == MaTaiKhoan)
				{
					return true;
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
				if (IsTaiKhoanExistInDataGridView(txbMaTaiKhoan.Text))
				{
					MessageBox.Show("Mã tài khoản đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
						cbLoaiTaiKhoan.SelectedIndex = -1;
						cbMaNhanVien.SelectedIndex = -1;

						LoadNhanVienChuaCoTaiKhoan();
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
			int selectedIndex = dgvTaiKhoan.SelectedCells[0].RowIndex;
			DataGridViewRow selected = dgvTaiKhoan.Rows[selectedIndex];
			string selectedID = selected.Cells[0].Value.ToString();
			return selectedID;
		}

        private void btXoaTaiKhoan_Click(object sender, EventArgs e)
        {
            string taikhoan_selected = Selected();
            taikhoanBLL = new TaiKhoanBLL();
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                taikhoanBLL.Delete(taikhoan_selected);
                dgvTaiKhoan.DataSource = taikhoanBLL.getAllUser();
                txbMaTaiKhoan.Clear();
                txbTaiKhoan.Clear();
                txbMatKhau.Clear();
                cbLoaiTaiKhoan.SelectedIndex = -1;
                cbMaNhanVien.SelectedIndex = -1;
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadNhanVienChuaCoTaiKhoan();
            }
            else
            {
                MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

		private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int index = e.RowIndex;
			DataGridViewRow selected = dgvTaiKhoan.Rows[index];
			txbMaTaiKhoan.Text = selected.Cells[0].Value.ToString();
			txbTaiKhoan.Text = selected.Cells[1].Value.ToString();
			txbMatKhau.Text = selected.Cells[2].Value.ToString();
			cbLoaiTaiKhoan.Text = selected.Cells[3].Value.ToString();
			cbMaNhanVien.Text = selected.Cells[4].Value.ToString();
		}

		private void btSuaTaiKhoan_Click(object sender, EventArgs e)
		{
			if (dgvTaiKhoan.SelectedCells.Count > 0)
			{
				int selectedIndex = dgvTaiKhoan.SelectedCells[0].RowIndex;
				DataGridViewRow selectedRow = dgvTaiKhoan.Rows[selectedIndex];
				string maTaiKhoan = selectedRow.Cells["MaTaiKhoan"].Value.ToString();
				string taiKhoan = selectedRow.Cells["Username"].Value.ToString();
				string matKhau = selectedRow.Cells["Password"].Value.ToString();
				string loaiTaiKhoan = selectedRow.Cells["LoaiTaiKhoan"].Value.ToString();
				string maNhanVien = selectedRow.Cells["MaNhanVien"].Value.ToString();

				FormSuaTaiKhoan formSuaTK = new FormSuaTaiKhoan();
				formSuaTK.MaTaiKhoan = maTaiKhoan;
				formSuaTK.TaiKhoan = taiKhoan;
				formSuaTK.MatKhau = matKhau;
				formSuaTK.LoaiTaiKhoan = loaiTaiKhoan;
				formSuaTK.MaNhanVien = maNhanVien;

				if (formSuaTK.ShowDialog() == DialogResult.OK)
				{
					dgvTaiKhoan.DataSource = taikhoanBLL.getAllUser();
				}
			}
			else
			{
				MessageBox.Show("Vui lòng chọn tài khoản để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
	}
}
