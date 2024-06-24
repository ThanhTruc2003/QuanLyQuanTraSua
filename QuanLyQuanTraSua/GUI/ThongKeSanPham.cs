using QuanLyQuanTraSua.BLL;
using QuanLyQuanTraSua.DTO;
using QuanLyQuanTraSua.Helper;
using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace QuanLyQuanTraSua.GUI
{
	public partial class FormThongKeSanPham : Form
	{
		private ThongKeBLL thongkeBLL;
		public FormThongKeSanPham()
		{
			InitializeComponent();
			this.thongkeBLL = new ThongKeBLL();
			setUpDatePicker();
			dgvSanPham.RowPrePaint += dataGridView1_RowPrePaint;
			showThongKe();
		}
		private void setUpDatePicker()
		{
			formatDatePicker();
			setDefaultStartDate();
			setDefaultEndDate();
		}
		private void formatDatePicker()
		{
			dpStartDate.Format = DateTimePickerFormat.Custom;
			dpStartDate.CustomFormat = "dd/MM/yyyy";

			dpEndDate.Format = DateTimePickerFormat.Custom;
			dpEndDate.CustomFormat = "dd/MM/yyyy";
		}

		private void setDefaultStartDate()
		{
			// Tính ngày 7 ngày trước từ ngày hiện tại
			DateTime defaultDate = DateTime.Today.AddDays(-7);
			dpStartDate.Value = defaultDate;

		}

		private void setDefaultEndDate()
		{
			// Ngày hiện tại
			dpEndDate.Value = DateTime.Today;

		}
		private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
		{
			// Hiển thị số thứ tự (index + 1) vào cột đầu tiên của mỗi dòng
			dgvSanPham.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
		}

		private void showThongKe()
		{
			dgvSanPham.DataSource = thongkeBLL.ThongKeSanPham(dpStartDate.Value, dpEndDate.Value);
		}
		private void btnFilter_Click(object sender, EventArgs e)
		{
			showThongKe();
		}
	}
}
