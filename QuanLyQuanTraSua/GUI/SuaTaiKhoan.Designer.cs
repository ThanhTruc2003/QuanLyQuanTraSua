namespace QuanLyQuanTraSua.GUI
{
    partial class FormSuaTaiKhoan
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
            lbThongTinTK = new Label();
            PanelThongTinTK = new Panel();
            txbMaNhanVien = new TextBox();
            bt_Sua = new Button();
            lbMaNhanVien = new Label();
            cbLoaiTaiKhoan = new ComboBox();
            lbLoaiTaiKhoan = new Label();
            txbMatKhau = new TextBox();
            lbMatKhau = new Label();
            txbTaiKhoan = new TextBox();
            lbTaiKhoan = new Label();
            txbMaTaiKhoan = new TextBox();
            lbMaTaiKhoan = new Label();
            PanelThongTinTK.SuspendLayout();
            SuspendLayout();
            // 
            // lbThongTinTK
            // 
            lbThongTinTK.AutoSize = true;
            lbThongTinTK.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbThongTinTK.Location = new Point(92, 20);
            lbThongTinTK.Name = "lbThongTinTK";
            lbThongTinTK.Size = new Size(360, 41);
            lbThongTinTK.TabIndex = 11;
            lbThongTinTK.Text = "THÔNG TIN TÀI KHOẢN";
            // 
            // PanelThongTinTK
            // 
            PanelThongTinTK.BackColor = Color.MistyRose;
            PanelThongTinTK.BorderStyle = BorderStyle.FixedSingle;
            PanelThongTinTK.Controls.Add(txbMaNhanVien);
            PanelThongTinTK.Controls.Add(bt_Sua);
            PanelThongTinTK.Controls.Add(lbMaNhanVien);
            PanelThongTinTK.Controls.Add(cbLoaiTaiKhoan);
            PanelThongTinTK.Controls.Add(lbLoaiTaiKhoan);
            PanelThongTinTK.Controls.Add(txbMatKhau);
            PanelThongTinTK.Controls.Add(lbMatKhau);
            PanelThongTinTK.Controls.Add(txbTaiKhoan);
            PanelThongTinTK.Controls.Add(lbTaiKhoan);
            PanelThongTinTK.Controls.Add(txbMaTaiKhoan);
            PanelThongTinTK.Controls.Add(lbMaTaiKhoan);
            PanelThongTinTK.Location = new Point(12, 80);
            PanelThongTinTK.Name = "PanelThongTinTK";
            PanelThongTinTK.Size = new Size(496, 388);
            PanelThongTinTK.TabIndex = 12;
            // 
            // txbMaNhanVien
            // 
            txbMaNhanVien.Location = new Point(149, 266);
            txbMaNhanVien.Name = "txbMaNhanVien";
            txbMaNhanVien.ReadOnly = true;
            txbMaNhanVien.Size = new Size(312, 27);
            txbMaNhanVien.TabIndex = 32;
            // 
            // bt_Sua
            // 
            bt_Sua.BackColor = Color.FromArgb(255, 192, 192);
            bt_Sua.Cursor = Cursors.Hand;
            bt_Sua.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bt_Sua.Location = new Point(149, 322);
            bt_Sua.Name = "bt_Sua";
            bt_Sua.Size = new Size(312, 44);
            bt_Sua.TabIndex = 31;
            bt_Sua.Text = "Sửa";
            bt_Sua.UseVisualStyleBackColor = false;
            bt_Sua.Click += bt_Sua_Click;
            // 
            // lbMaNhanVien
            // 
            lbMaNhanVien.AutoSize = true;
            lbMaNhanVien.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbMaNhanVien.Location = new Point(21, 270);
            lbMaNhanVien.Name = "lbMaNhanVien";
            lbMaNhanVien.Size = new Size(120, 23);
            lbMaNhanVien.TabIndex = 29;
            lbMaNhanVien.Text = "Mã nhân viên:";
            // 
            // cbLoaiTaiKhoan
            // 
            cbLoaiTaiKhoan.Cursor = Cursors.Hand;
            cbLoaiTaiKhoan.FormattingEnabled = true;
            cbLoaiTaiKhoan.Location = new Point(149, 199);
            cbLoaiTaiKhoan.Name = "cbLoaiTaiKhoan";
            cbLoaiTaiKhoan.Size = new Size(312, 28);
            cbLoaiTaiKhoan.TabIndex = 28;
            // 
            // lbLoaiTaiKhoan
            // 
            lbLoaiTaiKhoan.AutoSize = true;
            lbLoaiTaiKhoan.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbLoaiTaiKhoan.Location = new Point(21, 204);
            lbLoaiTaiKhoan.Name = "lbLoaiTaiKhoan";
            lbLoaiTaiKhoan.Size = new Size(122, 23);
            lbLoaiTaiKhoan.TabIndex = 27;
            lbLoaiTaiKhoan.Text = "Loại tài khoản:";
            // 
            // txbMatKhau
            // 
            txbMatKhau.Location = new Point(149, 137);
            txbMatKhau.Name = "txbMatKhau";
            txbMatKhau.Size = new Size(312, 27);
            txbMatKhau.TabIndex = 26;
            // 
            // lbMatKhau
            // 
            lbMatKhau.AutoSize = true;
            lbMatKhau.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbMatKhau.Location = new Point(21, 141);
            lbMatKhau.Name = "lbMatKhau";
            lbMatKhau.Size = new Size(88, 23);
            lbMatKhau.TabIndex = 25;
            lbMatKhau.Text = "Mật khẩu:";
            // 
            // txbTaiKhoan
            // 
            txbTaiKhoan.Location = new Point(149, 79);
            txbTaiKhoan.Name = "txbTaiKhoan";
            txbTaiKhoan.Size = new Size(312, 27);
            txbTaiKhoan.TabIndex = 24;
            // 
            // lbTaiKhoan
            // 
            lbTaiKhoan.AutoSize = true;
            lbTaiKhoan.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbTaiKhoan.Location = new Point(21, 83);
            lbTaiKhoan.Name = "lbTaiKhoan";
            lbTaiKhoan.Size = new Size(87, 23);
            lbTaiKhoan.TabIndex = 15;
            lbTaiKhoan.Text = "Tài khoản:";
            // 
            // txbMaTaiKhoan
            // 
            txbMaTaiKhoan.Location = new Point(149, 22);
            txbMaTaiKhoan.Name = "txbMaTaiKhoan";
            txbMaTaiKhoan.ReadOnly = true;
            txbMaTaiKhoan.Size = new Size(312, 27);
            txbMaTaiKhoan.TabIndex = 14;
            // 
            // lbMaTaiKhoan
            // 
            lbMaTaiKhoan.AutoSize = true;
            lbMaTaiKhoan.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbMaTaiKhoan.Location = new Point(21, 26);
            lbMaTaiKhoan.Name = "lbMaTaiKhoan";
            lbMaTaiKhoan.Size = new Size(116, 23);
            lbMaTaiKhoan.TabIndex = 13;
            lbMaTaiKhoan.Text = "Mã tài khoản:";
            // 
            // FormSuaTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(521, 480);
            Controls.Add(PanelThongTinTK);
            Controls.Add(lbThongTinTK);
            Name = "FormSuaTaiKhoan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sửa tài khoản";
            Load += FormSuaTaiKhoan_Load;
            PanelThongTinTK.ResumeLayout(false);
            PanelThongTinTK.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbThongTinTK;
        private Panel PanelThongTinTK;
        private Label lbMaTaiKhoan;
        private TextBox txbMaTaiKhoan;
        private Label lbTaiKhoan;
        private TextBox txbTaiKhoan;
        private Label lbMatKhau;
        private TextBox txbMatKhau;
        private Label lbLoaiTaiKhoan;
        private ComboBox cbLoaiTaiKhoan;
        private Label lbMaNhanVien;
        private Button bt_Sua;
        private TextBox txbMaNhanVien;
    }
}