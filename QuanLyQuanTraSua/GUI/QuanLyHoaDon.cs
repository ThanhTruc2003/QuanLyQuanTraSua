using BLL;
using QuanLyQuanTraSua.BLL;
using QuanLyQuanTraSua.DAL;
using QuanLyQuanTraSua.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanTraSua.GUI
{
	public partial class FormQuanLyHoaDon : Form
	{
		private HoaDonBLL hoadonBLL;
		public FormQuanLyHoaDon()
		{
			InitializeComponent();
		}

		private void FormQuanLyHoaDon_Load(object sender, EventArgs e)
		{
			hoadonBLL = new HoaDonBLL();
			dgvHoaDon.DataSource = hoadonBLL.getAllHoaDon();
		}

		private void txbTimKiemHoaDon_TextChanged(object sender, EventArgs e)
		{
try
			{
				if (txbTimKiemHoaDon.Text != "")
				{
					List<HoaDon> list = new List<HoaDon>();
					list.Add(hoadonBLL.getHoaDonById(int.Parse(txbTimKiemHoaDon.Text)));
					dgvHoaDon.DataSource = list;
				}
				else
				{
					dgvHoaDon.DataSource = hoadonBLL.getAllHoaDon();
				}

			}
			catch
			{

			}

		}

		private void buttonXemChiTiet_Click(object sender, EventArgs e)
		{
			try
			{
				int selectedOrderId = getSelectedOrderId();
				new FormChiTietHoaDon(selectedOrderId).ShowDialog();
			}
    catch 
			{
				MessageBox.Show("Vui lòng chọn hóa đơn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private int getSelectedOrderId()
		{
			try
			{
				DataGridViewCell selectedCell = dgvHoaDon.SelectedCells[0];

				int selectedRowIndex = selectedCell.RowIndex;
				string selectedOrderId = dgvHoaDon.Rows[selectedRowIndex].Cells["MaHoaDon"].Value.ToString();
				return int.Parse(selectedOrderId);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

	}
}
