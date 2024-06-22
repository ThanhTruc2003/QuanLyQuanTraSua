namespace QuanLyQuanTraSua
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            pictureLogin = new PictureBox();
            lbTaiKhoan = new Label();
            lbMatKhau = new Label();
            txbTaiKhoan = new TextBox();
            txbMatKhau = new TextBox();
            btDangNhap = new Button();
            btThoat = new Button();
            btHideEye = new Button();
            btShowEye = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureLogin).BeginInit();
            SuspendLayout();
            // 
            // pictureLogin
            // 
            pictureLogin.BackColor = Color.White;
            pictureLogin.Image = (Image)resources.GetObject("pictureLogin.Image");
            pictureLogin.Location = new Point(683, 21);
            pictureLogin.Name = "pictureLogin";
            pictureLogin.Size = new Size(142, 125);
            pictureLogin.SizeMode = PictureBoxSizeMode.Zoom;
            pictureLogin.TabIndex = 0;
            pictureLogin.TabStop = false;
            // 
            // lbTaiKhoan
            // 
            lbTaiKhoan.AutoSize = true;
            lbTaiKhoan.BackColor = Color.White;
            lbTaiKhoan.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbTaiKhoan.ForeColor = SystemColors.ActiveCaptionText;
            lbTaiKhoan.Location = new Point(580, 164);
            lbTaiKhoan.Name = "lbTaiKhoan";
            lbTaiKhoan.Size = new Size(119, 31);
            lbTaiKhoan.TabIndex = 1;
            lbTaiKhoan.Text = "Tài khoản:";
            // 
            // lbMatKhau
            // 
            lbMatKhau.AutoSize = true;
            lbMatKhau.BackColor = Color.White;
            lbMatKhau.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbMatKhau.ForeColor = SystemColors.ActiveCaptionText;
            lbMatKhau.Location = new Point(582, 250);
            lbMatKhau.Name = "lbMatKhau";
            lbMatKhau.Size = new Size(117, 31);
            lbMatKhau.TabIndex = 2;
            lbMatKhau.Text = "Mật khẩu:";
            // 
            // txbTaiKhoan
            // 
            txbTaiKhoan.BackColor = Color.Pink;
            txbTaiKhoan.BorderStyle = BorderStyle.FixedSingle;
            txbTaiKhoan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txbTaiKhoan.Location = new Point(589, 198);
            txbTaiKhoan.Multiline = true;
            txbTaiKhoan.Name = "txbTaiKhoan";
            txbTaiKhoan.Size = new Size(329, 35);
            txbTaiKhoan.TabIndex = 3;
            // 
            // txbMatKhau
            // 
            txbMatKhau.BackColor = Color.Pink;
            txbMatKhau.BorderStyle = BorderStyle.FixedSingle;
            txbMatKhau.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txbMatKhau.Location = new Point(589, 284);
            txbMatKhau.Multiline = true;
            txbMatKhau.Name = "txbMatKhau";
            txbMatKhau.PasswordChar = '*';
            txbMatKhau.Size = new Size(329, 35);
            txbMatKhau.TabIndex = 5;
            // 
            // btDangNhap
            // 
            btDangNhap.BackColor = Color.FromArgb(255, 192, 192);
            btDangNhap.Cursor = Cursors.Hand;
            btDangNhap.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btDangNhap.Location = new Point(589, 370);
            btDangNhap.Name = "btDangNhap";
            btDangNhap.Size = new Size(329, 56);
            btDangNhap.TabIndex = 6;
            btDangNhap.Text = "Đăng nhập";
            btDangNhap.UseVisualStyleBackColor = false;
            btDangNhap.Click += btDangNhap_Click;
            // 
            // btThoat
            // 
            btThoat.BackColor = Color.FromArgb(255, 192, 192);
            btThoat.Cursor = Cursors.Hand;
            btThoat.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btThoat.Location = new Point(589, 444);
            btThoat.Name = "btThoat";
            btThoat.Size = new Size(329, 56);
            btThoat.TabIndex = 9;
            btThoat.Text = "Thoát";
            btThoat.UseVisualStyleBackColor = false;
            btThoat.Click += btThoat_Click;
            // 
            // btHideEye
            // 
            btHideEye.BackColor = Color.FromArgb(255, 192, 192);
            btHideEye.BackgroundImage = (Image)resources.GetObject("btHideEye.BackgroundImage");
            btHideEye.BackgroundImageLayout = ImageLayout.Zoom;
            btHideEye.Cursor = Cursors.Hand;
            btHideEye.Location = new Point(924, 284);
            btHideEye.Name = "btHideEye";
            btHideEye.Size = new Size(40, 35);
            btHideEye.TabIndex = 10;
            btHideEye.UseVisualStyleBackColor = false;
            btHideEye.Click += btHideEye_Click;
            // 
            // btShowEye
            // 
            btShowEye.BackColor = Color.FromArgb(255, 192, 192);
            btShowEye.BackgroundImage = (Image)resources.GetObject("btShowEye.BackgroundImage");
            btShowEye.BackgroundImageLayout = ImageLayout.Zoom;
            btShowEye.Cursor = Cursors.Hand;
            btShowEye.Location = new Point(924, 284);
            btShowEye.Name = "btShowEye";
            btShowEye.Size = new Size(40, 35);
            btShowEye.TabIndex = 11;
            btShowEye.UseVisualStyleBackColor = false;
            btShowEye.Click += btShowEye_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(991, 534);
            Controls.Add(btThoat);
            Controls.Add(btDangNhap);
            Controls.Add(txbTaiKhoan);
            Controls.Add(lbMatKhau);
            Controls.Add(lbTaiKhoan);
            Controls.Add(pictureLogin);
            Controls.Add(txbMatKhau);
            Controls.Add(btShowEye);
            Controls.Add(btHideEye);
            DoubleBuffered = true;
            ForeColor = SystemColors.WindowText;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)pictureLogin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureLogin;
        private Label lbTaiKhoan;
        private Label lbMatKhau;
        private TextBox txbTaiKhoan;
        private TextBox txbMatKhau;
        private Button btDangNhap;
        private Button btThoat;
        private Button btHideEye;
        private Button btShowEye;
    }
}