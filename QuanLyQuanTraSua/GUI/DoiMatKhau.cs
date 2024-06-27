using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanTraSua.GUI
{
    public partial class FormDoiMatKhau : Form
    {
        TaiKhoanBLL taiKhoanBLL = new TaiKhoanBLL();
        public FormDoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            try
            {
                if (taiKhoanBLL.changePassword(maTk: Authentication.loggedInUser.MaTaiKhoan, currentPassword: txtCurrentPassword.Text, newPassword: txtNewPassword.Text))
                {
                    MessageBox.Show("Đổi mật khẩu thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearInputs();
                }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void clearInputs()
        {
            txtCurrentPassword.Text = "";
            txtNewPassword.Text = "";
        }

        private void FormDoiMatKhau_Load(object sender, EventArgs e)
        {
            txtCurrentPassword.PasswordChar = '*';
            txtNewPassword.PasswordChar = '*';
        }
    }
}
