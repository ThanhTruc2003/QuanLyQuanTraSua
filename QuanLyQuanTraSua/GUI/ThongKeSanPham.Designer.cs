namespace QuanLyQuanTraSua.GUI
{
    partial class FormThongKeSanPham
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
            dgvSanPham = new DataGridView();
            Rank = new DataGridViewTextBoxColumn();
            MaSanPham = new DataGridViewTextBoxColumn();
            TenSanPham = new DataGridViewTextBoxColumn();
            SoLuongBanDuoc = new DataGridViewTextBoxColumn();
            label1 = new Label();
            dpStartDate = new DateTimePicker();
            dpEndDate = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            btnFilter = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
            SuspendLayout();
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
            dgvSanPham.Columns.AddRange(new DataGridViewColumn[] { Rank, MaSanPham, TenSanPham, SoLuongBanDuoc });
            dgvSanPham.EnableHeadersVisualStyles = false;
            dgvSanPham.Location = new Point(12, 133);
            dgvSanPham.Name = "dgvSanPham";
            dgvSanPham.RowHeadersWidth = 51;
            dgvSanPham.RowTemplate.Height = 60;
            dgvSanPham.Size = new Size(1231, 395);
            dgvSanPham.TabIndex = 5;
            // 
            // Rank
            // 
            Rank.DataPropertyName = "Rank";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Rank.DefaultCellStyle = dataGridViewCellStyle2;
            Rank.HeaderText = "Rank";
            Rank.MinimumWidth = 6;
            Rank.Name = "Rank";
            // 
            // MaSanPham
            // 
            MaSanPham.DataPropertyName = "MaSanPham";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            MaSanPham.DefaultCellStyle = dataGridViewCellStyle3;
            MaSanPham.HeaderText = "Mã sản phẩm";
            MaSanPham.MinimumWidth = 6;
            MaSanPham.Name = "MaSanPham";
            // 
            // TenSanPham
            // 
            TenSanPham.DataPropertyName = "TenSanPham";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            TenSanPham.DefaultCellStyle = dataGridViewCellStyle4;
            TenSanPham.HeaderText = "Tên sản phẩm";
            TenSanPham.MinimumWidth = 6;
            TenSanPham.Name = "TenSanPham";
            // 
            // SoLuongBanDuoc
            // 
            SoLuongBanDuoc.DataPropertyName = "SoLuongBanDuoc";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            SoLuongBanDuoc.DefaultCellStyle = dataGridViewCellStyle5;
            SoLuongBanDuoc.HeaderText = "Số lượng bán được";
            SoLuongBanDuoc.MinimumWidth = 6;
            SoLuongBanDuoc.Name = "SoLuongBanDuoc";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(-1, 24);
            label1.Name = "label1";
            label1.Size = new Size(1256, 42);
            label1.TabIndex = 6;
            label1.Text = "Thống kê sản phẩm bán chạy";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // dpStartDate
            // 
            dpStartDate.Cursor = Cursors.Hand;
            dpStartDate.Location = new Point(305, 88);
            dpStartDate.Name = "dpStartDate";
            dpStartDate.Size = new Size(140, 27);
            dpStartDate.TabIndex = 7;
            // 
            // dpEndDate
            // 
            dpEndDate.Cursor = Cursors.Hand;
            dpEndDate.Location = new Point(550, 88);
            dpEndDate.Name = "dpEndDate";
            dpEndDate.Size = new Size(140, 27);
            dpEndDate.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(228, 88);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 8;
            label2.Text = "Từ ngày";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(471, 88);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 8;
            label3.Text = "Đến ngày";
            // 
            // btnFilter
            // 
            btnFilter.Cursor = Cursors.Hand;
            btnFilter.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            btnFilter.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnFilter.Location = new Point(720, 78);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(105, 39);
            btnFilter.TabIndex = 9;
            btnFilter.Text = "Lọc";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // FormThongKeSanPham
            // 
            BackColor = Color.White;
            ClientSize = new Size(1255, 560);
            ControlBox = false;
            Controls.Add(btnFilter);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dpEndDate);
            Controls.Add(dpStartDate);
            Controls.Add(label1);
            Controls.Add(dgvSanPham);
            Name = "FormThongKeSanPham";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private DataGridView dgvSanPham;
        private Label label1;
        private DateTimePicker dpStartDate;
        private DateTimePicker dpEndDate;
        private Label label2;
        private Label label3;
        private Button btnFilter;
        private DataGridViewTextBoxColumn Rank;
        private DataGridViewTextBoxColumn MaSanPham;
        private DataGridViewTextBoxColumn TenSanPham;
        private DataGridViewTextBoxColumn SoLuongBanDuoc;
    }
}