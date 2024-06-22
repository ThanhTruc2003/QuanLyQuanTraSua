namespace QuanLyQuanTraSua.GUI
{
    partial class FormQuanLySanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuanLySanPham));
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            lbDanhSachSP = new Label();
            lbTimKiemSP = new Label();
            cbDanhMucSP = new ComboBox();
            txbTimKiemSP = new TextBox();
            dgvSanPham = new DataGridView();
            btThemSanPham = new Button();
            btSuaSanPham = new Button();
            btXoaSanPham = new Button();
            lbThongTinSP = new Label();
            PanelThongTinSP = new Panel();
            txbDonGia = new TextBox();
            txbSize = new TextBox();
            lbDonGia = new Label();
            lbSize = new Label();
            cbLoaiSanPham = new ComboBox();
            lbLoaiSanPham = new Label();
            txbTenSanPham = new TextBox();
            lbTenSanPham = new Label();
            txbMaSanPham = new TextBox();
            lbMaSanPham = new Label();
            btTaiHinhAnh = new Button();
            pBHinhAnh = new PictureBox();
            txbImage = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            MaSanPham = new DataGridViewTextBoxColumn();
            TenSanPham = new DataGridViewTextBoxColumn();
            Size = new DataGridViewTextBoxColumn();
            DonGia = new DataGridViewTextBoxColumn();
            LoaiSanPham = new DataGridViewTextBoxColumn();
            HinhAnh = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
            PanelThongTinSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pBHinhAnh).BeginInit();
            SuspendLayout();
            // 
            // lbDanhSachSP
            // 
            lbDanhSachSP.AutoSize = true;
            lbDanhSachSP.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbDanhSachSP.Location = new Point(12, 46);
            lbDanhSachSP.Name = "lbDanhSachSP";
            lbDanhSachSP.Size = new Size(221, 25);
            lbDanhSachSP.TabIndex = 0;
            lbDanhSachSP.Text = "DANH SÁCH SẢN PHẨM";
            // 
            // lbTimKiemSP
            // 
            lbTimKiemSP.AutoSize = true;
            lbTimKiemSP.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbTimKiemSP.Location = new Point(844, 15);
            lbTimKiemSP.Name = "lbTimKiemSP";
            lbTimKiemSP.Size = new Size(178, 20);
            lbTimKiemSP.TabIndex = 1;
            lbTimKiemSP.Text = "Tìm kiếm theo danh mục";
            // 
            // cbDanhMucSP
            // 
            cbDanhMucSP.Cursor = Cursors.Hand;
            cbDanhMucSP.FormattingEnabled = true;
            cbDanhMucSP.Location = new Point(848, 43);
            cbDanhMucSP.Name = "cbDanhMucSP";
            cbDanhMucSP.Size = new Size(174, 28);
            cbDanhMucSP.TabIndex = 2;
            cbDanhMucSP.SelectedIndexChanged += cbDanhMucSP_SelectedIndexChanged;
            // 
            // txbTimKiemSP
            // 
            txbTimKiemSP.Location = new Point(1051, 44);
            txbTimKiemSP.Name = "txbTimKiemSP";
            txbTimKiemSP.Size = new Size(199, 27);
            txbTimKiemSP.TabIndex = 3;
            txbTimKiemSP.TextChanged += txbTimKiemSP_TextChanged;
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
            dgvSanPham.Columns.AddRange(new DataGridViewColumn[] { MaSanPham, TenSanPham, Size, DonGia, LoaiSanPham, HinhAnh });
            dgvSanPham.EnableHeadersVisualStyles = false;
            dgvSanPham.Location = new Point(12, 90);
            dgvSanPham.Name = "dgvSanPham";
            dgvSanPham.RowHeadersWidth = 51;
            dgvSanPham.RowTemplate.Height = 60;
            dgvSanPham.Size = new Size(1238, 155);
            dgvSanPham.TabIndex = 4;
            dgvSanPham.CellClick += dgvSanPham_CellClick;
            // 
            // btThemSanPham
            // 
            btThemSanPham.BackgroundImage = (Image)resources.GetObject("btThemSanPham.BackgroundImage");
            btThemSanPham.BackgroundImageLayout = ImageLayout.Stretch;
            btThemSanPham.Cursor = Cursors.Hand;
            btThemSanPham.FlatAppearance.BorderSize = 0;
            btThemSanPham.FlatStyle = FlatStyle.Flat;
            btThemSanPham.Location = new Point(1051, 265);
            btThemSanPham.Name = "btThemSanPham";
            btThemSanPham.Size = new Size(49, 46);
            btThemSanPham.TabIndex = 5;
            btThemSanPham.UseVisualStyleBackColor = true;
            btThemSanPham.Click += btThemSanPham_Click;
            // 
            // btSuaSanPham
            // 
            btSuaSanPham.BackgroundImage = (Image)resources.GetObject("btSuaSanPham.BackgroundImage");
            btSuaSanPham.BackgroundImageLayout = ImageLayout.Stretch;
            btSuaSanPham.Cursor = Cursors.Hand;
            btSuaSanPham.FlatAppearance.BorderSize = 0;
            btSuaSanPham.FlatStyle = FlatStyle.Flat;
            btSuaSanPham.Location = new Point(1127, 265);
            btSuaSanPham.Name = "btSuaSanPham";
            btSuaSanPham.Size = new Size(49, 46);
            btSuaSanPham.TabIndex = 6;
            btSuaSanPham.UseVisualStyleBackColor = true;
            btSuaSanPham.Click += btSuaSanPham_Click;
            // 
            // btXoaSanPham
            // 
            btXoaSanPham.BackgroundImage = (Image)resources.GetObject("btXoaSanPham.BackgroundImage");
            btXoaSanPham.BackgroundImageLayout = ImageLayout.Stretch;
            btXoaSanPham.Cursor = Cursors.Hand;
            btXoaSanPham.FlatAppearance.BorderSize = 0;
            btXoaSanPham.FlatStyle = FlatStyle.Flat;
            btXoaSanPham.Location = new Point(1201, 265);
            btXoaSanPham.Name = "btXoaSanPham";
            btXoaSanPham.Size = new Size(49, 46);
            btXoaSanPham.TabIndex = 7;
            btXoaSanPham.UseVisualStyleBackColor = true;
            btXoaSanPham.Click += btXoaSanPham_Click;
            // 
            // lbThongTinSP
            // 
            lbThongTinSP.AutoSize = true;
            lbThongTinSP.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbThongTinSP.Location = new Point(12, 286);
            lbThongTinSP.Name = "lbThongTinSP";
            lbThongTinSP.Size = new Size(216, 25);
            lbThongTinSP.TabIndex = 8;
            lbThongTinSP.Text = "THÔNG TIN SẢN PHẨM";
            // 
            // PanelThongTinSP
            // 
            PanelThongTinSP.BackColor = Color.MistyRose;
            PanelThongTinSP.BorderStyle = BorderStyle.FixedSingle;
            PanelThongTinSP.Controls.Add(txbDonGia);
            PanelThongTinSP.Controls.Add(txbSize);
            PanelThongTinSP.Controls.Add(lbDonGia);
            PanelThongTinSP.Controls.Add(lbSize);
            PanelThongTinSP.Controls.Add(cbLoaiSanPham);
            PanelThongTinSP.Controls.Add(lbLoaiSanPham);
            PanelThongTinSP.Controls.Add(txbTenSanPham);
            PanelThongTinSP.Controls.Add(lbTenSanPham);
            PanelThongTinSP.Controls.Add(txbMaSanPham);
            PanelThongTinSP.Controls.Add(lbMaSanPham);
            PanelThongTinSP.Controls.Add(btTaiHinhAnh);
            PanelThongTinSP.Controls.Add(pBHinhAnh);
            PanelThongTinSP.Controls.Add(txbImage);
            PanelThongTinSP.Location = new Point(12, 326);
            PanelThongTinSP.Name = "PanelThongTinSP";
            PanelThongTinSP.Size = new Size(1238, 231);
            PanelThongTinSP.TabIndex = 9;
            // 
            // txbDonGia
            // 
            txbDonGia.Location = new Point(852, 125);
            txbDonGia.Name = "txbDonGia";
            txbDonGia.Size = new Size(312, 27);
            txbDonGia.TabIndex = 18;
            // 
            // txbSize
            // 
            txbSize.Location = new Point(852, 60);
            txbSize.Name = "txbSize";
            txbSize.Size = new Size(312, 27);
            txbSize.TabIndex = 17;
            // 
            // lbDonGia
            // 
            lbDonGia.AutoSize = true;
            lbDonGia.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbDonGia.Location = new Point(772, 129);
            lbDonGia.Name = "lbDonGia";
            lbDonGia.Size = new Size(74, 23);
            lbDonGia.TabIndex = 16;
            lbDonGia.Text = "Đơn giá:";
            // 
            // lbSize
            // 
            lbSize.AutoSize = true;
            lbSize.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbSize.Location = new Point(772, 64);
            lbSize.Name = "lbSize";
            lbSize.Size = new Size(44, 23);
            lbSize.TabIndex = 14;
            lbSize.Text = "Size:";
            // 
            // cbLoaiSanPham
            // 
            cbLoaiSanPham.Cursor = Cursors.Hand;
            cbLoaiSanPham.FormattingEnabled = true;
            cbLoaiSanPham.Location = new Point(370, 157);
            cbLoaiSanPham.Name = "cbLoaiSanPham";
            cbLoaiSanPham.Size = new Size(312, 28);
            cbLoaiSanPham.TabIndex = 10;
            // 
            // lbLoaiSanPham
            // 
            lbLoaiSanPham.AutoSize = true;
            lbLoaiSanPham.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbLoaiSanPham.Location = new Point(244, 162);
            lbLoaiSanPham.Name = "lbLoaiSanPham";
            lbLoaiSanPham.Size = new Size(125, 23);
            lbLoaiSanPham.TabIndex = 13;
            lbLoaiSanPham.Text = "Loại sản phẩm:";
            // 
            // txbTenSanPham
            // 
            txbTenSanPham.Location = new Point(370, 92);
            txbTenSanPham.Name = "txbTenSanPham";
            txbTenSanPham.Size = new Size(312, 27);
            txbTenSanPham.TabIndex = 12;
            // 
            // lbTenSanPham
            // 
            lbTenSanPham.AutoSize = true;
            lbTenSanPham.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbTenSanPham.Location = new Point(245, 96);
            lbTenSanPham.Name = "lbTenSanPham";
            lbTenSanPham.Size = new Size(120, 23);
            lbTenSanPham.TabIndex = 11;
            lbTenSanPham.Text = "Tên sản phẩm:";
            // 
            // txbMaSanPham
            // 
            txbMaSanPham.Location = new Point(370, 29);
            txbMaSanPham.Name = "txbMaSanPham";
            txbMaSanPham.Size = new Size(312, 27);
            txbMaSanPham.TabIndex = 10;
            // 
            // lbMaSanPham
            // 
            lbMaSanPham.AutoSize = true;
            lbMaSanPham.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbMaSanPham.Location = new Point(245, 33);
            lbMaSanPham.Name = "lbMaSanPham";
            lbMaSanPham.Size = new Size(119, 23);
            lbMaSanPham.TabIndex = 10;
            lbMaSanPham.Text = "Mã sản phẩm:";
            // 
            // btTaiHinhAnh
            // 
            btTaiHinhAnh.BackColor = Color.FromArgb(255, 192, 192);
            btTaiHinhAnh.Cursor = Cursors.Hand;
            btTaiHinhAnh.FlatStyle = FlatStyle.Flat;
            btTaiHinhAnh.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btTaiHinhAnh.ForeColor = Color.Black;
            btTaiHinhAnh.Location = new Point(48, 183);
            btTaiHinhAnh.Name = "btTaiHinhAnh";
            btTaiHinhAnh.Size = new Size(117, 38);
            btTaiHinhAnh.TabIndex = 1;
            btTaiHinhAnh.Text = "Tải hình ảnh";
            btTaiHinhAnh.UseVisualStyleBackColor = false;
            btTaiHinhAnh.Click += btTaiHinhAnh_Click;
            // 
            // pBHinhAnh
            // 
            pBHinhAnh.BackColor = Color.White;
            pBHinhAnh.Location = new Point(15, 13);
            pBHinhAnh.Name = "pBHinhAnh";
            pBHinhAnh.Size = new Size(189, 164);
            pBHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            pBHinhAnh.TabIndex = 0;
            pBHinhAnh.TabStop = false;
            // 
            // txbImage
            // 
            txbImage.Location = new Point(15, 13);
            txbImage.Name = "txbImage";
            txbImage.Size = new Size(189, 27);
            txbImage.TabIndex = 19;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
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
            // DonGia
            // 
            DonGia.DataPropertyName = "DonGia";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DonGia.DefaultCellStyle = dataGridViewCellStyle5;
            DonGia.HeaderText = "Đơn giá (đồng)";
            DonGia.MinimumWidth = 6;
            DonGia.Name = "DonGia";
            // 
            // LoaiSanPham
            // 
            LoaiSanPham.DataPropertyName = "LoaiSanPham";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            LoaiSanPham.DefaultCellStyle = dataGridViewCellStyle6;
            LoaiSanPham.HeaderText = "Loại sản phẩm";
            LoaiSanPham.MinimumWidth = 6;
            LoaiSanPham.Name = "LoaiSanPham";
            // 
            // HinhAnh
            // 
            HinhAnh.DataPropertyName = "Image";
            HinhAnh.HeaderText = "Hình ảnh";
            HinhAnh.ImageLayout = DataGridViewImageCellLayout.Zoom;
            HinhAnh.MinimumWidth = 6;
            HinhAnh.Name = "HinhAnh";
            HinhAnh.Resizable = DataGridViewTriState.True;
            HinhAnh.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // FormQuanLySanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1265, 569);
            ControlBox = false;
            Controls.Add(PanelThongTinSP);
            Controls.Add(lbThongTinSP);
            Controls.Add(btXoaSanPham);
            Controls.Add(btSuaSanPham);
            Controls.Add(btThemSanPham);
            Controls.Add(dgvSanPham);
            Controls.Add(txbTimKiemSP);
            Controls.Add(cbDanhMucSP);
            Controls.Add(lbTimKiemSP);
            Controls.Add(lbDanhSachSP);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormQuanLySanPham";
            WindowState = FormWindowState.Maximized;
            FormClosed += FormQuanLySanPham_FormClosed;
            Load += FormQuanLySanPham_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
            PanelThongTinSP.ResumeLayout(false);
            PanelThongTinSP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pBHinhAnh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbDanhSachSP;
        private Label lbTimKiemSP;
        private ComboBox cbDanhMucSP;
        private TextBox txbTimKiemSP;
        private DataGridView dgvSanPham;
        private Button btThemSanPham;
        private Button btSuaSanPham;
        private Button btXoaSanPham;
        private Label lbThongTinSP;
        private Panel PanelThongTinSP;
        private PictureBox pBHinhAnh;
        private Button btTaiHinhAnh;
        private TextBox txbMaSanPham;
        private Label lbMaSanPham;
        private TextBox txbDonGia;
        private TextBox txbSize;
        private Label lbDonGia;
        private Label lbSize;
        private ComboBox cbLoaiSanPham;
        private Label lbLoaiSanPham;
        private TextBox txbTenSanPham;
        private Label lbTenSanPham;
        private OpenFileDialog openFileDialog1;
        private TextBox txbImage;
        private DataGridViewTextBoxColumn MaSanPham;
        private DataGridViewTextBoxColumn TenSanPham;
        private DataGridViewTextBoxColumn Size;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewTextBoxColumn LoaiSanPham;
        private DataGridViewImageColumn HinhAnh;
    }
}