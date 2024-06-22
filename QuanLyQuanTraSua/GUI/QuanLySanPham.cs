using BLL;
using DAL;
using DTO;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace QuanLyQuanTraSua.GUI
{
    public partial class FormQuanLySanPham : Form
    {
        private SanPhamBLL sanPhamBLL;
        public FormQuanLySanPham()
        {
            InitializeComponent();
        }

        private void FormQuanLySanPham_Load(object sender, EventArgs e)
        {
            sanPhamBLL = new SanPhamBLL();
            dgvSanPham.DataSource = sanPhamBLL.getAllProduct();

            DataTable dt = sanPhamBLL.getCategories();
            cbDanhMucSP.DataSource = dt;
            cbDanhMucSP.DisplayMember = "TenDanhMuc";
            cbDanhMucSP.ValueMember = "MaDanhMuc";
            DataRow newRow = dt.NewRow();
            newRow["MaDanhMuc"] = "";
            newRow["TenDanhMuc"] = "Tất cả";
            dt.Rows.InsertAt(newRow, 0);
            cbDanhMucSP.SelectedIndex = -1;

            DataTable cb_dt = sanPhamBLL.getCategories();
            cbLoaiSanPham.DataSource = cb_dt;
            cbLoaiSanPham.DisplayMember = "TenDanhMuc";
            cbLoaiSanPham.ValueMember = "MaDanhMuc";
            cbLoaiSanPham.SelectedIndex = -1;

            LoadAllProducts();
        }

        private void LoadAllProducts()
        {
            DataTable dt = sanPhamBLL.getAllProduct();
            dt.Columns.Add("Image", typeof(byte[]));
            foreach (DataRow row in dt.Rows)
            {
                string hinhAnh = row["HinhAnh"].ToString();
                if (!string.IsNullOrEmpty(hinhAnh))
                {
                    string imagePath = Path.Combine(Application.StartupPath, "Images", Path.GetFileName(hinhAnh));
                    if (File.Exists(imagePath))
                    {
                        row["Image"] = File.ReadAllBytes(imagePath);
                    }
                }
            }
            dgvSanPham.DataSource = dt;
            if (dgvSanPham.Columns["HinhAnh"] != null)
            {
                dgvSanPham.Columns["HinhAnh"].Visible = false;
            }
        }

        private void FilterProductsByCategory(string maDanhMuc)
        {
            DataTable filteredProducts;

            if (maDanhMuc == "")
            {
                filteredProducts = sanPhamBLL.getAllProduct();
            }
            else
            {
                filteredProducts = sanPhamBLL.getProduct(maDanhMuc);
            }

            if (!filteredProducts.Columns.Contains("Image"))
            {
                filteredProducts.Columns.Add("Image", typeof(byte[]));
            }

            foreach (DataRow row in filteredProducts.Rows)
            {
                string hinhAnh = row["HinhAnh"].ToString();
                if (!string.IsNullOrEmpty(hinhAnh))
                {
                    string imagePath = Path.Combine(Application.StartupPath, "Images", Path.GetFileName(hinhAnh));
                    if (File.Exists(imagePath))
                    {
                        row["Image"] = File.ReadAllBytes(imagePath);
                    }
                }
            }
            dgvSanPham.DataSource = filteredProducts;
            if (dgvSanPham.Columns["HinhAnh"] != null)
            {
                dgvSanPham.Columns["HinhAnh"].Visible = false;
            }
        }

        private void cbDanhMucSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDanhMucSP.SelectedIndex == -1 || cbDanhMucSP.SelectedItem.ToString() == "")
            {
                FilterProductsByCategory("");
            }
            else
            {
                string selectedMaDanhMuc = cbDanhMucSP.SelectedValue.ToString();
                FilterProductsByCategory(selectedMaDanhMuc);
            }
        }

        private void FilterProductsByName(string tenSanPham)
        {
            DataTable dt = sanPhamBLL.getDataByName(tenSanPham);

            if (!dt.Columns.Contains("Image"))
            {
                dt.Columns.Add("Image", typeof(byte[]));
            }

            foreach (DataRow row in dt.Rows)
            {
                string hinhAnh = row["HinhAnh"].ToString();
                if (!string.IsNullOrEmpty(hinhAnh))
                {
                    string imagePath = Path.Combine(Application.StartupPath, "Images", Path.GetFileName(hinhAnh));
                    if (File.Exists(imagePath))
                    {
                        row["Image"] = File.ReadAllBytes(imagePath);
                    }
                }
            }
            dgvSanPham.DataSource = dt;
            if (dgvSanPham.Columns["HinhAnh"] != null)
            {
                dgvSanPham.Columns["HinhAnh"].Visible = false;
            }
        }

        private void txbTimKiemSP_TextChanged(object sender, EventArgs e)
        {
            string tenSanPham = txbTimKiemSP.Text;
            FilterProductsByName(tenSanPham);
        }

        private void btTaiHinhAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png, *.gif) | *.jpg; *.jpeg; *.png; *.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    txbImage.Text = openFileDialog.FileName;
                    pBHinhAnh.Image = new Bitmap(openFileDialog.FileName);
                    pBHinhAnh.ImageLocation = openFileDialog.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể mở tệp hình ảnh: " + ex.Message);
                }
            }
        }

        private bool IsMaSanPhamExistInDataGridView(string MaSanPham)
        {
            foreach (DataGridViewRow row in dgvSanPham.Rows)
            {
                if (row.Cells["MaSanPham"].Value != null && row.Cells["MaSanPham"].Value.ToString().Trim() == MaSanPham)
                {
                    return true;
                }
            }
            return false;
        }

        private void btThemSanPham_Click(object sender, EventArgs e)
        {
            sanPhamBLL = new SanPhamBLL();
            if (txbMaSanPham.Text == "" && txbTenSanPham.Text == "" && cbLoaiSanPham.Text == "" && txbSize.Text == "" && txbDonGia.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txbMaSanPham.Text == "" || txbTenSanPham.Text == "" || cbLoaiSanPham.Text == "" || txbSize.Text == "" || txbDonGia.Text == "" || pBHinhAnh.Image == null)
            {
                MessageBox.Show("Vui lòng nhập thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (IsMaSanPhamExistInDataGridView(txbMaSanPham.Text))
                {
                    MessageBox.Show("Sản phẩm đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string sourceFilePath = txbImage.Text;
                    string fileName = Path.GetFileNameWithoutExtension(pBHinhAnh.ImageLocation);
                    string fileExtension = Path.GetExtension(pBHinhAnh.ImageLocation);
                    string timestamp = DateTime.Now.ToString("yyyyMMddHHmmssfff");
                    string newFileName = fileName + "_" + timestamp + fileExtension;
                    string destinationPath = Path.Combine(Application.StartupPath, "Images", newFileName);
                    bool isSuccess = sanPhamBLL.Insert(new SanPhamDTO(txbMaSanPham.Text, txbTenSanPham.Text, txbSize.Text, Convert.ToInt32(txbDonGia.Text), cbLoaiSanPham.SelectedValue.ToString(), newFileName));
                    if (isSuccess)
                    {
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        File.Copy(sourceFilePath, destinationPath);
                        LoadAllProducts();
                        txbMaSanPham.Clear();
                        txbTenSanPham.Clear();
                        txbSize.Clear();
                        txbDonGia.Clear();
                        pBHinhAnh.Image = null;
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private string Selected()
        {
            int selectedIndex = dgvSanPham.SelectedCells[0].RowIndex;
            DataGridViewRow selected = dgvSanPham.Rows[selectedIndex];
            string selectedID = selected.Cells[0].Value.ToString();
            return selectedID;
        }

        private void btXoaSanPham_Click(object sender, EventArgs e)
        {
            string sanpham_selected = Selected();
            sanPhamBLL = new SanPhamBLL();
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sanPhamBLL.Delete(sanpham_selected);
                LoadAllProducts();
                txbMaSanPham.Clear();
                txbTenSanPham.Clear();
                txbSize.Clear();
                txbDonGia.Clear();
                pBHinhAnh.Image = null;
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selected = dgvSanPham.Rows[e.RowIndex];
                if (selected.Cells[5].Value != DBNull.Value)
                {
                    string imagePath = selected.Cells[5].Value.ToString();
                    string fullImagePath = Path.Combine(Application.StartupPath, "Images", imagePath);

                    if (File.Exists(fullImagePath))
                    {
                        pBHinhAnh.Image = Image.FromFile(fullImagePath);
                        pBHinhAnh.ImageLocation = fullImagePath; 
                    }
                    else
                    {
                        pBHinhAnh.Image = null;
                        pBHinhAnh.ImageLocation = null;
                    }
                }
                else
                {
                    pBHinhAnh.Image = null;
                    pBHinhAnh.ImageLocation = null;
                }
                txbMaSanPham.Text = selected.Cells[0].Value.ToString();
                txbTenSanPham.Text = selected.Cells[1].Value.ToString();
                txbSize.Text = selected.Cells[2].Value.ToString();
                txbDonGia.Text = selected.Cells[3].Value.ToString();
                cbLoaiSanPham.Text = selected.Cells[4].Value.ToString();
            }    
        }

        private void btSuaSanPham_Click(object sender, EventArgs e)
        {
            sanPhamBLL = new SanPhamBLL();
            if (txbMaSanPham.Text == "" && txbTenSanPham.Text == "" && cbLoaiSanPham.Text == "" && txbSize.Text == "" && txbDonGia.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txbMaSanPham.Text == "" || txbTenSanPham.Text == "" || cbLoaiSanPham.Text == "" || txbSize.Text == "" || txbDonGia.Text == "" || pBHinhAnh.Image == null)
            {
                MessageBox.Show("Vui lòng nhập thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string sourceFilePath = txbImage.Text;
                string fileName = Path.GetFileNameWithoutExtension(pBHinhAnh.ImageLocation);
                string fileExtension = Path.GetExtension(pBHinhAnh.ImageLocation);
                string timestamp = DateTime.Now.ToString("yyyyMMddHHmmssfff");
                string newFileName = fileName + "_" + timestamp + fileExtension;
                string destinationPath = Path.Combine(Application.StartupPath, "Images", newFileName);
                bool isSuccess = sanPhamBLL.Update(new SanPhamDTO(txbMaSanPham.Text, txbTenSanPham.Text, txbSize.Text, Convert.ToInt32(txbDonGia.Text), cbLoaiSanPham.SelectedValue.ToString(), newFileName));
                if (isSuccess == true)
                {
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    File.Copy(sourceFilePath, destinationPath);
                    LoadAllProducts();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }    
            }
        }

        private void FormQuanLySanPham_FormClosed(object sender, FormClosedEventArgs e)
        {
            sanPhamBLL.CloseConnection();
        }
    }
}
