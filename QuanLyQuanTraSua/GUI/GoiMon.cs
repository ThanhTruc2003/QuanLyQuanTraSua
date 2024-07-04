using BLL;
using DAL;
using DTO;
using QuanLyQuanTraSua.BLL;
using QuanLyQuanTraSua.DTO;
using QuanLyQuanTraSua.Helper;
using QuanLyQuanTraSua.Properties;
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
        private List<ChiTietHoaDonDTO> chiTietHoaDonList;
        private int maHoaDon;

        public FormGoiMon()
        {
            InitializeComponent();
            maHoaDon = maHoaDon;
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
                decimal price = Convert.ToInt32(product["DonGia"]);
                string size = product["Size"].ToString();
                string maSP = product["MaSanPham"].ToString();

                txbTenMon1.Text = productName;
                txbDonGia.Text = Currency.convertToVND(price).ToString().Replace(" ₫", "").Replace(",", "");
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
            decimal price = Convert.ToInt32(product["DonGia"]);
            priceLabel.Text = Currency.convertToVND(price).ToString().Replace(" ₫", "").Replace(",", "");
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
                    decimal donGia = Convert.ToDecimal(row.Cells["DonGia"].Value.ToString());
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
            if (index >= 0) 
            {
                DataGridViewRow selected = dgvCapNhatMon.Rows[index];

                if (selected.Cells[0].Value != null)
                {
                    lbMaSanPham.Text = selected.Cells[0].Value.ToString();
                }

                if (selected.Cells[1].Value != null)
                {
                    txbTenMon1.Text = selected.Cells[1].Value.ToString();
                }

                if (selected.Cells[2].Value != null)
                {
                    nUDSoLuong.Value = decimal.Parse(selected.Cells[2].Value.ToString());
                }

                if (selected.Cells[3].Value != null)
                {
                    txbDonGia.Text = selected.Cells[3].Value.ToString();
                }

                if (selected.Cells[4].Value != null)
                {
                    txbSize.Text = selected.Cells[4].Value.ToString();
                }
            }
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
            dto_hoadon.NguoiLapHoaDon = Authentication.loggedInUser.MaNhanVien;
            dto_hoadon.NgayLapHoaDon = DateTime.Now;
            decimal tongTien = 0;

            chiTietHoaDonList = new List<ChiTietHoaDonDTO>();

            foreach (DataGridViewRow row in dgvCapNhatMon.Rows)
            {
                if (!row.IsNewRow && row.Cells["DonGia"].Value != null && row.Cells["SoLuong"].Value != null)
                {
                    decimal donGia = Convert.ToDecimal(row.Cells["DonGia"].Value.ToString());
                    int soLuong = Convert.ToInt32(row.Cells["SoLuong"].Value);
                    tongTien += donGia * soLuong;

                    ChiTietHoaDonDTO chiTietHoaDon = new ChiTietHoaDonDTO();
                    chiTietHoaDon.MaSanPham = (row.Cells["MaSanPham"].Value.ToString());
                    chiTietHoaDon.SoLuong = soLuong;
                    chiTietHoaDon.DonGia = donGia;

                    chiTietHoaDonList.Add(chiTietHoaDon);
                }
            }
            dto_hoadon.TongTien = tongTien;
            maHoaDon = hoaDonBLL.Insert(dto_hoadon);
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

            printPreviewDialog.Document = printDocument;
            printPreviewDialog.ShowDialog();
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Image image = Resources.Logo;
            e.Graphics.DrawImage(image, 25, 0, image.Width / 3, image.Height / 3);
            e.Graphics.DrawString("NODEADLINE MILK TEA", new Font("Verdana", 25, FontStyle.Bold), Brushes.Black, new Point(250, 65));
            e.Graphics.DrawString("HÓA ĐƠN BÁN HÀNG", new Font("Verdana", 25, FontStyle.Bold), Brushes.Black, new Point(235, 180));
            e.Graphics.DrawString("Ngày: " + DateTime.Now.ToString("dd/MM/yyyy"), new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(25, 250));
            e.Graphics.DrawString("Nhân viên: " + Authentication.loggedInUser.TenNhanVien, new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(25, 300));
            int Sohoadon = maHoaDon;
            int ValueX;
            if (Sohoadon >= 100)
            {
                ValueX = 655;
            }
            else if (Sohoadon >= 10)
            {
                ValueX = 666;
            }
            else
            {
                ValueX = 677;
            }
            e.Graphics.DrawString("Số hóa đơn: " + Sohoadon, new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(ValueX, 250));
            e.Graphics.DrawString("In lúc: " + DateTime.Now.ToString("HH:mm"), new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(700, 300));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------",
                                  new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(25, 350));
            e.Graphics.DrawString("Tên món", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(30, 380));
            e.Graphics.DrawString("Size", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(250, 380));
            e.Graphics.DrawString("Số lượng", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(370, 380));
            e.Graphics.DrawString("Đơn giá", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(540, 380));
            e.Graphics.DrawString("Thành tiền", new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(710, 380));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------",
                                  new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(25, 410));

            int yPos = 450;

            DataTable dt = hoaDonBLL.getChiTietHoaDonTheoMaHoaDon(maHoaDon);
            decimal tongTien = 0;

            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    string tenMon = row["TenSanPham"].ToString();
                    string size = row["Size"].ToString();
                    int soLuong = Convert.ToInt32(row["SoLuong"]);
                    decimal donGia = Convert.ToDecimal(row["DonGia"]);
                    decimal thanhTien = soLuong * donGia;
                    tongTien += thanhTien;
                    

                    SizeF stringSize = e.Graphics.MeasureString(tenMon, new Font("Arial", 16, FontStyle.Regular));
                    int maxItemNameWidth = 200;
                    if (stringSize.Width > maxItemNameWidth)
                    {
                        int numLines = (int)Math.Floor(stringSize.Width / maxItemNameWidth);
                        float lineHeight = (stringSize.Height / numLines) + stringSize.Height * 2;
                        for (int i = 0; i < numLines; i++)
                        {
                            RectangleF rect = new RectangleF(new Point(30, yPos), new SizeF(maxItemNameWidth, lineHeight));
                            e.Graphics.DrawString(tenMon, new Font("Arial", 16, FontStyle.Regular), Brushes.Black, rect);
                            e.Graphics.DrawString(size, new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(260, yPos));
                            e.Graphics.DrawString(soLuong.ToString(), new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(420, yPos));
                            e.Graphics.DrawString(donGia.ToString(), new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(550, yPos));
                            e.Graphics.DrawString(thanhTien.ToString(), new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(740, yPos));
                            yPos += (int)(lineHeight * numLines);
                        }

                    }
                    else
                    {
                        e.Graphics.DrawString(tenMon, new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(30, yPos));
                        e.Graphics.DrawString(size, new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(260, yPos));
                        e.Graphics.DrawString(soLuong.ToString(), new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(420, yPos));
                        e.Graphics.DrawString(donGia.ToString(), new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(550, yPos));
                        e.Graphics.DrawString(thanhTien.ToString(), new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(740, yPos));
                        yPos += 70;
                    }
                }
            }
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------",
                                  new Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(25, yPos - 25));
            e.Graphics.DrawString("Tổng: ", new Font("Verdana", 20, FontStyle.Bold), Brushes.Black, new Point(25, yPos));
            int totalValueX;
            if (tongTien >= 100)
            {
                totalValueX = 700;
            }
            else
            {
                totalValueX = 720;
            }
            e.Graphics.DrawString(tongTien.ToString(), new Font("Verdana", 20, FontStyle.Bold), Brushes.Black, new Point(totalValueX, yPos));
            int pageHeight = e.PageBounds.Height;
            int thankYouYPos = pageHeight - 50;
            e.Graphics.DrawString("Cảm ơn Quý khách và hẹn gặp lại! ", new Font("Arial", 16, FontStyle.Italic), Brushes.Black, new Point(260, thankYouYPos));
        }
    }
}