using BLL;
using QuanLyQuanTraSua.BLL;
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
		}

		private void buttonXemChiTiet_Click(object sender, EventArgs e)
		{
			try
			{
				int selectedOrderId = getSelectedOrderId();
				new FormChiTietHoaDon(selectedOrderId).ShowDialog();
			}
			catch (Exception ex) { }
			{

			}

		}

		private int getSelectedOrderId()
		{
			DataGridViewCell selectedCell = dgvHoaDon.SelectedCells[0];

			int selectedRowIndex = selectedCell.RowIndex;
			string selectedOrderId = dgvHoaDon.Rows[selectedRowIndex].Cells["MaHoaDon"].Value.ToString();
			return int.Parse(selectedOrderId);
		}

	}
}
