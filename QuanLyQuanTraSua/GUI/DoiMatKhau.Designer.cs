namespace QuanLyQuanTraSua.GUI
{
    partial class FormDoiMatKhau
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
            btnChangePassword = new Button();
            lbCurrentPassword = new Label();
            txtNewPassword = new TextBox();
            txtCurrentPassword = new TextBox();
            lbNewPassword = new Label();
            PanelDanhMuc.SuspendLayout();
            SuspendLayout();
            // 
            // lbDanhMucSP
            // 
            lbDanhMucSP.AutoSize = true;
            lbDanhMucSP.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbDanhMucSP.ForeColor = SystemColors.ActiveCaptionText;
            lbDanhMucSP.Location = new Point(150, 24);
            lbDanhMucSP.Name = "lbDanhMucSP";
            lbDanhMucSP.Size = new Size(226, 38);
            lbDanhMucSP.TabIndex = 1;
            lbDanhMucSP.Text = "ĐỔI MẬT KHẨU";
            // 
            // PanelDanhMuc
            // 
            PanelDanhMuc.BackColor = Color.White;
            PanelDanhMuc.BorderStyle = BorderStyle.FixedSingle;
            PanelDanhMuc.Controls.Add(btnChangePassword);
            PanelDanhMuc.Controls.Add(lbCurrentPassword);
            PanelDanhMuc.Controls.Add(txtNewPassword);
            PanelDanhMuc.Controls.Add(txtCurrentPassword);
            PanelDanhMuc.Controls.Add(lbNewPassword);
            PanelDanhMuc.Location = new Point(14, 77);
            PanelDanhMuc.Name = "PanelDanhMuc";
            PanelDanhMuc.Size = new Size(503, 167);
            PanelDanhMuc.TabIndex = 2;
            // 
            // btnChangePassword
            // 
            btnChangePassword.Cursor = Cursors.Hand;
            btnChangePassword.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            btnChangePassword.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            btnChangePassword.FlatStyle = FlatStyle.Flat;
            btnChangePassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnChangePassword.Location = new Point(356, 109);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(131, 39);
            btnChangePassword.TabIndex = 9;
            btnChangePassword.Text = "Đổi mật khẩu";
            btnChangePassword.UseVisualStyleBackColor = true;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // lbCurrentPassword
            // 
            lbCurrentPassword.AutoSize = true;
            lbCurrentPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbCurrentPassword.Location = new Point(12, 17);
            lbCurrentPassword.Name = "lbCurrentPassword";
            lbCurrentPassword.Size = new Size(148, 23);
            lbCurrentPassword.TabIndex = 8;
            lbCurrentPassword.Text = "Mật khẩu hiện tại:";
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(166, 64);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(321, 27);
            txtNewPassword.TabIndex = 8;
            // 
            // txtCurrentPassword
            // 
            txtCurrentPassword.Location = new Point(166, 13);
            txtCurrentPassword.Name = "txtCurrentPassword";
            txtCurrentPassword.Size = new Size(321, 27);
            txtCurrentPassword.TabIndex = 2;
            // 
            // lbNewPassword
            // 
            lbNewPassword.AutoSize = true;
            lbNewPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbNewPassword.Location = new Point(12, 68);
            lbNewPassword.Name = "lbNewPassword";
            lbNewPassword.Size = new Size(120, 23);
            lbNewPassword.TabIndex = 0;
            lbNewPassword.Text = "Mật khẩu mới:";
            // 
            // FormDoiMatKhau
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(529, 279);
            ControlBox = false;
            Controls.Add(PanelDanhMuc);
            Controls.Add(lbDanhMucSP);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormDoiMatKhau";
            StartPosition = FormStartPosition.Manual;
            Text = "Đổi mật khẩu";
            PanelDanhMuc.ResumeLayout(false);
            PanelDanhMuc.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbDanhMucSP;
        private Panel PanelDanhMuc;
        private Button btnChangePassword;
        private Label lbCurrentPassword;
        private TextBox txtNewPassword;
        private TextBox txtCurrentPassword;
        private Label lbNewPassword;
    }
}