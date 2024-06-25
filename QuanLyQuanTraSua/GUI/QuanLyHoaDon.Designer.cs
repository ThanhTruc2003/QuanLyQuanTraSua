namespace QuanLyQuanTraSua.GUI
{
    partial class FormQuanLyHoaDon
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
            dgvHoaDon = new DataGridView();
            txbTimKiemHoaDon = new TextBox();
            lbTimKiemNV = new Label();
            lbDanhSachNV = new Label();
            buttonXemChiTiet = new Button();
            MaHoaDon = new DataGridViewTextBoxColumn();
            NguoiLapHoaDon = new DataGridViewTextBoxColumn();
            NgayLapHoaDon = new DataGridViewTextBoxColumn();
            TongTien = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).BeginInit();
            SuspendLayout();
            // 
            // dgvHoaDon
            // 
            dgvHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHoaDon.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvHoaDon.ColumnHeadersHeight = 29;
            dgvHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvHoaDon.Columns.AddRange(new DataGridViewColumn[] { MaHoaDon, NguoiLapHoaDon, NgayLapHoaDon, TongTien });
            dgvHoaDon.EnableHeadersVisualStyles = false;
            dgvHoaDon.Location = new Point(12, 87);
            dgvHoaDon.Name = "dgvHoaDon";
            dgvHoaDon.RowHeadersWidth = 51;
            dgvHoaDon.RowTemplate.Height = 29;
            dgvHoaDon.Size = new Size(1225, 340);
            dgvHoaDon.TabIndex = 9;
            // 
            // txbTimKiemHoaDon
            // 
            txbTimKiemHoaDon.Location = new Point(929, 41);
            txbTimKiemHoaDon.Name = "txbTimKiemHoaDon";
            txbTimKiemHoaDon.Size = new Size(308, 27);
            txbTimKiemHoaDon.TabIndex = 8;
            txbTimKiemHoaDon.TextChanged += txbTimKiemHoaDon_TextChanged;
            // 
            // lbTimKiemNV
            // 
            lbTimKiemNV.AutoSize = true;
            lbTimKiemNV.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbTimKiemNV.Location = new Point(926, 12);
            lbTimKiemNV.Name = "lbTimKiemNV";
            lbTimKiemNV.Size = new Size(157, 20);
            lbTimKiemNV.TabIndex = 7;
            lbTimKiemNV.Text = "Tìm kiếm mã hóa đơn";
            // 
            // lbDanhSachNV
            // 
            lbDanhSachNV.AutoSize = true;
            lbDanhSachNV.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbDanhSachNV.Location = new Point(12, 43);
            lbDanhSachNV.Name = "lbDanhSachNV";
            lbDanhSachNV.Size = new Size(211, 25);
            lbDanhSachNV.TabIndex = 6;
            lbDanhSachNV.Text = "DANH SÁCH HÓA ĐƠN";
            // 
            // buttonXemChiTiet
            // 
            buttonXemChiTiet.Cursor = Cursors.Hand;
            buttonXemChiTiet.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonXemChiTiet.Location = new Point(1066, 435);
            buttonXemChiTiet.Name = "buttonXemChiTiet";
            buttonXemChiTiet.Size = new Size(171, 41);
            buttonXemChiTiet.TabIndex = 10;
            buttonXemChiTiet.Text = "Xem chi tiết";
            buttonXemChiTiet.UseVisualStyleBackColor = true;
            buttonXemChiTiet.Click += buttonXemChiTiet_Click;
            // 
            // MaHoaDon
            // 
            MaHoaDon.DataPropertyName = "MaHoaDon";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            MaHoaDon.DefaultCellStyle = dataGridViewCellStyle2;
            MaHoaDon.HeaderText = "Mã hóa đơn";
            MaHoaDon.MinimumWidth = 6;
            MaHoaDon.Name = "MaHoaDon";
            // 
            // NguoiLapHoaDon
            // 
            NguoiLapHoaDon.DataPropertyName = "NguoiLapHoaDon";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            NguoiLapHoaDon.DefaultCellStyle = dataGridViewCellStyle3;
            NguoiLapHoaDon.HeaderText = "Người lập hóa đơn";
            NguoiLapHoaDon.MinimumWidth = 6;
            NguoiLapHoaDon.Name = "NguoiLapHoaDon";
            // 
            // NgayLapHoaDon
            // 
            NgayLapHoaDon.DataPropertyName = "NgayLapHoaDon";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "dd/MM/yyyy HH:mm";
            dataGridViewCellStyle4.NullValue = null;
            NgayLapHoaDon.DefaultCellStyle = dataGridViewCellStyle4;
            NgayLapHoaDon.HeaderText = "Ngày";
            NgayLapHoaDon.MinimumWidth = 6;
            NgayLapHoaDon.Name = "NgayLapHoaDon";
            // 
            // TongTien
            // 
            TongTien.DataPropertyName = "TongTien";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            TongTien.DefaultCellStyle = dataGridViewCellStyle5;
            TongTien.HeaderText = "Tổng tiền";
            TongTien.MinimumWidth = 6;
            TongTien.Name = "TongTien";
            TongTien.Resizable = DataGridViewTriState.True;
            // 
            // FormQuanLyHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(1248, 485);
            ControlBox = false;
            Controls.Add(buttonXemChiTiet);
            Controls.Add(dgvHoaDon);
            Controls.Add(txbTimKiemHoaDon);
            Controls.Add(lbTimKiemNV);
            Controls.Add(lbDanhSachNV);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormQuanLyHoaDon";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            Load += FormQuanLyHoaDon_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvHoaDon;
        private TextBox txbTimKiemHoaDon;
        private Label lbTimKiemNV;
        private Label lbDanhSachNV;
        private Button buttonXemChiTiet;
        private DataGridViewTextBoxColumn MaHoaDon;
        private DataGridViewTextBoxColumn NguoiLapHoaDon;
        private DataGridViewTextBoxColumn NgayLapHoaDon;
        private DataGridViewTextBoxColumn TongTien;
    }
}