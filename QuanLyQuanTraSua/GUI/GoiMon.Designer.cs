namespace QuanLyQuanTraSua.GUI
{
    partial class FormGoiMon
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
            panel1 = new Panel();
            gbTimKiem = new GroupBox();
            txbTenMon = new TextBox();
            lbTimKiemMon = new Label();
            cbDanhMuc = new ComboBox();
            lbTimKiemTheoDanhMuc = new Label();
            Menu = new FlowLayoutPanel();
            gbTimKiem.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(822, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(421, 460);
            panel1.TabIndex = 1;
            // 
            // gbTimKiem
            // 
            gbTimKiem.Controls.Add(txbTenMon);
            gbTimKiem.Controls.Add(lbTimKiemMon);
            gbTimKiem.Controls.Add(cbDanhMuc);
            gbTimKiem.Controls.Add(lbTimKiemTheoDanhMuc);
            gbTimKiem.Location = new Point(2, 12);
            gbTimKiem.Name = "gbTimKiem";
            gbTimKiem.Size = new Size(801, 78);
            gbTimKiem.TabIndex = 1;
            gbTimKiem.TabStop = false;
            gbTimKiem.Text = "Tìm kiếm";
            // 
            // txbTenMon
            // 
            txbTenMon.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txbTenMon.ForeColor = SystemColors.ControlText;
            txbTenMon.Location = new Point(525, 37);
            txbTenMon.Name = "txbTenMon";
            txbTenMon.Size = new Size(235, 27);
            txbTenMon.TabIndex = 3;
            txbTenMon.TextChanged += txbTenMon_TextChanged;
            // 
            // lbTimKiemMon
            // 
            lbTimKiemMon.AutoSize = true;
            lbTimKiemMon.Location = new Point(412, 39);
            lbTimKiemMon.Name = "lbTimKiemMon";
            lbTimKiemMon.Size = new Size(107, 20);
            lbTimKiemMon.TabIndex = 2;
            lbTimKiemMon.Text = "Tìm kiếm món:";
            // 
            // cbDanhMuc
            // 
            cbDanhMuc.Cursor = Cursors.Hand;
            cbDanhMuc.FormattingEnabled = true;
            cbDanhMuc.Items.AddRange(new object[] { "Tất cả" });
            cbDanhMuc.Location = new Point(188, 37);
            cbDanhMuc.Name = "cbDanhMuc";
            cbDanhMuc.Size = new Size(183, 28);
            cbDanhMuc.TabIndex = 1;
            cbDanhMuc.SelectedIndexChanged += cbDanhMuc_SelectedIndexChanged;
            // 
            // lbTimKiemTheoDanhMuc
            // 
            lbTimKiemTheoDanhMuc.AutoSize = true;
            lbTimKiemTheoDanhMuc.Location = new Point(6, 39);
            lbTimKiemTheoDanhMuc.Name = "lbTimKiemTheoDanhMuc";
            lbTimKiemTheoDanhMuc.Size = new Size(176, 20);
            lbTimKiemTheoDanhMuc.TabIndex = 0;
            lbTimKiemTheoDanhMuc.Text = "Tìm kiếm theo danh mục:\r\n";
            // 
            // Menu
            // 
            Menu.AutoScroll = true;
            Menu.BorderStyle = BorderStyle.Fixed3D;
            Menu.Location = new Point(2, 131);
            Menu.Name = "Menu";
            Menu.Size = new Size(801, 400);
            Menu.TabIndex = 2;
            // 
            // FormGoiMon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(1255, 531);
            ControlBox = false;
            Controls.Add(Menu);
            Controls.Add(gbTimKiem);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormGoiMon";
            WindowState = FormWindowState.Maximized;
            Load += FormGoiMon_Load;
            gbTimKiem.ResumeLayout(false);
            gbTimKiem.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private GroupBox gbTimKiem;
        private ComboBox cbDanhMuc;
        private Label lbTimKiemTheoDanhMuc;
        private TextBox txbTenMon;
        private Label lbTimKiemMon;
        private FlowLayoutPanel Menu;
    }
}