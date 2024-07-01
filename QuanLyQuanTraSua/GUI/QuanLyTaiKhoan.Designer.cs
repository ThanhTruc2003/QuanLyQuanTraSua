namespace QuanLyQuanTraSua.GUI
{
    partial class FormQuanLyTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuanLyTaiKhoan));
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            lbDanhSachNV = new Label();
            dgvTaiKhoan = new DataGridView();
            lbThongTinTK = new Label();
            PanelThongTinTK = new Panel();
            cbMaNhanVien = new ComboBox();
            lbMaNhanVien = new Label();
            txbTaiKhoan = new TextBox();
            lbMatKhau = new Label();
            txbMatKhau = new TextBox();
            lbTaiKhoan = new Label();
            cbLoaiTaiKhoan = new ComboBox();
            lbLoaiTaiKhoan = new Label();
            txbMaTaiKhoan = new TextBox();
            lbMaTaiKhoan = new Label();
            btThemTaiKhoan = new Button();
            btSuaTaiKhoan = new Button();
            btXoaTaiKhoan = new Button();
            lbTimKiemTK = new Label();
            cbLoaiTK = new ComboBox();
            MaTaiKhoan = new DataGridViewTextBoxColumn();
            Username = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            LoaiTaiKhoan = new DataGridViewTextBoxColumn();
            MaNhanVien = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvTaiKhoan).BeginInit();
            PanelThongTinTK.SuspendLayout();
            SuspendLayout();
            // 
            // lbDanhSachNV
            // 
            lbDanhSachNV.AutoSize = true;
            lbDanhSachNV.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbDanhSachNV.Location = new Point(12, 46);
            lbDanhSachNV.Name = "lbDanhSachNV";
            lbDanhSachNV.Size = new Size(225, 25);
            lbDanhSachNV.TabIndex = 2;
            lbDanhSachNV.Text = "DANH SÁCH TÀI KHOẢN";
            // 
            // dgvTaiKhoan
            // 
            dgvTaiKhoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTaiKhoan.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvTaiKhoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvTaiKhoan.ColumnHeadersHeight = 29;
            dgvTaiKhoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvTaiKhoan.Columns.AddRange(new DataGridViewColumn[] { MaTaiKhoan, Username, Password, LoaiTaiKhoan, MaNhanVien });
            dgvTaiKhoan.EnableHeadersVisualStyles = false;
            dgvTaiKhoan.Location = new Point(12, 90);
            dgvTaiKhoan.Name = "dgvTaiKhoan";
            dgvTaiKhoan.RowHeadersWidth = 51;
            dgvTaiKhoan.RowTemplate.Height = 29;
            dgvTaiKhoan.Size = new Size(1238, 155);
            dgvTaiKhoan.TabIndex = 6;
            dgvTaiKhoan.CellClick += dgvTaiKhoan_CellClick;
            // 
            // lbThongTinTK
            // 
            lbThongTinTK.AutoSize = true;
            lbThongTinTK.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbThongTinTK.Location = new Point(12, 286);
            lbThongTinTK.Name = "lbThongTinTK";
            lbThongTinTK.Size = new Size(220, 25);
            lbThongTinTK.TabIndex = 10;
            lbThongTinTK.Text = "THÔNG TIN TÀI KHOẢN";
            // 
            // PanelThongTinTK
            // 
            PanelThongTinTK.BackColor = Color.MistyRose;
            PanelThongTinTK.BorderStyle = BorderStyle.FixedSingle;
            PanelThongTinTK.Controls.Add(cbMaNhanVien);
            PanelThongTinTK.Controls.Add(lbMaNhanVien);
            PanelThongTinTK.Controls.Add(txbTaiKhoan);
            PanelThongTinTK.Controls.Add(lbMatKhau);
            PanelThongTinTK.Controls.Add(txbMatKhau);
            PanelThongTinTK.Controls.Add(lbTaiKhoan);
            PanelThongTinTK.Controls.Add(cbLoaiTaiKhoan);
            PanelThongTinTK.Controls.Add(lbLoaiTaiKhoan);
            PanelThongTinTK.Controls.Add(txbMaTaiKhoan);
            PanelThongTinTK.Controls.Add(lbMaTaiKhoan);
            PanelThongTinTK.Location = new Point(12, 326);
            PanelThongTinTK.Name = "PanelThongTinTK";
            PanelThongTinTK.Size = new Size(1238, 231);
            PanelThongTinTK.TabIndex = 14;
            // 
            // cbMaNhanVien
            // 
            cbMaNhanVien.Cursor = Cursors.Hand;
            cbMaNhanVien.FormattingEnabled = true;
            cbMaNhanVien.Location = new Point(177, 167);
            cbMaNhanVien.Name = "cbMaNhanVien";
            cbMaNhanVien.Size = new Size(312, 28);
            cbMaNhanVien.TabIndex = 25;
            // 
            // lbMaNhanVien
            // 
            lbMaNhanVien.AutoSize = true;
            lbMaNhanVien.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbMaNhanVien.Location = new Point(51, 172);
            lbMaNhanVien.Name = "lbMaNhanVien";
            lbMaNhanVien.Size = new Size(93, 23);
            lbMaNhanVien.TabIndex = 24;
            lbMaNhanVien.Text = "Nhân viên:";
            // 
            // txbTaiKhoan
            // 
            txbTaiKhoan.Location = new Point(847, 83);
            txbTaiKhoan.Name = "txbTaiKhoan";
            txbTaiKhoan.Size = new Size(312, 27);
            txbTaiKhoan.TabIndex = 23;
            // 
            // lbMatKhau
            // 
            lbMatKhau.AutoSize = true;
            lbMatKhau.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbMatKhau.Location = new Point(754, 142);
            lbMatKhau.Name = "lbMatKhau";
            lbMatKhau.Size = new Size(88, 23);
            lbMatKhau.TabIndex = 22;
            lbMatKhau.Text = "Mật khẩu:";
            // 
            // txbMatKhau
            // 
            txbMatKhau.Location = new Point(847, 138);
            txbMatKhau.Name = "txbMatKhau";
            txbMatKhau.Size = new Size(312, 27);
            txbMatKhau.TabIndex = 18;
            // 
            // lbTaiKhoan
            // 
            lbTaiKhoan.AutoSize = true;
            lbTaiKhoan.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbTaiKhoan.Location = new Point(754, 87);
            lbTaiKhoan.Name = "lbTaiKhoan";
            lbTaiKhoan.Size = new Size(87, 23);
            lbTaiKhoan.TabIndex = 14;
            lbTaiKhoan.Text = "Tài khoản:";
            // 
            // cbLoaiTaiKhoan
            // 
            cbLoaiTaiKhoan.Cursor = Cursors.Hand;
            cbLoaiTaiKhoan.FormattingEnabled = true;
            cbLoaiTaiKhoan.Location = new Point(179, 104);
            cbLoaiTaiKhoan.Name = "cbLoaiTaiKhoan";
            cbLoaiTaiKhoan.Size = new Size(312, 28);
            cbLoaiTaiKhoan.TabIndex = 10;
            // 
            // lbLoaiTaiKhoan
            // 
            lbLoaiTaiKhoan.AutoSize = true;
            lbLoaiTaiKhoan.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbLoaiTaiKhoan.Location = new Point(51, 109);
            lbLoaiTaiKhoan.Name = "lbLoaiTaiKhoan";
            lbLoaiTaiKhoan.Size = new Size(122, 23);
            lbLoaiTaiKhoan.TabIndex = 13;
            lbLoaiTaiKhoan.Text = "Loại tài khoản:";
            // 
            // txbMaTaiKhoan
            // 
            txbMaTaiKhoan.Location = new Point(179, 44);
            txbMaTaiKhoan.Name = "txbMaTaiKhoan";
            txbMaTaiKhoan.Size = new Size(312, 27);
            txbMaTaiKhoan.TabIndex = 10;
            // 
            // lbMaTaiKhoan
            // 
            lbMaTaiKhoan.AutoSize = true;
            lbMaTaiKhoan.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbMaTaiKhoan.Location = new Point(51, 48);
            lbMaTaiKhoan.Name = "lbMaTaiKhoan";
            lbMaTaiKhoan.Size = new Size(116, 23);
            lbMaTaiKhoan.TabIndex = 10;
            lbMaTaiKhoan.Text = "Mã tài khoản:";
            // 
            // btThemTaiKhoan
            // 
            btThemTaiKhoan.BackgroundImage = (Image)resources.GetObject("btThemTaiKhoan.BackgroundImage");
            btThemTaiKhoan.BackgroundImageLayout = ImageLayout.Stretch;
            btThemTaiKhoan.Cursor = Cursors.Hand;
            btThemTaiKhoan.FlatAppearance.BorderSize = 0;
            btThemTaiKhoan.FlatStyle = FlatStyle.Flat;
            btThemTaiKhoan.Location = new Point(1051, 265);
            btThemTaiKhoan.Name = "btThemTaiKhoan";
            btThemTaiKhoan.Size = new Size(49, 46);
            btThemTaiKhoan.TabIndex = 23;
            btThemTaiKhoan.UseVisualStyleBackColor = true;
            btThemTaiKhoan.Click += btThemTaiKhoan_Click;
            // 
            // btSuaTaiKhoan
            // 
            btSuaTaiKhoan.BackgroundImage = (Image)resources.GetObject("btSuaTaiKhoan.BackgroundImage");
            btSuaTaiKhoan.BackgroundImageLayout = ImageLayout.Stretch;
            btSuaTaiKhoan.Cursor = Cursors.Hand;
            btSuaTaiKhoan.FlatAppearance.BorderSize = 0;
            btSuaTaiKhoan.FlatStyle = FlatStyle.Flat;
            btSuaTaiKhoan.Location = new Point(1127, 265);
            btSuaTaiKhoan.Name = "btSuaTaiKhoan";
            btSuaTaiKhoan.Size = new Size(49, 46);
            btSuaTaiKhoan.TabIndex = 24;
            btSuaTaiKhoan.UseVisualStyleBackColor = true;
            btSuaTaiKhoan.Click += btSuaTaiKhoan_Click;
            // 
            // btXoaTaiKhoan
            // 
            btXoaTaiKhoan.BackgroundImage = (Image)resources.GetObject("btXoaTaiKhoan.BackgroundImage");
            btXoaTaiKhoan.BackgroundImageLayout = ImageLayout.Stretch;
            btXoaTaiKhoan.Cursor = Cursors.Hand;
            btXoaTaiKhoan.FlatAppearance.BorderSize = 0;
            btXoaTaiKhoan.FlatStyle = FlatStyle.Flat;
            btXoaTaiKhoan.Location = new Point(1201, 265);
            btXoaTaiKhoan.Name = "btXoaTaiKhoan";
            btXoaTaiKhoan.Size = new Size(49, 46);
            btXoaTaiKhoan.TabIndex = 25;
            btXoaTaiKhoan.UseVisualStyleBackColor = true;
            btXoaTaiKhoan.Click += btXoaTaiKhoan_Click;
            // 
            // lbTimKiemTK
            // 
            lbTimKiemTK.AutoSize = true;
            lbTimKiemTK.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbTimKiemTK.Location = new Point(1005, 15);
            lbTimKiemTK.Name = "lbTimKiemTK";
            lbTimKiemTK.Size = new Size(203, 20);
            lbTimKiemTK.TabIndex = 26;
            lbTimKiemTK.Text = "Tìm kiếm theo loại tài khoản";
            // 
            // cbLoaiTK
            // 
            cbLoaiTK.Cursor = Cursors.Hand;
            cbLoaiTK.FormattingEnabled = true;
            cbLoaiTK.Location = new Point(1010, 43);
            cbLoaiTK.Name = "cbLoaiTK";
            cbLoaiTK.Size = new Size(238, 28);
            cbLoaiTK.TabIndex = 27;
            cbLoaiTK.SelectedIndexChanged += cbLoaiTK_SelectedIndexChanged;
            // 
            // MaTaiKhoan
            // 
            MaTaiKhoan.DataPropertyName = "MaTaiKhoan";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            MaTaiKhoan.DefaultCellStyle = dataGridViewCellStyle2;
            MaTaiKhoan.HeaderText = "Mã tài khoản";
            MaTaiKhoan.MinimumWidth = 6;
            MaTaiKhoan.Name = "MaTaiKhoan";
            // 
            // Username
            // 
            Username.DataPropertyName = "Username";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Username.DefaultCellStyle = dataGridViewCellStyle3;
            Username.HeaderText = "Tài khoản";
            Username.MinimumWidth = 6;
            Username.Name = "Username";
            // 
            // Password
            // 
            Password.DataPropertyName = "Password";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Password.DefaultCellStyle = dataGridViewCellStyle4;
            Password.HeaderText = "Mật khẩu";
            Password.MinimumWidth = 6;
            Password.Name = "Password";
            // 
            // LoaiTaiKhoan
            // 
            LoaiTaiKhoan.DataPropertyName = "TenQuyen";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            LoaiTaiKhoan.DefaultCellStyle = dataGridViewCellStyle5;
            LoaiTaiKhoan.HeaderText = "Loại tài khoản";
            LoaiTaiKhoan.MinimumWidth = 6;
            LoaiTaiKhoan.Name = "LoaiTaiKhoan";
            // 
            // MaNhanVien
            // 
            MaNhanVien.DataPropertyName = "HoTen";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            MaNhanVien.DefaultCellStyle = dataGridViewCellStyle6;
            MaNhanVien.HeaderText = "Nhân viên";
            MaNhanVien.MinimumWidth = 6;
            MaNhanVien.Name = "MaNhanVien";
            // 
            // FormQuanLyTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1264, 571);
            ControlBox = false;
            Controls.Add(cbLoaiTK);
            Controls.Add(lbTimKiemTK);
            Controls.Add(btXoaTaiKhoan);
            Controls.Add(btThemTaiKhoan);
            Controls.Add(btSuaTaiKhoan);
            Controls.Add(PanelThongTinTK);
            Controls.Add(lbThongTinTK);
            Controls.Add(dgvTaiKhoan);
            Controls.Add(lbDanhSachNV);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormQuanLyTaiKhoan";
            WindowState = FormWindowState.Maximized;
            Load += FormQuanLyTaiKhoan_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTaiKhoan).EndInit();
            PanelThongTinTK.ResumeLayout(false);
            PanelThongTinTK.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbDanhSachNV;
        private DataGridView dgvTaiKhoan;
        private DataGridViewTextBoxColumn NgaySinh;
        private DataGridViewTextBoxColumn GioiTinh;
        private DataGridViewTextBoxColumn SoDienThoai;
        private DataGridViewTextBoxColumn ChucVu;
        private Label lbThongTinTK;
        private Panel PanelThongTinTK;
        private Label lbMatKhau;
        private TextBox txbMatKhau;
        private Label lbTaiKhoan;
        private ComboBox cbLoaiTaiKhoan;
        private Label lbLoaiTaiKhoan;
        private TextBox txbMaTaiKhoan;
        private Label lbMaTaiKhoan;
        private Button btThemTaiKhoan;
        private Button btSuaTaiKhoan;
        private Button btXoaTaiKhoan;
        private Label lbTimKiemTK;
        private ComboBox cbLoaiTK;
        private TextBox txbTaiKhoan;
        private ComboBox comboBox1;
        private Label lbMaNhanVien;
        private ComboBox cbMaNhanVien;
        private DataGridViewTextBoxColumn MaTaiKhoan;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewTextBoxColumn LoaiTaiKhoan;
        private DataGridViewTextBoxColumn MaNhanVien;
    }
}