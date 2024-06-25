using BLL;
using DAL;
using DTO;
using QuanLyQuanTraSua.BLL;
using QuanLyQuanTraSua.DTO;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace QuanLyQuanTraSua.GUI
{
    public partial class FormGoiMon : Form
    {
        private DanhMucSanPhamBLL danhmucSanPhambll;
        private SanPhamBLL sanPhamBLL;
        private HoaDonBLL hoaDonBLL;
        private ChiTietHoaDonBLL chiTietHoaDonBLL;

        public FormGoiMon()
        {
            InitializeComponent();
        }

        private void FormGoiMon_Load(object sender, EventArgs e)
        {
            danhmucSanPhambll = new DanhMucSanPhamBLL();
            var cb_dt = danhmucSanPhambll.getData();
            DataRow newRow = cb_dt.NewRow();
            newRow["MaDanhMuc"] = "";
            newRow["TenDanhMuc"] = "Tất cả";
            cb_dt.Rows.InsertAt(newRow, 0);
            cbDanhMuc.DataSource = cb_dt;
            cbDanhMuc.ValueMember = "MaDanhMuc";
            cbDanhMuc.DisplayMember = "TenDanhMuc";
            cbDanhMuc.SelectedIndex = -1;
            LoadProducts("");
        }

        private void LoadProducts(string maDanhMuc)
        {
            sanPhamBLL = new SanPhamBLL();
            DataTable SP;
            if (maDanhMuc == "")
            {
                SP = sanPhamBLL.getAllProduct();
            }
            else
            {
                SP = sanPhamBLL.getProduct(maDanhMuc);
            }

            Menu.Controls.Clear();

            foreach (DataRow row in SP.Rows)
            {
                Panel panel = CreateProductPanel(row);
                Menu.Controls.Add(panel);
                Menu.AutoScroll = true;
            }
        }

        private Panel CreateProductPanel(DataRow product)
        {
            Panel panel = new Panel();
            panel.Size = new Size(378, 108);
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Cursor = Cursors.Hand;
            panel.MouseEnter += (sender, e) =>
            {
                Panel MouseEnterPanel = sender as Panel;
                MouseEnterPanel.BackColor = Color.MistyRose;
            };

            panel.MouseLeave += (sender, e) =>
            {
                Panel MouseLeavePanel = sender as Panel;
                MouseLeavePanel.BackColor = Color.Snow;
            };

            panel.Click += (sender, e) =>
            {
                string productName = product["TenSanPham"].ToString();
                string price = product["DonGia"].ToString();
                string size = product["Size"].ToString();
                string maSP = product["MaSanPham"].ToString();

                txbTenMon1.Text = productName;
                txbDonGia.Text = price + ' ' + 'đ';
                txbSize.Text = size;
                lbMaSanPham.Text = maSP;
            };

            PictureBox pictureBox = new PictureBox();
            pictureBox.Size = new Size(90, 76);
            pictureBox.Location = new Point(22, 16);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            if (product["HinhAnh"] != DBNull.Value)
            {
                string imagePath = Path.Combine(Application.StartupPath, "Images", product["HinhAnh"].ToString());
                if (File.Exists(imagePath))
                {
                    pictureBox.Image = Image.FromFile(imagePath);
                }
            }

            Label MaSPinPanel = new Label();
            MaSPinPanel.Text = product["MaSanPham"].ToString();
            MaSPinPanel.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            MaSPinPanel.Location = new Point(129, 16);
            MaSPinPanel.Size = new Size(231, 23);
            MaSPinPanel.Visible = false;

            Label nameLabel = new Label();
            nameLabel.Text = product["TenSanPham"].ToString();
            nameLabel.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            nameLabel.Location = new Point(129, 16);
            nameLabel.Size = new Size(231, 23);

            Label priceLabel = new Label();
            priceLabel.Text = product["DonGia"].ToString() + ' ' + 'đ';
            priceLabel.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            priceLabel.ForeColor = Color.Red;
            priceLabel.Location = new Point(130, 69);

            Label sizeLabel = new Label();
            sizeLabel.Text = "Size " + product["Size"].ToString();
            sizeLabel.Font = new Font("Segoe UI", 8, FontStyle.Regular);
            sizeLabel.ForeColor = Color.Gray;
            sizeLabel.Location = new Point(130, 39);

            panel.Controls.Add(nameLabel);
            panel.Controls.Add(priceLabel);
            panel.Controls.Add(pictureBox);
            panel.Controls.Add(sizeLabel);
            panel.Controls.Add(MaSPinPanel);

            return panel;
        }

        private void cbDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDanhMuc.SelectedIndex == -1 || cbDanhMuc.SelectedItem.ToString() == "")
            {
                LoadProducts("");
            }
            else
            {
                string maDanhMuc = cbDanhMuc.SelectedValue.ToString();
                LoadProducts(maDanhMuc);
            }
        }

        private void txbTenMon_TextChanged(object sender, EventArgs e)
        {
            string sreachText = txbTenMon.Text.Trim();
            foreach (Panel panel in Menu.Controls)
            {
                if (panel != null)
                {
                    Label nameLabel = panel.Controls[0] as Label;
                    if (nameLabel != null)
                    {
                        string productName = nameLabel.Text;
                        panel.Visible = productName.ToLower().Contains(sreachText.ToLower());
                    }
                }
            }
        }

        private void UpdateTotalMoney()
        {
            decimal totalMoney = 0;

            foreach (DataGridViewRow row in dgvCapNhatMon.Rows)
            {
                if (row.Cells["DonGia"].Value != null && row.Cells["SoLuong"].Value != null)
                {
                    decimal donGia = Convert.ToDecimal(row.Cells["DonGia"].Value.ToString().Replace(" đ", ""));
                    int soLuong = Convert.ToInt32(row.Cells["SoLuong"].Value);
                    totalMoney += donGia * soLuong;
                }
            }

            txbTongTien.Text = totalMoney.ToString() + " đ";
        }


        private void btThemMon_Click(object sender, EventArgs e)
        {
            string maSP = lbMaSanPham.Text;
            string tenMon = txbTenMon1.Text;
            string donGia = txbDonGia.Text;
            string size = txbSize.Text;
            int soLuong = (int)nUDSoLuong.Value;

            if (tenMon != "" && donGia != "" && size != "")
            {
                dgvCapNhatMon.Rows.Add(maSP, tenMon, soLuong, donGia, size);
                txbTenMon1.Clear();
                txbDonGia.Clear();
                txbSize.Clear();
                nUDSoLuong.Value = 1;

                UpdateTotalMoney();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn món", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvCapNhatMon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selected = dgvCapNhatMon.Rows[index];
            lbMaSanPham.Text = selected.Cells[0].Value.ToString();
            txbTenMon1.Text = selected.Cells[1].Value.ToString();
            nUDSoLuong.Value = decimal.Parse(selected.Cells[2].Value.ToString());
            txbDonGia.Text = selected.Cells[3].Value.ToString();
            txbSize.Text = selected.Cells[4].Value.ToString();
        }

        private void btSuaMon_Click(object sender, EventArgs e)
        {
            if (dgvCapNhatMon.SelectedCells.Count > 0)
            {
                int selectedIndex = dgvCapNhatMon.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvCapNhatMon.Rows[selectedIndex];

                string tenMon = txbTenMon1.Text;
                string donGia = txbDonGia.Text;
                string size = txbSize.Text;
                int soLuong = (int)nUDSoLuong.Value;

                if (!string.IsNullOrEmpty(tenMon) && !string.IsNullOrEmpty(donGia) && !string.IsNullOrEmpty(size))
                {
                    selectedRow.Cells["TenMon"].Value = tenMon;
                    selectedRow.Cells["SoLuong"].Value = soLuong;
                    selectedRow.Cells["DonGia"].Value = donGia;
                    selectedRow.Cells["Size"].Value = size;
                    MessageBox.Show("Cập nhật món thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txbTenMon1.Clear();
                    txbDonGia.Clear();
                    txbSize.Clear();
                    nUDSoLuong.Value = 1;
                    UpdateTotalMoney();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn món để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btXoaMon_Click(object sender, EventArgs e)
        {
            if (dgvCapNhatMon.SelectedCells.Count > 0)
            {
                int selectedIndex = dgvCapNhatMon.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvCapNhatMon.Rows[selectedIndex];

                DialogResult dialogResult = MessageBox.Show(
                    $"Bạn có chắc chắn muốn xóa món {selectedRow.Cells["TenMon"].Value.ToString()}?",
                    "Thông báo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    dgvCapNhatMon.Rows.RemoveAt(selectedIndex);
                    UpdateTotalMoney();
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn món để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btThanhToan_Click(object sender, EventArgs e)
        {
            hoaDonBLL = new HoaDonBLL();
            chiTietHoaDonBLL = new ChiTietHoaDonBLL();

            HoaDonDTO dto_hoadon = new HoaDonDTO();
            dto_hoadon.NguoiLapHoaDon = "2"; 
            dto_hoadon.NgayLapHoaDon = DateTime.Now;
            decimal tongTien = 0;

            List<ChiTietHoaDonDTO> chiTietHoaDonList = new List<ChiTietHoaDonDTO>();

            foreach (DataGridViewRow row in dgvCapNhatMon.Rows)
            {
                if (!row.IsNewRow && row.Cells["DonGia"].Value != null && row.Cells["SoLuong"].Value != null)
                {
                    decimal donGia = Convert.ToDecimal(row.Cells["DonGia"].Value.ToString().Replace(" đ", ""));
                    int soLuong = Convert.ToInt32(row.Cells["SoLuong"].Value);
                    tongTien += donGia * soLuong;

                    ChiTietHoaDonDTO chiTietHoaDon = new ChiTietHoaDonDTO();
                    chiTietHoaDon.MaSanPham = (row.Cells["MaSanPham"].Value.ToString());
                    chiTietHoaDon.SoLuong = soLuong;
                    chiTietHoaDon.DonGia = (int)donGia;

                    chiTietHoaDonList.Add(chiTietHoaDon);
                }
            }
            dto_hoadon.TongTien = tongTien;
            int maHoaDon = hoaDonBLL.Insert(dto_hoadon);
            if (maHoaDon > 0)
            {
                foreach (var chiTiet in chiTietHoaDonList)
                {
                    chiTiet.MaHoaDon = maHoaDon.ToString();
                }
                bool insertChiTietSuccess = chiTietHoaDonBLL.Insert(chiTietHoaDonList);
                if (insertChiTietSuccess)
                {
                    MessageBox.Show("Thanh toán thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvCapNhatMon.Rows.Clear();
                    txbTongTien.Clear(); 
                }
                else
                {
                    MessageBox.Show("Lưu chi tiết hóa đơn thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Thanh toán thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
