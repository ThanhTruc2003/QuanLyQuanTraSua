namespace QuanLyQuanTraSua.GUI
{
    partial class FormQuanLyNhanVien
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuanLyNhanVien));
            lbDanhSachNV = new Label();
            lbTimKiemNV = new Label();
            txbTimKiemNV = new TextBox();
            dgvNhanVien = new DataGridView();
            MaNhanVien = new DataGridViewTextBoxColumn();
            HoTen = new DataGridViewTextBoxColumn();
            NgaySinh = new DataGridViewTextBoxColumn();
            GioiTinh = new DataGridViewTextBoxColumn();
            SoDienThoai = new DataGridViewTextBoxColumn();
            ChucVu = new DataGridViewTextBoxColumn();
            lbThongTinNV = new Label();
            btThemNhanVien = new Button();
            btSuaNhanVien = new Button();
            btXoaNhanVien = new Button();
            PanelThongTinNV = new Panel();
            lbSoDienThoai = new Label();
            rbNu = new RadioButton();
            rbNam = new RadioButton();
            dtpNgaySinh = new DateTimePicker();
            txbSoDienThoai = new TextBox();
            lbGioiTinh = new Label();
            lbNgaySinh = new Label();
            cbChucVu = new ComboBox();
            lbChucVu = new Label();
            txbTenNhanVien = new TextBox();
            lbTenNhanVien = new Label();
            txbMaNhanVien = new TextBox();
            lbMaNhanVien = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            PanelThongTinNV.SuspendLayout();
            SuspendLayout();
            // 
            // lbDanhSachNV
            // 
            lbDanhSachNV.AutoSize = true;
            lbDanhSachNV.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbDanhSachNV.Location = new Point(12, 46);
            lbDanhSachNV.Name = "lbDanhSachNV";
            lbDanhSachNV.Size = new Size(226, 25);
            lbDanhSachNV.TabIndex = 1;
            lbDanhSachNV.Text = "DANH SÁCH NHÂN VIÊN";
            // 
            // lbTimKiemNV
            // 
            lbTimKiemNV.AutoSize = true;
            lbTimKiemNV.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbTimKiemNV.Location = new Point(939, 15);
            lbTimKiemNV.Name = "lbTimKiemNV";
            lbTimKiemNV.Size = new Size(169, 20);
            lbTimKiemNV.TabIndex = 2;
            lbTimKiemNV.Text = "Tìm kiếm tên nhân viên";
            // 
            // txbTimKiemNV
            // 
            txbTimKiemNV.Location = new Point(942, 44);
            txbTimKiemNV.Name = "txbTimKiemNV";
            txbTimKiemNV.Size = new Size(308, 27);
            txbTimKiemNV.TabIndex = 4;
            txbTimKiemNV.TextChanged += txbTimKiemNV_TextChanged;
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvNhanVien.ColumnHeadersHeight = 29;
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvNhanVien.Columns.AddRange(new DataGridViewColumn[] { MaNhanVien, HoTen, NgaySinh, GioiTinh, SoDienThoai, ChucVu });
            dgvNhanVien.EnableHeadersVisualStyles = false;
            dgvNhanVien.Location = new Point(12, 90);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.RowHeadersWidth = 51;
            dgvNhanVien.RowTemplate.Height = 29;
            dgvNhanVien.Size = new Size(1238, 155);
            dgvNhanVien.TabIndex = 5;
            dgvNhanVien.CellClick += dgvNhanVien_CellClick;
            // 
            // MaNhanVien
            // 
            MaNhanVien.DataPropertyName = "MaNhanVien";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            MaNhanVien.DefaultCellStyle = dataGridViewCellStyle2;
            MaNhanVien.HeaderText = "Mã nhân viên";
            MaNhanVien.MinimumWidth = 6;
            MaNhanVien.Name = "MaNhanVien";
            // 
            // HoTen
            // 
            HoTen.DataPropertyName = "HoTen";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            HoTen.DefaultCellStyle = dataGridViewCellStyle3;
            HoTen.HeaderText = "Họ tên nhân viên";
            HoTen.MinimumWidth = 6;
            HoTen.Name = "HoTen";
            // 
            // NgaySinh
            // 
            NgaySinh.DataPropertyName = "NgaySinh";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "dd/MM/yyyy";
            dataGridViewCellStyle4.NullValue = null;
            NgaySinh.DefaultCellStyle = dataGridViewCellStyle4;
            NgaySinh.HeaderText = "Ngày sinh";
            NgaySinh.MinimumWidth = 6;
            NgaySinh.Name = "NgaySinh";
            // 
            // GioiTinh
            // 
            GioiTinh.DataPropertyName = "GioiTinh";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            GioiTinh.DefaultCellStyle = dataGridViewCellStyle5;
            GioiTinh.HeaderText = "Giới tính";
            GioiTinh.MinimumWidth = 6;
            GioiTinh.Name = "GioiTinh";
            GioiTinh.Resizable = DataGridViewTriState.True;
            // 
            // SoDienThoai
            // 
            SoDienThoai.DataPropertyName = "SoDienThoai";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            SoDienThoai.DefaultCellStyle = dataGridViewCellStyle6;
            SoDienThoai.HeaderText = "Số điện thoại";
            SoDienThoai.MinimumWidth = 6;
            SoDienThoai.Name = "SoDienThoai";
            // 
            // ChucVu
            // 
            ChucVu.DataPropertyName = "TenChucVu";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ChucVu.DefaultCellStyle = dataGridViewCellStyle7;
            ChucVu.HeaderText = "Chức vụ";
            ChucVu.MinimumWidth = 6;
            ChucVu.Name = "ChucVu";
            // 
            // lbThongTinNV
            // 
            lbThongTinNV.AutoSize = true;
            lbThongTinNV.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbThongTinNV.Location = new Point(12, 286);
            lbThongTinNV.Name = "lbThongTinNV";
            lbThongTinNV.Size = new Size(221, 25);
            lbThongTinNV.TabIndex = 9;
            lbThongTinNV.Text = "THÔNG TIN NHÂN VIÊN";
            // 
            // btThemNhanVien
            // 
            btThemNhanVien.BackgroundImage = (Image)resources.GetObject("btThemNhanVien.BackgroundImage");
            btThemNhanVien.BackgroundImageLayout = ImageLayout.Stretch;
            btThemNhanVien.Cursor = Cursors.Hand;
            btThemNhanVien.FlatAppearance.BorderSize = 0;
            btThemNhanVien.FlatStyle = FlatStyle.Flat;
            btThemNhanVien.Location = new Point(1051, 265);
            btThemNhanVien.Name = "btThemNhanVien";
            btThemNhanVien.Size = new Size(49, 46);
            btThemNhanVien.TabIndex = 10;
            btThemNhanVien.UseVisualStyleBackColor = true;
            btThemNhanVien.Click += btThemNhanVien_Click;
            // 
            // btSuaNhanVien
            // 
            btSuaNhanVien.BackgroundImage = (Image)resources.GetObject("btSuaNhanVien.BackgroundImage");
            btSuaNhanVien.BackgroundImageLayout = ImageLayout.Stretch;
            btSuaNhanVien.Cursor = Cursors.Hand;
            btSuaNhanVien.FlatAppearance.BorderSize = 0;
            btSuaNhanVien.FlatStyle = FlatStyle.Flat;
            btSuaNhanVien.Location = new Point(1127, 265);
            btSuaNhanVien.Name = "btSuaNhanVien";
            btSuaNhanVien.Size = new Size(49, 46);
            btSuaNhanVien.TabIndex = 11;
            btSuaNhanVien.UseVisualStyleBackColor = true;
            btSuaNhanVien.Click += btSuaNhanVien_Click;
            // 
            // btXoaNhanVien
            // 
            btXoaNhanVien.BackgroundImage = (Image)resources.GetObject("btXoaNhanVien.BackgroundImage");
            btXoaNhanVien.BackgroundImageLayout = ImageLayout.Stretch;
            btXoaNhanVien.Cursor = Cursors.Hand;
            btXoaNhanVien.FlatAppearance.BorderSize = 0;
            btXoaNhanVien.FlatStyle = FlatStyle.Flat;
            btXoaNhanVien.Location = new Point(1201, 265);
            btXoaNhanVien.Name = "btXoaNhanVien";
            btXoaNhanVien.Size = new Size(49, 46);
            btXoaNhanVien.TabIndex = 12;
            btXoaNhanVien.UseVisualStyleBackColor = true;
            btXoaNhanVien.Click += btXoaNhanVien_Click;
            // 
            // PanelThongTinNV
            // 
            PanelThongTinNV.BackColor = Color.MistyRose;
            PanelThongTinNV.BorderStyle = BorderStyle.FixedSingle;
            PanelThongTinNV.Controls.Add(lbSoDienThoai);
            PanelThongTinNV.Controls.Add(rbNu);
            PanelThongTinNV.Controls.Add(rbNam);
            PanelThongTinNV.Controls.Add(dtpNgaySinh);
            PanelThongTinNV.Controls.Add(txbSoDienThoai);
            PanelThongTinNV.Controls.Add(lbGioiTinh);
            PanelThongTinNV.Controls.Add(lbNgaySinh);
            PanelThongTinNV.Controls.Add(cbChucVu);
            PanelThongTinNV.Controls.Add(lbChucVu);
            PanelThongTinNV.Controls.Add(txbTenNhanVien);
            PanelThongTinNV.Controls.Add(lbTenNhanVien);
            PanelThongTinNV.Controls.Add(txbMaNhanVien);
            PanelThongTinNV.Controls.Add(lbMaNhanVien);
            PanelThongTinNV.Location = new Point(12, 326);
            PanelThongTinNV.Name = "PanelThongTinNV";
            PanelThongTinNV.Size = new Size(1238, 231);
            PanelThongTinNV.TabIndex = 13;
            // 
            // lbSoDienThoai
            // 
            lbSoDienThoai.AutoSize = true;
            lbSoDienThoai.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbSoDienThoai.Location = new Point(744, 162);
            lbSoDienThoai.Name = "lbSoDienThoai";
            lbSoDienThoai.Size = new Size(115, 23);
            lbSoDienThoai.TabIndex = 22;
            lbSoDienThoai.Text = "Số điện thoại:";
            // 
            // rbNu
            // 
            rbNu.AutoSize = true;
            rbNu.Cursor = Cursors.Hand;
            rbNu.Location = new Point(954, 95);
            rbNu.Name = "rbNu";
            rbNu.Size = new Size(50, 24);
            rbNu.TabIndex = 21;
            rbNu.TabStop = true;
            rbNu.Text = "Nữ";
            rbNu.UseVisualStyleBackColor = true;
            // 
            // rbNam
            // 
            rbNam.AutoSize = true;
            rbNam.Cursor = Cursors.Hand;
            rbNam.Location = new Point(865, 95);
            rbNam.Name = "rbNam";
            rbNam.Size = new Size(62, 24);
            rbNam.TabIndex = 20;
            rbNam.TabStop = true;
            rbNam.Text = "Nam";
            rbNam.UseVisualStyleBackColor = true;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Cursor = Cursors.Hand;
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.Location = new Point(865, 24);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(312, 27);
            dtpNgaySinh.TabIndex = 19;
            // 
            // txbSoDienThoai
            // 
            txbSoDienThoai.Location = new Point(865, 157);
            txbSoDienThoai.Name = "txbSoDienThoai";
            txbSoDienThoai.Size = new Size(312, 27);
            txbSoDienThoai.TabIndex = 18;
            // 
            // lbGioiTinh
            // 
            lbGioiTinh.AutoSize = true;
            lbGioiTinh.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbGioiTinh.Location = new Point(744, 96);
            lbGioiTinh.Name = "lbGioiTinh";
            lbGioiTinh.Size = new Size(79, 23);
            lbGioiTinh.TabIndex = 16;
            lbGioiTinh.Text = "Giới tính:";
            // 
            // lbNgaySinh
            // 
            lbNgaySinh.AutoSize = true;
            lbNgaySinh.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbNgaySinh.Location = new Point(744, 30);
            lbNgaySinh.Name = "lbNgaySinh";
            lbNgaySinh.Size = new Size(91, 23);
            lbNgaySinh.TabIndex = 14;
            lbNgaySinh.Text = "Ngày sinh:";
            // 
            // cbChucVu
            // 
            cbChucVu.Cursor = Cursors.Hand;
            cbChucVu.FormattingEnabled = true;
            cbChucVu.Location = new Point(205, 157);
            cbChucVu.Name = "cbChucVu";
            cbChucVu.Size = new Size(312, 28);
            cbChucVu.TabIndex = 10;
            // 
            // lbChucVu
            // 
            lbChucVu.AutoSize = true;
            lbChucVu.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbChucVu.Location = new Point(51, 162);
            lbChucVu.Name = "lbChucVu";
            lbChucVu.Size = new Size(78, 23);
            lbChucVu.TabIndex = 13;
            lbChucVu.Text = "Chức vụ:";
            // 
            // txbTenNhanVien
            // 
            txbTenNhanVien.Location = new Point(205, 92);
            txbTenNhanVien.Name = "txbTenNhanVien";
            txbTenNhanVien.Size = new Size(312, 27);
            txbTenNhanVien.TabIndex = 12;
            // 
            // lbTenNhanVien
            // 
            lbTenNhanVien.AutoSize = true;
            lbTenNhanVien.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbTenNhanVien.Location = new Point(51, 96);
            lbTenNhanVien.Name = "lbTenNhanVien";
            lbTenNhanVien.Size = new Size(148, 23);
            lbTenNhanVien.TabIndex = 11;
            lbTenNhanVien.Text = "Họ tên nhân viên:";
            // 
            // txbMaNhanVien
            // 
            txbMaNhanVien.Location = new Point(205, 26);
            txbMaNhanVien.Name = "txbMaNhanVien";
            txbMaNhanVien.Size = new Size(312, 27);
            txbMaNhanVien.TabIndex = 10;
            // 
            // lbMaNhanVien
            // 
            lbMaNhanVien.AutoSize = true;
            lbMaNhanVien.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbMaNhanVien.Location = new Point(51, 30);
            lbMaNhanVien.Name = "lbMaNhanVien";
            lbMaNhanVien.Size = new Size(120, 23);
            lbMaNhanVien.TabIndex = 10;
            lbMaNhanVien.Text = "Mã nhân viên:";
            // 
            // FormQuanLyNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1264, 571);
            ControlBox = false;
            Controls.Add(PanelThongTinNV);
            Controls.Add(btXoaNhanVien);
            Controls.Add(btSuaNhanVien);
            Controls.Add(btThemNhanVien);
            Controls.Add(lbThongTinNV);
            Controls.Add(dgvNhanVien);
            Controls.Add(txbTimKiemNV);
            Controls.Add(lbTimKiemNV);
            Controls.Add(lbDanhSachNV);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormQuanLyNhanVien";
            WindowState = FormWindowState.Maximized;
            FormClosed += FormQuanLyNhanVien_FormClosed;
            Load += FormQuanLyNhanVien_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            PanelThongTinNV.ResumeLayout(false);
            PanelThongTinNV.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbDanhSachNV;
        private Label lbTimKiemNV;
        private TextBox txbTimKiemNV;
        private DataGridView dgvNhanVien;
        private Label lbThongTinNV;
        private Button btThemNhanVien;
        private Button btSuaNhanVien;
        private Button btXoaNhanVien;
        private Panel PanelThongTinNV;
        private TextBox txbSoDienThoai;
        private Label lbGioiTinh;
        private Label lbNgaySinh;
        private ComboBox cbChucVu;
        private Label lbChucVu;
        private TextBox txbTenNhanVien;
        private Label lbTenNhanVien;
        private TextBox txbMaNhanVien;
        private Label lbMaNhanVien;
        private Label lbSoDienThoai;
        private RadioButton rbNu;
        private RadioButton rbNam;
        private DateTimePicker dtpNgaySinh;
        private DataGridViewTextBoxColumn MaNhanVien;
        private DataGridViewTextBoxColumn HoTen;
        private DataGridViewTextBoxColumn NgaySinh;
        private DataGridViewTextBoxColumn GioiTinh;
        private DataGridViewTextBoxColumn SoDienThoai;
        private DataGridViewTextBoxColumn ChucVu;
    }
}