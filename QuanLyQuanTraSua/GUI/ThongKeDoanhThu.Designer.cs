namespace QuanLyQuanTraSua.GUI
{
    partial class FormThongKe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThongKe));
            cbMonth = new ComboBox();
            lbSelectThang = new Label();
            cbYear = new ComboBox();
            label2 = new Label();
            ptNoData = new PictureBox();
            cbSelectType = new ComboBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)ptNoData).BeginInit();
            SuspendLayout();
            // 
            // cbMonth
            // 
            cbMonth.Cursor = Cursors.Hand;
            cbMonth.FormattingEnabled = true;
            cbMonth.Location = new Point(905, 32);
            cbMonth.Name = "cbMonth";
            cbMonth.Size = new Size(91, 28);
            cbMonth.TabIndex = 0;
            cbMonth.SelectedIndexChanged += cbMonth_SelectedIndexChanged;
            // 
            // lbSelectThang
            // 
            lbSelectThang.AutoSize = true;
            lbSelectThang.BackColor = Color.White;
            lbSelectThang.Location = new Point(905, 9);
            lbSelectThang.Name = "lbSelectThang";
            lbSelectThang.Size = new Size(50, 20);
            lbSelectThang.TabIndex = 1;
            lbSelectThang.Text = "Tháng";
            // 
            // cbYear
            // 
            cbYear.Cursor = Cursors.Hand;
            cbYear.FormattingEnabled = true;
            cbYear.Location = new Point(1021, 32);
            cbYear.Name = "cbYear";
            cbYear.Size = new Size(82, 28);
            cbYear.TabIndex = 0;
            cbYear.SelectedIndexChanged += cbYear_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(1021, 9);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 1;
            label2.Text = "Năm";
            // 
            // ptNoData
            // 
            ptNoData.Dock = DockStyle.Fill;
            ptNoData.ErrorImage = (Image)resources.GetObject("ptNoData.ErrorImage");
            ptNoData.Image = (Image)resources.GetObject("ptNoData.Image");
            ptNoData.Location = new Point(0, 0);
            ptNoData.Name = "ptNoData";
            ptNoData.Size = new Size(1255, 531);
            ptNoData.SizeMode = PictureBoxSizeMode.StretchImage;
            ptNoData.TabIndex = 2;
            ptNoData.TabStop = false;
            // 
            // cbSelectType
            // 
            cbSelectType.Cursor = Cursors.Hand;
            cbSelectType.FormattingEnabled = true;
            cbSelectType.Location = new Point(1129, 32);
            cbSelectType.Name = "cbSelectType";
            cbSelectType.Size = new Size(91, 28);
            cbSelectType.TabIndex = 0;
            cbSelectType.SelectedIndexChanged += cbType_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(1129, 9);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 1;
            label3.Text = "Loại ";
            // 
            // FormThongKe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1255, 531);
            ControlBox = false;
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(lbSelectThang);
            Controls.Add(cbYear);
            Controls.Add(cbSelectType);
            Controls.Add(cbMonth);
            Controls.Add(ptNoData);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormThongKe";
            WindowState = FormWindowState.Maximized;
            Load += FormThongKe_Load;
            ((System.ComponentModel.ISupportInitialize)ptNoData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbMonth;
        private Label lbSelectThang;
        private ComboBox cbYear;
        private Label label2;
        private PictureBox ptNoData;
        private ComboBox cbSelectType;
        private Label label3;
    }
}