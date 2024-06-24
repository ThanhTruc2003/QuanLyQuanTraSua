namespace QuanLyQuanTraSua.GUI
{
	partial class FormChiTietHoaDon
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
			lbDanhSachSP = new Label();
			dgvSanPham = new DataGridView();
			MaSanPham = new DataGridViewTextBoxColumn();
			TenSanPham = new DataGridViewTextBoxColumn();
			Size = new DataGridViewTextBoxColumn();
			SoLuong = new DataGridViewTextBoxColumn();
			DonGia = new DataGridViewTextBoxColumn();
			openFileDialog1 = new OpenFileDialog();
			lbMaHoaDon = new Label();
			lbNguoiLapHoaDon = new Label();
			lbNgay = new Label();
			label1 = new Label();
			txtTongTien = new Label();
			txtNguoiLapHoaDon = new Label();
			txtMaHoaDon = new Label();
			txtThoiGian = new Label();
			((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
			SuspendLayout();
			// 
			// lbDanhSachSP
			// 
			lbDanhSachSP.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
			lbDanhSachSP.Location = new Point(12, 9);
			lbDanhSachSP.Name = "lbDanhSachSP";
			lbDanhSachSP.Size = new Size(780, 25);
			lbDanhSachSP.TabIndex = 0;
			lbDanhSachSP.Text = "CHI TIẾT HÓA ĐƠN";
			lbDanhSachSP.TextAlign = ContentAlignment.TopCenter;
			// 
			// dgvSanPham
			// 
			dgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvSanPham.BackgroundColor = Color.White;
			dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 192, 192);
			dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
			dgvSanPham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			dgvSanPham.ColumnHeadersHeight = 29;
			dgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			dgvSanPham.Columns.AddRange(new DataGridViewColumn[] { MaSanPham, TenSanPham, Size, SoLuong, DonGia });
			dgvSanPham.EnableHeadersVisualStyles = false;
			dgvSanPham.Location = new Point(12, 120);
			dgvSanPham.Name = "dgvSanPham";
			dgvSanPham.RowHeadersWidth = 51;
			dgvSanPham.RowTemplate.Height = 60;
			dgvSanPham.Size = new Size(780, 411);
			dgvSanPham.TabIndex = 4;
			dgvSanPham.TabStop = false;
			dgvSanPham.CellClick += dgvSanPham_CellClick;
			// 
			// MaSanPham
			// 
			MaSanPham.DataPropertyName = "MaSanPham";
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
			MaSanPham.DefaultCellStyle = dataGridViewCellStyle2;
			MaSanPham.HeaderText = "Mã sản phẩm";
			MaSanPham.MinimumWidth = 6;
			MaSanPham.Name = "MaSanPham";
			// 
			// TenSanPham
			// 
			TenSanPham.DataPropertyName = "TenSanPham";
			dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
			TenSanPham.DefaultCellStyle = dataGridViewCellStyle3;
			TenSanPham.HeaderText = "Tên sản phẩm";
			TenSanPham.MinimumWidth = 6;
			TenSanPham.Name = "TenSanPham";
			// 
			// Size
			// 
			Size.DataPropertyName = "Size";
			dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
			Size.DefaultCellStyle = dataGridViewCellStyle4;
			Size.HeaderText = "Size";
			Size.MinimumWidth = 6;
			Size.Name = "Size";
			// 
			// SoLuong
			// 
			SoLuong.DataPropertyName = "SoLuong";
			dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
			SoLuong.DefaultCellStyle = dataGridViewCellStyle5;
			SoLuong.HeaderText = "Số lượng";
			SoLuong.MinimumWidth = 6;
			SoLuong.Name = "SoLuong";
			// 
			// DonGia
			// 
			DonGia.DataPropertyName = "DonGia";
			dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
			DonGia.DefaultCellStyle = dataGridViewCellStyle6;
			DonGia.HeaderText = "Đơn giá (đồng)";
			DonGia.MinimumWidth = 6;
			DonGia.Name = "DonGia";
			// 
			// openFileDialog1
			// 
			openFileDialog1.FileName = "openFileDialog1";
			// 
			// lbMaHoaDon
			// 
			lbMaHoaDon.AutoSize = true;
			lbMaHoaDon.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			lbMaHoaDon.Location = new Point(45, 52);
			lbMaHoaDon.Name = "lbMaHoaDon";
			lbMaHoaDon.Size = new Size(92, 20);
			lbMaHoaDon.TabIndex = 5;
			lbMaHoaDon.Text = "Mã hóa đơn";
			// 
			// lbNguoiLapHoaDon
			// 
			lbNguoiLapHoaDon.AutoSize = true;
			lbNguoiLapHoaDon.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			lbNguoiLapHoaDon.Location = new Point(419, 52);
			lbNguoiLapHoaDon.Name = "lbNguoiLapHoaDon";
			lbNguoiLapHoaDon.Size = new Size(139, 20);
			lbNguoiLapHoaDon.TabIndex = 5;
			lbNguoiLapHoaDon.Text = "Người lập hóa đơn";
			lbNguoiLapHoaDon.Click += lbNguoiLapHoaDon_Click;
			// 
			// lbNgay
			// 
			lbNgay.AutoSize = true;
			lbNgay.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			lbNgay.Location = new Point(45, 84);
			lbNgay.Name = "lbNgay";
			lbNgay.Size = new Size(74, 20);
			lbNgay.TabIndex = 5;
			lbNgay.Text = "Thời gian";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(419, 84);
			label1.Name = "label1";
			label1.Size = new Size(76, 20);
			label1.TabIndex = 5;
			label1.Text = "Tổng tiền";
			label1.Click += label1_Click;
			// 
			// txtTongTien
			// 
			txtTongTien.AutoSize = true;
			txtTongTien.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			txtTongTien.Location = new Point(575, 84);
			txtTongTien.Name = "txtTongTien";
			txtTongTien.Size = new Size(87, 20);
			txtTongTien.TabIndex = 5;
			txtTongTien.Text = "txtTongTien";
			txtTongTien.Click += label1_Click;
			// 
			// txtNguoiLapHoaDon
			// 
			txtNguoiLapHoaDon.AutoSize = true;
			txtNguoiLapHoaDon.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			txtNguoiLapHoaDon.Location = new Point(575, 52);
			txtNguoiLapHoaDon.Name = "txtNguoiLapHoaDon";
			txtNguoiLapHoaDon.Size = new Size(147, 20);
			txtNguoiLapHoaDon.TabIndex = 5;
			txtNguoiLapHoaDon.Text = "txtNguoiLapHoaDon";
			txtNguoiLapHoaDon.Click += label1_Click;
			// 
			// txtMaHoaDon
			// 
			txtMaHoaDon.AutoSize = true;
			txtMaHoaDon.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			txtMaHoaDon.Location = new Point(166, 52);
			txtMaHoaDon.Name = "txtMaHoaDon";
			txtMaHoaDon.Size = new Size(103, 20);
			txtMaHoaDon.TabIndex = 5;
			txtMaHoaDon.Text = "txtMaHoaDon";
			txtMaHoaDon.Click += label1_Click;
			// 
			// txtThoiGian
			// 
			txtThoiGian.AutoSize = true;
			txtThoiGian.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			txtThoiGian.Location = new Point(166, 84);
			txtThoiGian.Name = "txtThoiGian";
			txtThoiGian.Size = new Size(85, 20);
			txtThoiGian.TabIndex = 5;
			txtThoiGian.Text = "txtThoiGian";
			txtThoiGian.Click += label1_Click;
			// 
			// FormChiTietHoaDon
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(805, 537);
			Controls.Add(txtThoiGian);
			Controls.Add(txtMaHoaDon);
			Controls.Add(txtNguoiLapHoaDon);
			Controls.Add(txtTongTien);
			Controls.Add(label1);
			Controls.Add(lbNgay);
			Controls.Add(lbNguoiLapHoaDon);
			Controls.Add(lbMaHoaDon);
			Controls.Add(dgvSanPham);
			Controls.Add(lbDanhSachSP);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Name = "FormChiTietHoaDon";
			StartPosition = FormStartPosition.CenterScreen;
			TopMost = true;
			FormClosed += FormQuanLySanPham_FormClosed;
			Load += FormQuanLySanPham_Load;
			((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lbDanhSachSP;
		private DataGridView dgvSanPham;
		private OpenFileDialog openFileDialog1;
		private DataGridViewTextBoxColumn MaSanPham;
		private DataGridViewTextBoxColumn TenSanPham;
		private DataGridViewTextBoxColumn Size;
		private DataGridViewTextBoxColumn SoLuong;
		private DataGridViewTextBoxColumn DonGia;
		private Label lbMaHoaDon;
		private Label lbNguoiLapHoaDon;
		private Label lbNgay;
		private Label label1;
		private Label txtTongTien;
		private Label txtNguoiLapHoaDon;
		private Label txtMaHoaDon;
		private Label txtThoiGian;
	}
}