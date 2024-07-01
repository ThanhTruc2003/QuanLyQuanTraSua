using BLL;
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace QuanLyQuanTraSua.GUI
{
    public partial class FormSuaTaiKhoan : Form
    {
        public string MaTaiKhoan { get; set; }
        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public string LoaiTaiKhoan { get; set; }
        public string MaNhanVien { get; set; }

        private TaiKhoanBLL taikhoanBLL;

        public FormSuaTaiKhoan()
        {
            InitializeComponent();
        }

        private void FormSuaTaiKhoan_Load(object sender, EventArgs e)
        {
            txbMaTaiKhoan.Text = MaTaiKhoan;
            txbTaiKhoan.Text = TaiKhoan;
            txbMatKhau.Text = MatKhau;
            cbLoaiTaiKhoan.Text = LoaiTaiKhoan;
            txbMaNhanVien.Text = MaNhanVien;

            cbLoaiTaiKhoan.Enabled = false;
        }

        private void bt_Sua_Click(object sender, EventArgs e)
        {
            taikhoanBLL = new TaiKhoanBLL();
            if (txbMaTaiKhoan.Text == "" || txbTaiKhoan.Text == "" || txbMatKhau.Text == "" || cbLoaiTaiKhoan.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                bool isSuccess = taikhoanBLL.Update(new TaiKhoanDTO(txbMaTaiKhoan.Text, txbTaiKhoan.Text, txbMatKhau.Text, cbLoaiTaiKhoan.Text, txbMaNhanVien.Text));
                if (isSuccess)
                {
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
