namespace QuanLyQuanTraSua.GUI
{
    partial class FormQuanLyDanhMuc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuanLyDanhMuc));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            lbDanhMucSP = new Label();
            PanelDanhMuc = new Panel();
            lbTimKiem = new Label();
            btThemDanhMuc = new Button();
            txbTenDanhMuc = new TextBox();
            dgvDanhMuc = new DataGridView();
            MaDanhMuc = new DataGridViewTextBoxColumn();
            TenDanhMuc = new DataGridViewTextBoxColumn();
            btSuaDanhMuc = new Button();
            lbTenDanhMuc = new Label();
            btXoaDanhMuc = new Button();
            txbTimKiem = new TextBox();
            txbMaDanhMuc = new TextBox();
            lbMaDanhMuc = new Label();
            PanelDanhMuc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhMuc).BeginInit();
            SuspendLayout();
            // 
            // lbDanhMucSP
            // 
            lbDanhMucSP.AutoSize = true;
            lbDanhMucSP.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbDanhMucSP.ForeColor = SystemColors.ActiveCaptionText;
            lbDanhMucSP.Location = new Point(98, 18);
            lbDanhMucSP.Name = "lbDanhMucSP";
            lbDanhMucSP.Size = new Size(332, 38);
            lbDanhMucSP.TabIndex = 0;
            lbDanhMucSP.Text = "DANH MỤC SẢN PHẨM";
            // 
            // PanelDanhMuc
            // 
            PanelDanhMuc.BackColor = Color.White;
            PanelDanhMuc.BorderStyle = BorderStyle.FixedSingle;
            PanelDanhMuc.Controls.Add(lbTimKiem);
            PanelDanhMuc.Controls.Add(btThemDanhMuc);
            PanelDanhMuc.Controls.Add(txbTenDanhMuc);
            PanelDanhMuc.Controls.Add(dgvDanhMuc);
            PanelDanhMuc.Controls.Add(btSuaDanhMuc);
            PanelDanhMuc.Controls.Add(lbTenDanhMuc);
            PanelDanhMuc.Controls.Add(btXoaDanhMuc);
            PanelDanhMuc.Controls.Add(txbTimKiem);
            PanelDanhMuc.Controls.Add(txbMaDanhMuc);
            PanelDanhMuc.Controls.Add(lbMaDanhMuc);
            PanelDanhMuc.Location = new Point(12, 76);
            PanelDanhMuc.Name = "PanelDanhMuc";
            PanelDanhMuc.Size = new Size(503, 438);
            PanelDanhMuc.TabIndex = 1;
            // 
            // lbTimKiem
            // 
            lbTimKiem.AutoSize = true;
            lbTimKiem.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbTimKiem.Location = new Point(33, 17);
            lbTimKiem.Name = "lbTimKiem";
            lbTimKiem.Size = new Size(83, 23);
            lbTimKiem.TabIndex = 8;
            lbTimKiem.Text = "Tìm kiếm:";
            // 
            // btThemDanhMuc
            // 
            btThemDanhMuc.BackgroundImage = (Image)resources.GetObject("btThemDanhMuc.BackgroundImage");
            btThemDanhMuc.BackgroundImageLayout = ImageLayout.Stretch;
            btThemDanhMuc.Cursor = Cursors.Hand;
            btThemDanhMuc.FlatAppearance.BorderSize = 0;
            btThemDanhMuc.FlatStyle = FlatStyle.Flat;
            btThemDanhMuc.Location = new Point(301, 379);
            btThemDanhMuc.Name = "btThemDanhMuc";
            btThemDanhMuc.Size = new Size(46, 41);
            btThemDanhMuc.TabIndex = 7;
            btThemDanhMuc.UseVisualStyleBackColor = true;
            btThemDanhMuc.Click += btThemDanhMuc_Click;
            // 
            // txbTenDanhMuc
            // 
            txbTenDanhMuc.Location = new Point(217, 336);
            txbTenDanhMuc.Name = "txbTenDanhMuc";
            txbTenDanhMuc.Size = new Size(270, 27);
            txbTenDanhMuc.TabIndex = 8;
            // 
            // dgvDanhMuc
            // 
            dgvDanhMuc.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDanhMuc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDanhMuc.ColumnHeadersHeight = 29;
            dgvDanhMuc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvDanhMuc.Columns.AddRange(new DataGridViewColumn[] { MaDanhMuc, TenDanhMuc });
            dgvDanhMuc.EnableHeadersVisualStyles = false;
            dgvDanhMuc.Location = new Point(-1, 58);
            dgvDanhMuc.Name = "dgvDanhMuc";
            dgvDanhMuc.RowHeadersWidth = 51;
            dgvDanhMuc.RowTemplate.Height = 29;
            dgvDanhMuc.Size = new Size(503, 240);
            dgvDanhMuc.TabIndex = 4;
            dgvDanhMuc.CellClick += dgvDanhMuc_CellClick;
            // 
            // MaDanhMuc
            // 
            MaDanhMuc.DataPropertyName = "MaDanhMuc";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            MaDanhMuc.DefaultCellStyle = dataGridViewCellStyle2;
            MaDanhMuc.FillWeight = 6.41711426F;
            MaDanhMuc.HeaderText = "Mã danh mục";
            MaDanhMuc.MinimumWidth = 6;
            MaDanhMuc.Name = "MaDanhMuc";
            MaDanhMuc.Width = 200;
            // 
            // TenDanhMuc
            // 
            TenDanhMuc.DataPropertyName = "TenDanhMuc";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            TenDanhMuc.DefaultCellStyle = dataGridViewCellStyle3;
            TenDanhMuc.FillWeight = 193.582886F;
            TenDanhMuc.HeaderText = "Tên danh mục";
            TenDanhMuc.MinimumWidth = 6;
            TenDanhMuc.Name = "TenDanhMuc";
            TenDanhMuc.Width = 250;
            // 
            // btSuaDanhMuc
            // 
            btSuaDanhMuc.BackgroundImage = (Image)resources.GetObject("btSuaDanhMuc.BackgroundImage");
            btSuaDanhMuc.BackgroundImageLayout = ImageLayout.Stretch;
            btSuaDanhMuc.Cursor = Cursors.Hand;
            btSuaDanhMuc.FlatAppearance.BorderSize = 0;
            btSuaDanhMuc.FlatStyle = FlatStyle.Flat;
            btSuaDanhMuc.Location = new Point(371, 379);
            btSuaDanhMuc.Name = "btSuaDanhMuc";
            btSuaDanhMuc.Size = new Size(46, 41);
            btSuaDanhMuc.TabIndex = 6;
            btSuaDanhMuc.UseVisualStyleBackColor = true;
            btSuaDanhMuc.Click += btSuaDanhMuc_Click;
            // 
            // lbTenDanhMuc
            // 
            lbTenDanhMuc.AutoSize = true;
            lbTenDanhMuc.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbTenDanhMuc.Location = new Point(212, 310);
            lbTenDanhMuc.Name = "lbTenDanhMuc";
            lbTenDanhMuc.Size = new Size(122, 23);
            lbTenDanhMuc.TabIndex = 1;
            lbTenDanhMuc.Text = "Tên danh mục:";
            // 
            // btXoaDanhMuc
            // 
            btXoaDanhMuc.BackgroundImage = (Image)resources.GetObject("btXoaDanhMuc.BackgroundImage");
            btXoaDanhMuc.BackgroundImageLayout = ImageLayout.Stretch;
            btXoaDanhMuc.Cursor = Cursors.Hand;
            btXoaDanhMuc.FlatAppearance.BorderSize = 0;
            btXoaDanhMuc.FlatStyle = FlatStyle.Flat;
            btXoaDanhMuc.Location = new Point(441, 379);
            btXoaDanhMuc.Name = "btXoaDanhMuc";
            btXoaDanhMuc.Size = new Size(46, 41);
            btXoaDanhMuc.TabIndex = 5;
            btXoaDanhMuc.UseVisualStyleBackColor = true;
            btXoaDanhMuc.Click += btXoaDanhMuc_Click;
            // 
            // txbTimKiem
            // 
            txbTimKiem.Location = new Point(122, 13);
            txbTimKiem.Name = "txbTimKiem";
            txbTimKiem.Size = new Size(345, 27);
            txbTimKiem.TabIndex = 2;
            txbTimKiem.TextChanged += txbTimKiem_TextChanged;
            // 
            // txbMaDanhMuc
            // 
            txbMaDanhMuc.Location = new Point(12, 336);
            txbMaDanhMuc.Name = "txbMaDanhMuc";
            txbMaDanhMuc.Size = new Size(137, 27);
            txbMaDanhMuc.TabIndex = 3;
            // 
            // lbMaDanhMuc
            // 
            lbMaDanhMuc.AutoSize = true;
            lbMaDanhMuc.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbMaDanhMuc.Location = new Point(8, 310);
            lbMaDanhMuc.Name = "lbMaDanhMuc";
            lbMaDanhMuc.Size = new Size(120, 23);
            lbMaDanhMuc.TabIndex = 0;
            lbMaDanhMuc.Text = "Mã danh mục:";
            // 
            // FormQuanLyDanhMuc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(527, 542);
            ControlBox = false;
            Controls.Add(PanelDanhMuc);
            Controls.Add(lbDanhMucSP);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormQuanLyDanhMuc";
            StartPosition = FormStartPosition.Manual;
            FormClosed += FormQuanLyDanhMuc_FormClosed;
            Load += FormQuanLyDanhMuc_Load;
            PanelDanhMuc.ResumeLayout(false);
            PanelDanhMuc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhMuc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbDanhMucSP;
        private Panel PanelDanhMuc;
        private DataGridView dgvDanhMuc;
        private TextBox txbTimKiem;
        private TextBox txbMaDanhMuc;
        private Label lbTenDanhMuc;
        private Label lbMaDanhMuc;
        private Button btThemDanhMuc;
        private Button btSuaDanhMuc;
        private Button btXoaDanhMuc;
        private Label lbTimKiem;
        private TextBox txbTenDanhMuc;
        private DataGridViewTextBoxColumn MaDanhMuc;
        private DataGridViewTextBoxColumn TenDanhMuc;
    }
}