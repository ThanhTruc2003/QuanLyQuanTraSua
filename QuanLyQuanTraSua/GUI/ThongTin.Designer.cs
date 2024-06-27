namespace QuanLyQuanTraSua.GUI
{
    partial class FormThongTin
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
            lbDanhMucSP = new Label();
            PanelDanhMuc = new Panel();
            txbMK = new TextBox();
            lbMK = new Label();
            txbTK = new TextBox();
            lbTK = new Label();
            txbSDT = new TextBox();
            lbSDT = new Label();
            rbNu = new RadioButton();
            rbNam = new RadioButton();
            lbGioiTinh = new Label();
            dpNgaySinh = new DateTimePicker();
            lbNgaySinh = new Label();
            txbTenNV = new TextBox();
            lbTenNV = new Label();
            lbMaNV = new Label();
            txbMaNV = new TextBox();
            PanelDanhMuc.SuspendLayout();
            SuspendLayout();
            // 
            // lbDanhMucSP
            // 
            lbDanhMucSP.AutoSize = true;
            lbDanhMucSP.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbDanhMucSP.ForeColor = SystemColors.ActiveCaptionText;
            lbDanhMucSP.Location = new Point(108, 18);
            lbDanhMucSP.Name = "lbDanhMucSP";
            lbDanhMucSP.Size = new Size(310, 38);
            lbDanhMucSP.TabIndex = 1;
            lbDanhMucSP.Text = "THÔNG TIN CÁ NHÂN";
            // 
            // PanelDanhMuc
            // 
            PanelDanhMuc.BackColor = Color.White;
            PanelDanhMuc.BorderStyle = BorderStyle.FixedSingle;
            PanelDanhMuc.Controls.Add(txbMK);
            PanelDanhMuc.Controls.Add(lbMK);
            PanelDanhMuc.Controls.Add(txbTK);
            PanelDanhMuc.Controls.Add(lbTK);
            PanelDanhMuc.Controls.Add(txbSDT);
            PanelDanhMuc.Controls.Add(lbSDT);
            PanelDanhMuc.Controls.Add(rbNu);
            PanelDanhMuc.Controls.Add(rbNam);
            PanelDanhMuc.Controls.Add(lbGioiTinh);
            PanelDanhMuc.Controls.Add(dpNgaySinh);
            PanelDanhMuc.Controls.Add(lbNgaySinh);
            PanelDanhMuc.Controls.Add(txbTenNV);
            PanelDanhMuc.Controls.Add(lbTenNV);
            PanelDanhMuc.Controls.Add(lbMaNV);
            PanelDanhMuc.Controls.Add(txbMaNV);
            PanelDanhMuc.Location = new Point(12, 76);
            PanelDanhMuc.Name = "PanelDanhMuc";
            PanelDanhMuc.Size = new Size(503, 414);
            PanelDanhMuc.TabIndex = 2;
            // 
            // txbMK
            // 
            txbMK.Location = new Point(135, 349);
            txbMK.Name = "txbMK";
            txbMK.ReadOnly = true;
            txbMK.Size = new Size(345, 27);
            txbMK.TabIndex = 21;
            // 
            // lbMK
            // 
            lbMK.AutoSize = true;
            lbMK.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbMK.Location = new Point(11, 353);
            lbMK.Name = "lbMK";
            lbMK.Size = new Size(86, 23);
            lbMK.TabIndex = 20;
            lbMK.Text = "Mật khẩu:";
            // 
            // txbTK
            // 
            txbTK.Location = new Point(135, 300);
            txbTK.Name = "txbTK";
            txbTK.ReadOnly = true;
            txbTK.Size = new Size(345, 27);
            txbTK.TabIndex = 19;
            // 
            // lbTK
            // 
            lbTK.AutoSize = true;
            lbTK.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbTK.Location = new Point(11, 304);
            lbTK.Name = "lbTK";
            lbTK.Size = new Size(86, 23);
            lbTK.TabIndex = 18;
            lbTK.Text = "Tài khoản:";
            // 
            // txbSDT
            // 
            txbSDT.Location = new Point(135, 249);
            txbSDT.Name = "txbSDT";
            txbSDT.ReadOnly = true;
            txbSDT.Size = new Size(345, 27);
            txbSDT.TabIndex = 17;
            // 
            // lbSDT
            // 
            lbSDT.AutoSize = true;
            lbSDT.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbSDT.Location = new Point(11, 253);
            lbSDT.Name = "lbSDT";
            lbSDT.Size = new Size(115, 23);
            lbSDT.TabIndex = 16;
            lbSDT.Text = "Số điện thoại:";
            // 
            // rbNu
            // 
            rbNu.AutoSize = true;
            rbNu.Enabled = false;
            rbNu.Location = new Point(243, 200);
            rbNu.Name = "rbNu";
            rbNu.Size = new Size(50, 24);
            rbNu.TabIndex = 15;
            rbNu.TabStop = true;
            rbNu.Text = "Nữ";
            rbNu.UseVisualStyleBackColor = true;
            // 
            // rbNam
            // 
            rbNam.AutoSize = true;
            rbNam.Enabled = false;
            rbNam.Location = new Point(135, 200);
            rbNam.Name = "rbNam";
            rbNam.Size = new Size(62, 24);
            rbNam.TabIndex = 14;
            rbNam.TabStop = true;
            rbNam.Text = "Nam";
            rbNam.UseVisualStyleBackColor = true;
            // 
            // lbGioiTinh
            // 
            lbGioiTinh.AutoSize = true;
            lbGioiTinh.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbGioiTinh.Location = new Point(11, 201);
            lbGioiTinh.Name = "lbGioiTinh";
            lbGioiTinh.Size = new Size(79, 23);
            lbGioiTinh.TabIndex = 13;
            lbGioiTinh.Text = "Giới tính:";
            // 
            // dpNgaySinh
            // 
            dpNgaySinh.CustomFormat = "dd/MM/yyyy";
            dpNgaySinh.Enabled = false;
            dpNgaySinh.Format = DateTimePickerFormat.Custom;
            dpNgaySinh.Location = new Point(135, 140);
            dpNgaySinh.Name = "dpNgaySinh";
            dpNgaySinh.Size = new Size(345, 27);
            dpNgaySinh.TabIndex = 12;
            // 
            // lbNgaySinh
            // 
            lbNgaySinh.AutoSize = true;
            lbNgaySinh.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbNgaySinh.Location = new Point(11, 144);
            lbNgaySinh.Name = "lbNgaySinh";
            lbNgaySinh.Size = new Size(90, 23);
            lbNgaySinh.TabIndex = 11;
            lbNgaySinh.Text = "Ngày sinh:";
            // 
            // txbTenNV
            // 
            txbTenNV.Location = new Point(135, 79);
            txbTenNV.Name = "txbTenNV";
            txbTenNV.ReadOnly = true;
            txbTenNV.Size = new Size(345, 27);
            txbTenNV.TabIndex = 10;
            // 
            // lbTenNV
            // 
            lbTenNV.AutoSize = true;
            lbTenNV.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbTenNV.Location = new Point(11, 83);
            lbTenNV.Name = "lbTenNV";
            lbTenNV.Size = new Size(120, 23);
            lbTenNV.TabIndex = 9;
            lbTenNV.Text = "Tên nhân viên:";
            // 
            // lbMaNV
            // 
            lbMaNV.AutoSize = true;
            lbMaNV.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbMaNV.Location = new Point(11, 31);
            lbMaNV.Name = "lbMaNV";
            lbMaNV.Size = new Size(118, 23);
            lbMaNV.TabIndex = 8;
            lbMaNV.Text = "Mã nhân viên:";
            // 
            // txbMaNV
            // 
            txbMaNV.Location = new Point(135, 27);
            txbMaNV.Name = "txbMaNV";
            txbMaNV.ReadOnly = true;
            txbMaNV.Size = new Size(345, 27);
            txbMaNV.TabIndex = 2;
            // 
            // FormThongTin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(529, 506);
            ControlBox = false;
            Controls.Add(PanelDanhMuc);
            Controls.Add(lbDanhMucSP);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormThongTin";
            StartPosition = FormStartPosition.Manual;
            Text = "Thông tin cá nhân";
            Load += FormThongTin_Load;
            PanelDanhMuc.ResumeLayout(false);
            PanelDanhMuc.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbDanhMucSP;
        private Panel PanelDanhMuc;
        private Label lbMaNV;
        private TextBox txbMaNV;
        private DateTimePicker dpNgaySinh;
        private Label lbNgaySinh;
        private TextBox txbTenNV;
        private Label lbTenNV;
        private TextBox txbMK;
        private Label lbMK;
        private TextBox txbTK;
        private Label lbTK;
        private TextBox txbSDT;
        private Label lbSDT;
        private RadioButton rbNu;
        private RadioButton rbNam;
        private Label lbGioiTinh;
    }
}