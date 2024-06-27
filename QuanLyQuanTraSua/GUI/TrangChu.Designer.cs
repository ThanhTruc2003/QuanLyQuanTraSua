using System.Windows.Forms;

namespace QuanLyQuanTraSua.GUI
{
    partial class FormTrangChu
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTrangChu));
            PanelAnhNen = new Panel();
            pictureLogo = new PictureBox();
            lbWelcome = new Label();
            LogoUser = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            timerToCollapseThongKe = new System.Windows.Forms.Timer(components);
            flowLayoutPanel1 = new FlowLayoutPanel();
            PanelGoiMon = new Panel();
            LogoGoiMon = new PictureBox();
            lbGoiMon = new Label();
            PanelQuanLy = new Panel();
            btQLTaiKhoan = new Button();
            btQLHoaDon = new Button();
            btQLSanPham = new Button();
            btQLDanhMuc = new Button();
            btQLNhanVien = new Button();
            LogoQuanLy = new PictureBox();
            lbQuanLy = new Label();
            PanelThongKe = new Panel();
            btThongKeDoanhThu = new Button();
            btThongKeSanPham = new Button();
            lbThongKe = new Label();
            LogoThongKe = new PictureBox();
            PanelHeThong = new Panel();
            btDangXuat = new Button();
            btDoiMatKhau = new Button();
            btThongTin = new Button();
            LogoHeThong = new PictureBox();
            lbHeThong = new Label();
            PanelThoat = new Panel();
            lbThoat = new Label();
            LogoThoat = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LogoUser).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            PanelGoiMon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LogoGoiMon).BeginInit();
            PanelQuanLy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LogoQuanLy).BeginInit();
            PanelThongKe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LogoThongKe).BeginInit();
            PanelHeThong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LogoHeThong).BeginInit();
            PanelThoat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LogoThoat).BeginInit();
            SuspendLayout();
            // 
            // PanelAnhNen
            // 
            PanelAnhNen.BackColor = Color.White;
            PanelAnhNen.BackgroundImage = (Image)resources.GetObject("PanelAnhNen.BackgroundImage");
            PanelAnhNen.BackgroundImageLayout = ImageLayout.Stretch;
            PanelAnhNen.Location = new Point(131, 89);
            PanelAnhNen.Name = "PanelAnhNen";
            PanelAnhNen.Size = new Size(1273, 578);
            PanelAnhNen.TabIndex = 0;
            // 
            // pictureLogo
            // 
            pictureLogo.BackColor = Color.Pink;
            pictureLogo.Image = (Image)resources.GetObject("pictureLogo.Image");
            pictureLogo.Location = new Point(0, 0);
            pictureLogo.Name = "pictureLogo";
            pictureLogo.Size = new Size(131, 92);
            pictureLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureLogo.TabIndex = 1;
            pictureLogo.TabStop = false;
            // 
            // lbWelcome
            // 
            lbWelcome.AutoSize = true;
            lbWelcome.FlatStyle = FlatStyle.Popup;
            lbWelcome.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbWelcome.Location = new Point(1165, 34);
            lbWelcome.Name = "lbWelcome";
            lbWelcome.Size = new Size(0, 23);
            lbWelcome.TabIndex = 12;
            // 
            // LogoUser
            // 
            LogoUser.Image = (Image)resources.GetObject("LogoUser.Image");
            LogoUser.Location = new Point(1102, 15);
            LogoUser.Name = "LogoUser";
            LogoUser.Size = new Size(64, 55);
            LogoUser.SizeMode = PictureBoxSizeMode.Zoom;
            LogoUser.TabIndex = 15;
            LogoUser.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 15;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Interval = 15;
            timer2.Tick += timer2_Tick;
            // 
            // timerToCollapseThongKe
            // 
            timerToCollapseThongKe.Interval = 15;
            timerToCollapseThongKe.Tick += timerToCollapseThongKe_Tick;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.AutoScrollMinSize = new Size(0, 578);
            flowLayoutPanel1.Controls.Add(PanelGoiMon);
            flowLayoutPanel1.Controls.Add(PanelQuanLy);
            flowLayoutPanel1.Controls.Add(PanelThongKe);
            flowLayoutPanel1.Controls.Add(PanelHeThong);
            flowLayoutPanel1.Controls.Add(PanelThoat);
            flowLayoutPanel1.Location = new Point(0, 89);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.MaximumSize = new Size(131, 578);
            flowLayoutPanel1.MinimumSize = new Size(131, 578);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(131, 578);
            flowLayoutPanel1.TabIndex = 16;
            // 
            // PanelGoiMon
            // 
            PanelGoiMon.AutoScroll = true;
            PanelGoiMon.Controls.Add(LogoGoiMon);
            PanelGoiMon.Controls.Add(lbGoiMon);
            PanelGoiMon.Cursor = Cursors.Hand;
            PanelGoiMon.Location = new Point(0, 30);
            PanelGoiMon.Margin = new Padding(0, 30, 0, 16);
            PanelGoiMon.Name = "PanelGoiMon";
            PanelGoiMon.Size = new Size(131, 95);
            PanelGoiMon.TabIndex = 24;
            PanelGoiMon.Click += PanelGoiMon_Click;
            PanelGoiMon.MouseEnter += PanelGoiMon_MouseEnter;
            PanelGoiMon.MouseLeave += PanelGoiMon_MouseLeave;
            // 
            // LogoGoiMon
            // 
            LogoGoiMon.Cursor = Cursors.Hand;
            LogoGoiMon.Image = (Image)resources.GetObject("LogoGoiMon.Image");
            LogoGoiMon.Location = new Point(37, 5);
            LogoGoiMon.Name = "LogoGoiMon";
            LogoGoiMon.Size = new Size(59, 55);
            LogoGoiMon.SizeMode = PictureBoxSizeMode.StretchImage;
            LogoGoiMon.TabIndex = 16;
            LogoGoiMon.TabStop = false;
            // 
            // lbGoiMon
            // 
            lbGoiMon.AutoSize = true;
            lbGoiMon.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbGoiMon.ForeColor = SystemColors.ControlText;
            lbGoiMon.Location = new Point(32, 61);
            lbGoiMon.Name = "lbGoiMon";
            lbGoiMon.Size = new Size(66, 20);
            lbGoiMon.TabIndex = 3;
            lbGoiMon.Text = "Gọi món";
            // 
            // PanelQuanLy
            // 
            PanelQuanLy.BackColor = Color.MistyRose;
            PanelQuanLy.Controls.Add(btQLTaiKhoan);
            PanelQuanLy.Controls.Add(btQLHoaDon);
            PanelQuanLy.Controls.Add(btQLSanPham);
            PanelQuanLy.Controls.Add(btQLDanhMuc);
            PanelQuanLy.Controls.Add(btQLNhanVien);
            PanelQuanLy.Controls.Add(LogoQuanLy);
            PanelQuanLy.Controls.Add(lbQuanLy);
            PanelQuanLy.Cursor = Cursors.Hand;
            PanelQuanLy.Location = new Point(0, 141);
            PanelQuanLy.Margin = new Padding(0, 0, 0, 16);
            PanelQuanLy.MaximumSize = new Size(131, 236);
            PanelQuanLy.MinimumSize = new Size(131, 89);
            PanelQuanLy.Name = "PanelQuanLy";
            PanelQuanLy.Size = new Size(131, 89);
            PanelQuanLy.TabIndex = 22;
            PanelQuanLy.Click += PanelQuanLy_Click;
            PanelQuanLy.MouseEnter += PanelQuanLy_MouseEnter;
            PanelQuanLy.MouseLeave += PanelQuanLy_MouseLeave;
            // 
            // btQLTaiKhoan
            // 
            btQLTaiKhoan.BackColor = Color.FromArgb(255, 192, 192);
            btQLTaiKhoan.Cursor = Cursors.Hand;
            btQLTaiKhoan.FlatStyle = FlatStyle.Flat;
            btQLTaiKhoan.Location = new Point(0, 205);
            btQLTaiKhoan.Name = "btQLTaiKhoan";
            btQLTaiKhoan.Size = new Size(110, 29);
            btQLTaiKhoan.TabIndex = 10;
            btQLTaiKhoan.Text = "Tài khoản";
            btQLTaiKhoan.TextAlign = ContentAlignment.MiddleLeft;
            btQLTaiKhoan.UseVisualStyleBackColor = false;
            btQLTaiKhoan.Click += btQLTaiKhoan_Click;
            // 
            // btQLHoaDon
            // 
            btQLHoaDon.BackColor = Color.FromArgb(255, 192, 192);
            btQLHoaDon.Cursor = Cursors.Hand;
            btQLHoaDon.FlatAppearance.BorderColor = Color.Black;
            btQLHoaDon.FlatStyle = FlatStyle.Flat;
            btQLHoaDon.Location = new Point(0, 177);
            btQLHoaDon.Name = "btQLHoaDon";
            btQLHoaDon.Size = new Size(110, 29);
            btQLHoaDon.TabIndex = 9;
            btQLHoaDon.Text = "Hóa đơn";
            btQLHoaDon.TextAlign = ContentAlignment.MiddleLeft;
            btQLHoaDon.UseVisualStyleBackColor = false;
            btQLHoaDon.Click += btQLHoaDon_Click;
            // 
            // btQLSanPham
            // 
            btQLSanPham.BackColor = Color.FromArgb(255, 192, 192);
            btQLSanPham.Cursor = Cursors.Hand;
            btQLSanPham.FlatAppearance.BorderColor = Color.Black;
            btQLSanPham.FlatStyle = FlatStyle.Flat;
            btQLSanPham.Location = new Point(0, 149);
            btQLSanPham.Name = "btQLSanPham";
            btQLSanPham.Size = new Size(110, 29);
            btQLSanPham.TabIndex = 8;
            btQLSanPham.Text = "Sản phẩm";
            btQLSanPham.TextAlign = ContentAlignment.MiddleLeft;
            btQLSanPham.UseVisualStyleBackColor = false;
            btQLSanPham.Click += btQLSanPham_Click;
            // 
            // btQLDanhMuc
            // 
            btQLDanhMuc.BackColor = Color.FromArgb(255, 192, 192);
            btQLDanhMuc.Cursor = Cursors.Hand;
            btQLDanhMuc.FlatAppearance.BorderColor = Color.Black;
            btQLDanhMuc.FlatStyle = FlatStyle.Flat;
            btQLDanhMuc.Location = new Point(0, 121);
            btQLDanhMuc.Name = "btQLDanhMuc";
            btQLDanhMuc.Size = new Size(110, 29);
            btQLDanhMuc.TabIndex = 7;
            btQLDanhMuc.Text = "Danh mục";
            btQLDanhMuc.TextAlign = ContentAlignment.MiddleLeft;
            btQLDanhMuc.UseVisualStyleBackColor = false;
            btQLDanhMuc.Click += btQLDanhMuc_Click;
            // 
            // btQLNhanVien
            // 
            btQLNhanVien.BackColor = Color.FromArgb(255, 192, 192);
            btQLNhanVien.Cursor = Cursors.Hand;
            btQLNhanVien.FlatAppearance.BorderColor = Color.Black;
            btQLNhanVien.FlatStyle = FlatStyle.Flat;
            btQLNhanVien.Location = new Point(0, 93);
            btQLNhanVien.Name = "btQLNhanVien";
            btQLNhanVien.Size = new Size(110, 29);
            btQLNhanVien.TabIndex = 6;
            btQLNhanVien.Text = "Nhân viên";
            btQLNhanVien.TextAlign = ContentAlignment.MiddleLeft;
            btQLNhanVien.UseVisualStyleBackColor = false;
            btQLNhanVien.Click += btQLNhanVien_Click;
            // 
            // LogoQuanLy
            // 
            LogoQuanLy.Cursor = Cursors.Hand;
            LogoQuanLy.Image = (Image)resources.GetObject("LogoQuanLy.Image");
            LogoQuanLy.Location = new Point(34, 0);
            LogoQuanLy.Name = "LogoQuanLy";
            LogoQuanLy.Size = new Size(59, 55);
            LogoQuanLy.SizeMode = PictureBoxSizeMode.Zoom;
            LogoQuanLy.TabIndex = 4;
            LogoQuanLy.TabStop = false;
            // 
            // lbQuanLy
            // 
            lbQuanLy.AutoSize = true;
            lbQuanLy.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbQuanLy.Location = new Point(34, 58);
            lbQuanLy.Name = "lbQuanLy";
            lbQuanLy.Size = new Size(59, 20);
            lbQuanLy.TabIndex = 5;
            lbQuanLy.Text = "Quản lý";
            // 
            // PanelThongKe
            // 
            PanelThongKe.Controls.Add(btThongKeDoanhThu);
            PanelThongKe.Controls.Add(btThongKeSanPham);
            PanelThongKe.Controls.Add(lbThongKe);
            PanelThongKe.Controls.Add(LogoThongKe);
            PanelThongKe.Cursor = Cursors.Hand;
            PanelThongKe.Location = new Point(0, 246);
            PanelThongKe.Margin = new Padding(0, 0, 0, 16);
            PanelThongKe.MaximumSize = new Size(131, 156);
            PanelThongKe.MinimumSize = new Size(131, 89);
            PanelThongKe.Name = "PanelThongKe";
            PanelThongKe.Size = new Size(131, 89);
            PanelThongKe.TabIndex = 25;
            PanelThongKe.Click += PanelThongKe_Click;
            PanelThongKe.MouseEnter += PanelThongKe_MouseEnter;
            PanelThongKe.MouseLeave += PanelThongKe_MouseLeave;
            // 
            // btThongKeDoanhThu
            // 
            btThongKeDoanhThu.BackColor = Color.FromArgb(255, 192, 192);
            btThongKeDoanhThu.Cursor = Cursors.Hand;
            btThongKeDoanhThu.FlatAppearance.BorderColor = Color.Black;
            btThongKeDoanhThu.FlatStyle = FlatStyle.Flat;
            btThongKeDoanhThu.Location = new Point(0, 96);
            btThongKeDoanhThu.Name = "btThongKeDoanhThu";
            btThongKeDoanhThu.Size = new Size(110, 29);
            btThongKeDoanhThu.TabIndex = 8;
            btThongKeDoanhThu.Text = "Doanh thu";
            btThongKeDoanhThu.TextAlign = ContentAlignment.MiddleLeft;
            btThongKeDoanhThu.UseVisualStyleBackColor = false;
            btThongKeDoanhThu.Click += btDoanhThu_Click;
            // 
            // btThongKeSanPham
            // 
            btThongKeSanPham.BackColor = Color.FromArgb(255, 192, 192);
            btThongKeSanPham.Cursor = Cursors.Hand;
            btThongKeSanPham.FlatAppearance.BorderColor = Color.Black;
            btThongKeSanPham.FlatStyle = FlatStyle.Flat;
            btThongKeSanPham.Location = new Point(0, 125);
            btThongKeSanPham.Name = "btThongKeSanPham";
            btThongKeSanPham.Size = new Size(110, 31);
            btThongKeSanPham.TabIndex = 8;
            btThongKeSanPham.Text = "Sản phẩm";
            btThongKeSanPham.TextAlign = ContentAlignment.MiddleLeft;
            btThongKeSanPham.UseVisualStyleBackColor = false;
            btThongKeSanPham.Click += btThongKeSanPham_Click;
            // 
            // lbThongKe
            // 
            lbThongKe.AutoSize = true;
            lbThongKe.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbThongKe.Location = new Point(31, 58);
            lbThongKe.Name = "lbThongKe";
            lbThongKe.Size = new Size(70, 20);
            lbThongKe.TabIndex = 7;
            lbThongKe.Text = "Thống kê";
            // 
            // LogoThongKe
            // 
            LogoThongKe.Cursor = Cursors.Hand;
            LogoThongKe.Image = (Image)resources.GetObject("LogoThongKe.Image");
            LogoThongKe.Location = new Point(32, 0);
            LogoThongKe.Name = "LogoThongKe";
            LogoThongKe.Size = new Size(66, 55);
            LogoThongKe.SizeMode = PictureBoxSizeMode.Zoom;
            LogoThongKe.TabIndex = 6;
            LogoThongKe.TabStop = false;
            // 
            // PanelHeThong
            // 
            PanelHeThong.Controls.Add(btDangXuat);
            PanelHeThong.Controls.Add(btDoiMatKhau);
            PanelHeThong.Controls.Add(btThongTin);
            PanelHeThong.Controls.Add(LogoHeThong);
            PanelHeThong.Controls.Add(lbHeThong);
            PanelHeThong.Cursor = Cursors.Hand;
            PanelHeThong.Location = new Point(0, 351);
            PanelHeThong.Margin = new Padding(0, 0, 0, 16);
            PanelHeThong.MaximumSize = new Size(131, 178);
            PanelHeThong.MinimumSize = new Size(131, 89);
            PanelHeThong.Name = "PanelHeThong";
            PanelHeThong.Size = new Size(131, 89);
            PanelHeThong.TabIndex = 23;
            PanelHeThong.Click += PanelHeThong_Click;
            PanelHeThong.MouseEnter += PanelHeThong_MouseEnter;
            PanelHeThong.MouseLeave += PanelHeThong_MouseLeave;
            // 
            // btDangXuat
            // 
            btDangXuat.BackColor = Color.FromArgb(255, 192, 192);
            btDangXuat.Cursor = Cursors.Hand;
            btDangXuat.FlatAppearance.BorderColor = Color.Black;
            btDangXuat.FlatStyle = FlatStyle.Flat;
            btDangXuat.Location = new Point(0, 149);
            btDangXuat.Name = "btDangXuat";
            btDangXuat.Size = new Size(110, 29);
            btDangXuat.TabIndex = 8;
            btDangXuat.Text = "Đăng xuất";
            btDangXuat.TextAlign = ContentAlignment.MiddleLeft;
            btDangXuat.UseVisualStyleBackColor = false;
            btDangXuat.Click += btDangXuat_Click;
            // 
            // btDoiMatKhau
            // 
            btDoiMatKhau.BackColor = Color.FromArgb(255, 192, 192);
            btDoiMatKhau.Cursor = Cursors.Hand;
            btDoiMatKhau.FlatAppearance.BorderColor = Color.Black;
            btDoiMatKhau.FlatStyle = FlatStyle.Flat;
            btDoiMatKhau.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btDoiMatKhau.Location = new Point(0, 121);
            btDoiMatKhau.Name = "btDoiMatKhau";
            btDoiMatKhau.Size = new Size(110, 29);
            btDoiMatKhau.TabIndex = 7;
            btDoiMatKhau.Text = "Đổi mật khẩu";
            btDoiMatKhau.TextAlign = ContentAlignment.MiddleLeft;
            btDoiMatKhau.UseVisualStyleBackColor = false;
            btDoiMatKhau.Click += btDoiMatKhau_Click;
            // 
            // btThongTin
            // 
            btThongTin.BackColor = Color.FromArgb(255, 192, 192);
            btThongTin.Cursor = Cursors.Hand;
            btThongTin.FlatAppearance.BorderColor = Color.Black;
            btThongTin.FlatStyle = FlatStyle.Flat;
            btThongTin.Location = new Point(0, 93);
            btThongTin.Name = "btThongTin";
            btThongTin.Size = new Size(110, 29);
            btThongTin.TabIndex = 6;
            btThongTin.Text = "Thông tin";
            btThongTin.TextAlign = ContentAlignment.MiddleLeft;
            btThongTin.UseVisualStyleBackColor = false;
            btThongTin.Click += btThongTin_Click;
            // 
            // LogoHeThong
            // 
            LogoHeThong.Cursor = Cursors.Hand;
            LogoHeThong.Image = (Image)resources.GetObject("LogoHeThong.Image");
            LogoHeThong.Location = new Point(31, 1);
            LogoHeThong.Name = "LogoHeThong";
            LogoHeThong.Size = new Size(66, 55);
            LogoHeThong.SizeMode = PictureBoxSizeMode.Zoom;
            LogoHeThong.TabIndex = 8;
            LogoHeThong.TabStop = false;
            // 
            // lbHeThong
            // 
            lbHeThong.AutoSize = true;
            lbHeThong.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbHeThong.Location = new Point(30, 60);
            lbHeThong.Name = "lbHeThong";
            lbHeThong.Size = new Size(71, 20);
            lbHeThong.TabIndex = 9;
            lbHeThong.Text = "Hệ thống";
            // 
            // PanelThoat
            // 
            PanelThoat.Controls.Add(lbThoat);
            PanelThoat.Controls.Add(LogoThoat);
            PanelThoat.Cursor = Cursors.Hand;
            PanelThoat.Location = new Point(0, 456);
            PanelThoat.Margin = new Padding(0);
            PanelThoat.Name = "PanelThoat";
            PanelThoat.Size = new Size(131, 89);
            PanelThoat.TabIndex = 26;
            PanelThoat.Click += PanelThoat_Click;
            PanelThoat.MouseEnter += PanelThoat_MouseEnter;
            PanelThoat.MouseLeave += PanelThoat_MouseLeave;
            // 
            // lbThoat
            // 
            lbThoat.AutoSize = true;
            lbThoat.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbThoat.Location = new Point(39, 58);
            lbThoat.Name = "lbThoat";
            lbThoat.Size = new Size(47, 20);
            lbThoat.TabIndex = 11;
            lbThoat.Text = "Thoát";
            // 
            // LogoThoat
            // 
            LogoThoat.Cursor = Cursors.Hand;
            LogoThoat.Image = (Image)resources.GetObject("LogoThoat.Image");
            LogoThoat.Location = new Point(32, 0);
            LogoThoat.Name = "LogoThoat";
            LogoThoat.Size = new Size(66, 55);
            LogoThoat.SizeMode = PictureBoxSizeMode.Zoom;
            LogoThoat.TabIndex = 10;
            LogoThoat.TabStop = false;
            // 
            // FormTrangChu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1403, 668);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(PanelAnhNen);
            Controls.Add(LogoUser);
            Controls.Add(lbWelcome);
            Controls.Add(pictureLogo);
            Name = "FormTrangChu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trang chủ";
            ((System.ComponentModel.ISupportInitialize)pictureLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)LogoUser).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            PanelGoiMon.ResumeLayout(false);
            PanelGoiMon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LogoGoiMon).EndInit();
            PanelQuanLy.ResumeLayout(false);
            PanelQuanLy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LogoQuanLy).EndInit();
            PanelThongKe.ResumeLayout(false);
            PanelThongKe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LogoThongKe).EndInit();
            PanelHeThong.ResumeLayout(false);
            PanelHeThong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LogoHeThong).EndInit();
            PanelThoat.ResumeLayout(false);
            PanelThoat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LogoThoat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PanelAnhNen;
        private PictureBox pictureLogo;
        private Label lbWelcome;
        private PictureBox LogoUser;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timerToCollapseThongKe;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel PanelGoiMon;
        private PictureBox LogoGoiMon;
        private Label lbGoiMon;
        private Panel PanelThongKe;
        private Button btThongKeDoanhThu;
        private Button btThongKeSanPham;
        private Label lbThongKe;
        private PictureBox LogoThongKe;
        private Panel PanelHeThong;
        private Button btDangXuat;
        private Button btDoiMatKhau;
        private Button btThongTin;
        private PictureBox LogoHeThong;
        private Label lbHeThong;
        private Panel PanelThoat;
        private Label lbThoat;
        private PictureBox LogoThoat;
        private Panel PanelQuanLy;
        private Button btQLTaiKhoan;
        private Button btQLHoaDon;
        private Button btQLSanPham;
        private Button btQLDanhMuc;
        private Button btQLNhanVien;
        private PictureBox LogoQuanLy;
        private Label lbQuanLy;
    }
}