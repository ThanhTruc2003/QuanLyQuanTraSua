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
			label1 = new Label();
			txtNewPassword = new TextBox();
			flowLayoutPanel1 = new FlowLayoutPanel();
			flowLayoutPanel2 = new FlowLayoutPanel();
			flowLayoutPanel3 = new FlowLayoutPanel();
			label2 = new Label();
			txtCurrentPassword = new TextBox();
			flowLayoutPanel4 = new FlowLayoutPanel();
			btnChangePassword = new Button();
			flowLayoutPanel1.SuspendLayout();
			flowLayoutPanel2.SuspendLayout();
			flowLayoutPanel3.SuspendLayout();
			flowLayoutPanel4.SuspendLayout();
			SuspendLayout();
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			label1.BackColor = Color.Transparent;
			label1.Location = new Point(3, 0);
			label1.Name = "label1";
			label1.Size = new Size(123, 33);
			label1.TabIndex = 0;
			label1.Text = "Mật khẩu mới";
			label1.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// txtNewPassword
			// 
			txtNewPassword.Location = new Point(132, 3);
			txtNewPassword.Name = "txtNewPassword";
			txtNewPassword.PasswordChar = '*';
			txtNewPassword.Size = new Size(326, 27);
			txtNewPassword.TabIndex = 1;
			// 
			// flowLayoutPanel1
			// 
			flowLayoutPanel1.AutoSize = true;
			flowLayoutPanel1.Controls.Add(label1);
			flowLayoutPanel1.Controls.Add(txtNewPassword);
			flowLayoutPanel1.Location = new Point(32, 81);
			flowLayoutPanel1.Margin = new Padding(0, 16, 0, 0);
			flowLayoutPanel1.Name = "flowLayoutPanel1";
			flowLayoutPanel1.Size = new Size(461, 33);
			flowLayoutPanel1.TabIndex = 2;
			// 
			// flowLayoutPanel2
			// 
			flowLayoutPanel2.BackColor = Color.White;
			flowLayoutPanel2.Controls.Add(flowLayoutPanel3);
			flowLayoutPanel2.Controls.Add(flowLayoutPanel1);
			flowLayoutPanel2.Controls.Add(flowLayoutPanel4);
			flowLayoutPanel2.Dock = DockStyle.Fill;
			flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
			flowLayoutPanel2.Location = new Point(0, 0);
			flowLayoutPanel2.Margin = new Padding(32);
			flowLayoutPanel2.Name = "flowLayoutPanel2";
			flowLayoutPanel2.Padding = new Padding(32);
			flowLayoutPanel2.Size = new Size(800, 450);
			flowLayoutPanel2.TabIndex = 3;
			// 
			// flowLayoutPanel3
			// 
			flowLayoutPanel3.AutoSize = true;
			flowLayoutPanel3.Controls.Add(label2);
			flowLayoutPanel3.Controls.Add(txtCurrentPassword);
			flowLayoutPanel3.Location = new Point(32, 32);
			flowLayoutPanel3.Margin = new Padding(0);
			flowLayoutPanel3.Name = "flowLayoutPanel3";
			flowLayoutPanel3.Size = new Size(461, 33);
			flowLayoutPanel3.TabIndex = 2;
			// 
			// label2
			// 
			label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			label2.AutoSize = true;
			label2.BackColor = Color.Transparent;
			label2.Location = new Point(3, 0);
			label2.Name = "label2";
			label2.Size = new Size(123, 33);
			label2.TabIndex = 0;
			label2.Text = "Mật khẩu hiện tại";
			label2.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// txtCurrentPassword
			// 
			txtCurrentPassword.Location = new Point(132, 3);
			txtCurrentPassword.Name = "txtCurrentPassword";
			txtCurrentPassword.PasswordChar = '*';
			txtCurrentPassword.Size = new Size(326, 27);
			txtCurrentPassword.TabIndex = 1;
			// 
			// flowLayoutPanel4
			// 
			flowLayoutPanel4.Controls.Add(btnChangePassword);
			flowLayoutPanel4.FlowDirection = FlowDirection.RightToLeft;
			flowLayoutPanel4.Location = new Point(32, 130);
			flowLayoutPanel4.Margin = new Padding(0, 16, 0, 0);
			flowLayoutPanel4.Name = "flowLayoutPanel4";
			flowLayoutPanel4.Size = new Size(458, 40);
			flowLayoutPanel4.TabIndex = 3;
			// 
			// btnChangePassword
			// 
			btnChangePassword.AutoSize = true;
			btnChangePassword.Location = new Point(347, 3);
			btnChangePassword.Name = "btnChangePassword";
			btnChangePassword.Size = new Size(108, 30);
			btnChangePassword.TabIndex = 0;
			btnChangePassword.Text = "Đổi mật khẩu";
			btnChangePassword.UseVisualStyleBackColor = true;
			btnChangePassword.Click += btnChangePassword_Click;
			// 
			// FormDoiMatKhau
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ControlLightLight;
			ClientSize = new Size(800, 450);
			ControlBox = false;
			Controls.Add(flowLayoutPanel2);
			FormBorderStyle = FormBorderStyle.None;
			Name = "FormDoiMatKhau";
			Text = "Đổi mật khẩu";
			flowLayoutPanel1.ResumeLayout(false);
			flowLayoutPanel1.PerformLayout();
			flowLayoutPanel2.ResumeLayout(false);
			flowLayoutPanel2.PerformLayout();
			flowLayoutPanel3.ResumeLayout(false);
			flowLayoutPanel3.PerformLayout();
			flowLayoutPanel4.ResumeLayout(false);
			flowLayoutPanel4.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Label label1;
		private TextBox txtNewPassword;
		private FlowLayoutPanel flowLayoutPanel1;
		private FlowLayoutPanel flowLayoutPanel2;
		private FlowLayoutPanel flowLayoutPanel3;
		private Label label2;
		private TextBox txtCurrentPassword;
		private FlowLayoutPanel flowLayoutPanel4;
		private Button btnChangePassword;
	}
}