using BLL;
using DAL;
using DTO;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace QuanLyQuanTraSua.GUI
{
    public partial class FormGoiMon : Form
    {
        public FormGoiMon()
        {
            InitializeComponent();
        }

        private void FormGoiMon_Load(object sender, EventArgs e)
        {
            DanhMucSanPhamBLL danhmucSanPhambll = new DanhMucSanPhamBLL();
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
            SanPhamBLL sanPhamBLL = new SanPhamBLL();
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

        public Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
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

            PictureBox pictureBox = new PictureBox();
            pictureBox.Size = new Size(90, 76);
            pictureBox.Location = new Point(22, 16);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            if (product["HinhAnh"] != DBNull.Value)
            {
                byte[] imageBytes = (byte[])product["HinhAnh"];
                pictureBox.Image = ByteArrayToImage(imageBytes);
            }

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
    }
}
