namespace QuanLyQuanTraSua.GUI
{
    partial class FormGoiMon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGoiMon));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            ThongTinMon = new Panel();
            btThanhToan = new Button();
            gBCapNhatMon = new GroupBox();
            btSuaMon = new Button();
            dgvCapNhatMon = new DataGridView();
            btXoaMon = new Button();
            btThemMon = new Button();
            lbTongTien = new Label();
            txbTongTien = new TextBox();
            gBThongTinMon = new GroupBox();
            txbSize = new TextBox();
            nUDSoLuong = new NumericUpDown();
            txbDonGia = new TextBox();
            txbTenMon1 = new TextBox();
            lbDonGia = new Label();
            lbSoLuong = new Label();
            lbSize = new Label();
            lbTenMon = new Label();
            lbMaSanPham = new Label();
            gbTimKiem = new GroupBox();
            txbTenMon = new TextBox();
            lbTimKiemMon = new Label();
            cbDanhMuc = new ComboBox();
            lbTimKiemTheoDanhMuc = new Label();
            Menu = new FlowLayoutPanel();
            printDocument = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog = new PrintPreviewDialog();
            MaSanPham = new DataGridViewTextBoxColumn();
            TenMon = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            DonGia = new DataGridViewTextBoxColumn();
            Size = new DataGridViewTextBoxColumn();
            ThongTinMon.SuspendLayout();
            gBCapNhatMon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCapNhatMon).BeginInit();
            gBThongTinMon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nUDSoLuong).BeginInit();
            gbTimKiem.SuspendLayout();
            SuspendLayout();
            // 
            // ThongTinMon
            // 
            ThongTinMon.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ThongTinMon.BorderStyle = BorderStyle.FixedSingle;
            ThongTinMon.Controls.Add(btThanhToan);
            ThongTinMon.Controls.Add(gBCapNhatMon);
            ThongTinMon.Controls.Add(gBThongTinMon);
            ThongTinMon.Cursor = Cursors.Hand;
            ThongTinMon.Location = new Point(796, 22);
            ThongTinMon.Name = "ThongTinMon";
            ThongTinMon.Size = new Size(517, 507);
            ThongTinMon.TabIndex = 1;
            // 
            // btThanhToan
            // 
            btThanhToan.BackColor = Color.MistyRose;
            btThanhToan.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            btThanhToan.FlatAppearance.MouseOverBackColor = Color.LightPink;
            btThanhToan.FlatStyle = FlatStyle.Flat;
            btThanhToan.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btThanhToan.Location = new Point(133, 452);
            btThanhToan.Name = "btThanhToan";
            btThanhToan.Size = new Size(231, 44);
            btThanhToan.TabIndex = 11;
            btThanhToan.Text = "Thanh toán";
            btThanhToan.UseVisualStyleBackColor = false;
            btThanhToan.Click += btThanhToan_Click;
            // 
            // gBCapNhatMon
            // 
            gBCapNhatMon.Controls.Add(btSuaMon);
            gBCapNhatMon.Controls.Add(dgvCapNhatMon);
            gBCapNhatMon.Controls.Add(btXoaMon);
            gBCapNhatMon.Controls.Add(btThemMon);
            gBCapNhatMon.Controls.Add(lbTongTien);
            gBCapNhatMon.Controls.Add(txbTongTien);
            gBCapNhatMon.Location = new Point(3, 134);
            gBCapNhatMon.Name = "gBCapNhatMon";
            gBCapNhatMon.Size = new Size(464, 308);
            gBCapNhatMon.TabIndex = 1;
            gBCapNhatMon.TabStop = false;
            gBCapNhatMon.Text = "Cập nhật món";
            // 
            // btSuaMon
            // 
            btSuaMon.BackgroundImage = (Image)resources.GetObject("btSuaMon.BackgroundImage");
            btSuaMon.BackgroundImageLayout = ImageLayout.Stretch;
            btSuaMon.Cursor = Cursors.Hand;
            btSuaMon.FlatAppearance.BorderSize = 0;
            btSuaMon.FlatStyle = FlatStyle.Flat;
            btSuaMon.Location = new Point(338, 22);
            btSuaMon.Name = "btSuaMon";
            btSuaMon.Size = new Size(49, 46);
            btSuaMon.TabIndex = 14;
            btSuaMon.UseVisualStyleBackColor = true;
            btSuaMon.Click += btSuaMon_Click;
            // 
            // dgvCapNhatMon
            // 
            dgvCapNhatMon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCapNhatMon.BackgroundColor = Color.Snow;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCapNhatMon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCapNhatMon.ColumnHeadersHeight = 29;
            dgvCapNhatMon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCapNhatMon.Columns.AddRange(new DataGridViewColumn[] { MaSanPham, TenMon, SoLuong, DonGia, Size });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvCapNhatMon.DefaultCellStyle = dataGridViewCellStyle6;
            dgvCapNhatMon.EnableHeadersVisualStyles = false;
            dgvCapNhatMon.Location = new Point(6, 76);
            dgvCapNhatMon.Name = "dgvCapNhatMon";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvCapNhatMon.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvCapNhatMon.RowHeadersWidth = 51;
            dgvCapNhatMon.RowTemplate.Height = 29;
            dgvCapNhatMon.Size = new Size(452, 183);
            dgvCapNhatMon.TabIndex = 13;
            dgvCapNhatMon.CellClick += dgvCapNhatMon_CellClick;
            // 
            // btXoaMon
            // 
            btXoaMon.BackgroundImage = (Image)resources.GetObject("btXoaMon.BackgroundImage");
            btXoaMon.BackgroundImageLayout = ImageLayout.Stretch;
            btXoaMon.Cursor = Cursors.Hand;
            btXoaMon.FlatAppearance.BorderSize = 0;
            btXoaMon.FlatStyle = FlatStyle.Flat;
            btXoaMon.Location = new Point(409, 22);
            btXoaMon.Name = "btXoaMon";
            btXoaMon.Size = new Size(49, 46);
            btXoaMon.TabIndex = 12;
            btXoaMon.UseVisualStyleBackColor = true;
            btXoaMon.Click += btXoaMon_Click;
            // 
            // btThemMon
            // 
            btThemMon.BackgroundImage = (Image)resources.GetObject("btThemMon.BackgroundImage");
            btThemMon.BackgroundImageLayout = ImageLayout.Stretch;
            btThemMon.Cursor = Cursors.Hand;
            btThemMon.FlatAppearance.BorderSize = 0;
            btThemMon.FlatStyle = FlatStyle.Flat;
            btThemMon.Location = new Point(263, 22);
            btThemMon.Name = "btThemMon";
            btThemMon.Size = new Size(49, 46);
            btThemMon.TabIndex = 11;
            btThemMon.UseVisualStyleBackColor = true;
            btThemMon.Click += btThemMon_Click;
            // 
            // lbTongTien
            // 
            lbTongTien.AutoSize = true;
            lbTongTien.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbTongTien.Location = new Point(68, 274);
            lbTongTien.Name = "lbTongTien";
            lbTongTien.Size = new Size(92, 23);
            lbTongTien.TabIndex = 10;
            lbTongTien.Text = "Tổng tiền:";
            // 
            // txbTongTien
            // 
            txbTongTien.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txbTongTien.ForeColor = SystemColors.ControlText;
            txbTongTien.Location = new Point(165, 269);
            txbTongTien.Name = "txbTongTien";
            txbTongTien.ReadOnly = true;
            txbTongTien.Size = new Size(225, 30);
            txbTongTien.TabIndex = 10;
            txbTongTien.TextAlign = HorizontalAlignment.Center;
            // 
            // gBThongTinMon
            // 
            gBThongTinMon.Controls.Add(txbSize);
            gBThongTinMon.Controls.Add(nUDSoLuong);
            gBThongTinMon.Controls.Add(txbDonGia);
            gBThongTinMon.Controls.Add(txbTenMon1);
            gBThongTinMon.Controls.Add(lbDonGia);
            gBThongTinMon.Controls.Add(lbSoLuong);
            gBThongTinMon.Controls.Add(lbSize);
            gBThongTinMon.Controls.Add(lbTenMon);
            gBThongTinMon.Controls.Add(lbMaSanPham);
            gBThongTinMon.Location = new Point(3, 3);
            gBThongTinMon.Name = "gBThongTinMon";
            gBThongTinMon.Size = new Size(464, 125);
            gBThongTinMon.TabIndex = 0;
            gBThongTinMon.TabStop = false;
            gBThongTinMon.Text = "Thông tin món";
            // 
            // txbSize
            // 
            txbSize.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txbSize.ForeColor = SystemColors.ControlText;
            txbSize.Location = new Point(318, 80);
            txbSize.Name = "txbSize";
            txbSize.ReadOnly = true;
            txbSize.Size = new Size(133, 27);
            txbSize.TabIndex = 10;
            // 
            // nUDSoLuong
            // 
            nUDSoLuong.BorderStyle = BorderStyle.FixedSingle;
            nUDSoLuong.Cursor = Cursors.Hand;
            nUDSoLuong.Location = new Point(318, 31);
            nUDSoLuong.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nUDSoLuong.Name = "nUDSoLuong";
            nUDSoLuong.Size = new Size(133, 27);
            nUDSoLuong.TabIndex = 9;
            nUDSoLuong.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txbDonGia
            // 
            txbDonGia.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txbDonGia.ForeColor = SystemColors.ControlText;
            txbDonGia.Location = new Point(81, 76);
            txbDonGia.Name = "txbDonGia";
            txbDonGia.ReadOnly = true;
            txbDonGia.Size = new Size(140, 27);
            txbDonGia.TabIndex = 8;
            // 
            // txbTenMon1
            // 
            txbTenMon1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txbTenMon1.ForeColor = SystemColors.ControlText;
            txbTenMon1.Location = new Point(81, 31);
            txbTenMon1.Name = "txbTenMon1";
            txbTenMon1.ReadOnly = true;
            txbTenMon1.Size = new Size(140, 27);
            txbTenMon1.TabIndex = 4;
            // 
            // lbDonGia
            // 
            lbDonGia.AutoSize = true;
            lbDonGia.Location = new Point(8, 83);
            lbDonGia.Name = "lbDonGia";
            lbDonGia.Size = new Size(65, 20);
            lbDonGia.TabIndex = 7;
            lbDonGia.Text = "Đơn giá:";
            // 
            // lbSoLuong
            // 
            lbSoLuong.AutoSize = true;
            lbSoLuong.Location = new Point(240, 38);
            lbSoLuong.Name = "lbSoLuong";
            lbSoLuong.Size = new Size(72, 20);
            lbSoLuong.TabIndex = 6;
            lbSoLuong.Text = "Số lượng:";
            // 
            // lbSize
            // 
            lbSize.AutoSize = true;
            lbSize.Location = new Point(240, 83);
            lbSize.Name = "lbSize";
            lbSize.Size = new Size(39, 20);
            lbSize.TabIndex = 5;
            lbSize.Text = "Size:";
            // 
            // lbTenMon
            // 
            lbTenMon.AutoSize = true;
            lbTenMon.Location = new Point(6, 38);
            lbTenMon.Name = "lbTenMon";
            lbTenMon.Size = new Size(69, 20);
            lbTenMon.TabIndex = 4;
            lbTenMon.Text = "Tên món:";
            // 
            // lbMaSanPham
            // 
            lbMaSanPham.AutoSize = true;
            lbMaSanPham.Location = new Point(121, 33);
            lbMaSanPham.Name = "lbMaSanPham";
            lbMaSanPham.Size = new Size(50, 20);
            lbMaSanPham.TabIndex = 11;
            lbMaSanPham.Text = "label1";
            lbMaSanPham.Visible = false;
            // 
            // gbTimKiem
            // 
            gbTimKiem.Controls.Add(txbTenMon);
            gbTimKiem.Controls.Add(lbTimKiemMon);
            gbTimKiem.Controls.Add(cbDanhMuc);
            gbTimKiem.Controls.Add(lbTimKiemTheoDanhMuc);
            gbTimKiem.Location = new Point(2, 12);
            gbTimKiem.Name = "gbTimKiem";
            gbTimKiem.Size = new Size(776, 78);
            gbTimKiem.TabIndex = 1;
            gbTimKiem.TabStop = false;
            gbTimKiem.Text = "Tìm kiếm";
            // 
            // txbTenMon
            // 
            txbTenMon.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txbTenMon.ForeColor = SystemColors.ControlText;
            txbTenMon.Location = new Point(525, 37);
            txbTenMon.Name = "txbTenMon";
            txbTenMon.Size = new Size(235, 27);
            txbTenMon.TabIndex = 3;
            txbTenMon.TextChanged += txbTenMon_TextChanged;
            // 
            // lbTimKiemMon
            // 
            lbTimKiemMon.AutoSize = true;
            lbTimKiemMon.Location = new Point(412, 39);
            lbTimKiemMon.Name = "lbTimKiemMon";
            lbTimKiemMon.Size = new Size(107, 20);
            lbTimKiemMon.TabIndex = 2;
            lbTimKiemMon.Text = "Tìm kiếm món:";
            // 
            // cbDanhMuc
            // 
            cbDanhMuc.Cursor = Cursors.Hand;
            cbDanhMuc.FormattingEnabled = true;
            cbDanhMuc.Items.AddRange(new object[] { "Tất cả" });
            cbDanhMuc.Location = new Point(188, 37);
            cbDanhMuc.Name = "cbDanhMuc";
            cbDanhMuc.Size = new Size(183, 28);
            cbDanhMuc.TabIndex = 1;
            cbDanhMuc.SelectedIndexChanged += cbDanhMuc_SelectedIndexChanged;
            // 
            // lbTimKiemTheoDanhMuc
            // 
            lbTimKiemTheoDanhMuc.AutoSize = true;
            lbTimKiemTheoDanhMuc.Location = new Point(6, 39);
            lbTimKiemTheoDanhMuc.Name = "lbTimKiemTheoDanhMuc";
            lbTimKiemTheoDanhMuc.Size = new Size(176, 20);
            lbTimKiemTheoDanhMuc.TabIndex = 0;
            lbTimKiemTheoDanhMuc.Text = "Tìm kiếm theo danh mục:\r\n";
            // 
            // Menu
            // 
            Menu.AutoScroll = true;
            Menu.BorderStyle = BorderStyle.Fixed3D;
            Menu.Location = new Point(2, 131);
            Menu.Name = "Menu";
            Menu.Size = new Size(776, 400);
            Menu.TabIndex = 2;
            // 
            // printDocument
            // 
            printDocument.PrintPage += printDocument_PrintPage;
            // 
            // printPreviewDialog
            // 
            printPreviewDialog.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog.ClientSize = new Size(400, 300);
            printPreviewDialog.Enabled = true;
            printPreviewDialog.Icon = (Icon)resources.GetObject("printPreviewDialog.Icon");
            printPreviewDialog.Name = "printPreviewDialog";
            printPreviewDialog.Visible = false;
            // 
            // MaSanPham
            // 
            MaSanPham.DataPropertyName = "MaSanPham";
            MaSanPham.HeaderText = "Mã SP";
            MaSanPham.MinimumWidth = 6;
            MaSanPham.Name = "MaSanPham";
            MaSanPham.Visible = false;
            // 
            // TenMon
            // 
            TenMon.DataPropertyName = "TenSanPham";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TenMon.DefaultCellStyle = dataGridViewCellStyle2;
            TenMon.HeaderText = "Tên món";
            TenMon.MinimumWidth = 6;
            TenMon.Name = "TenMon";
            // 
            // SoLuong
            // 
            SoLuong.DataPropertyName = "SoLuong";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            SoLuong.DefaultCellStyle = dataGridViewCellStyle3;
            SoLuong.HeaderText = "Số lượng";
            SoLuong.MinimumWidth = 6;
            SoLuong.Name = "SoLuong";
            // 
            // DonGia
            // 
            DonGia.DataPropertyName = "DonGia";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DonGia.DefaultCellStyle = dataGridViewCellStyle4;
            DonGia.HeaderText = "Đơn giá";
            DonGia.MinimumWidth = 6;
            DonGia.Name = "DonGia";
            // 
            // Size
            // 
            Size.DataPropertyName = "Size";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Size.DefaultCellStyle = dataGridViewCellStyle5;
            Size.HeaderText = "Size";
            Size.MinimumWidth = 6;
            Size.Name = "Size";
            // 
            // FormGoiMon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(1318, 578);
            ControlBox = false;
            Controls.Add(Menu);
            Controls.Add(gbTimKiem);
            Controls.Add(ThongTinMon);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormGoiMon";
            WindowState = FormWindowState.Maximized;
            Load += FormGoiMon_Load;
            ThongTinMon.ResumeLayout(false);
            gBCapNhatMon.ResumeLayout(false);
            gBCapNhatMon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCapNhatMon).EndInit();
            gBThongTinMon.ResumeLayout(false);
            gBThongTinMon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nUDSoLuong).EndInit();
            gbTimKiem.ResumeLayout(false);
            gbTimKiem.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel ThongTinMon;
        private GroupBox gbTimKiem;
        private ComboBox cbDanhMuc;
        private Label lbTimKiemTheoDanhMuc;
        private TextBox txbTenMon;
        private Label lbTimKiemMon;
        private FlowLayoutPanel Menu;
        private GroupBox gBThongTinMon;
        private TextBox txbDonGia;
        private TextBox txbTenMon1;
        private Label lbDonGia;
        private Label lbSoLuong;
        private Label lbSize;
        private Label lbTenMon;
        private NumericUpDown nUDSoLuong;
        private Button btThanhToan;
        private TextBox txbTongTien;
        private GroupBox gBCapNhatMon;
        private Label lbTongTien;
        private Button btThemMon;
        private Button btXoaMon;
        private DataGridView dgvCapNhatMon;
        private TextBox txbSize;
        private Button btSuaMon;
        private Label lbMaSanPham;
        private System.Drawing.Printing.PrintDocument printDocument;
        private PrintPreviewDialog printPreviewDialog;
        private DataGridViewTextBoxColumn MaSanPham;
        private DataGridViewTextBoxColumn TenMon;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewTextBoxColumn Size;
    }
}