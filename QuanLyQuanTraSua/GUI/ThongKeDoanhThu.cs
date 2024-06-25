using QuanLyQuanTraSua.BLL;
using QuanLyQuanTraSua.DTO;
using QuanLyQuanTraSua.Helper;
using System;
using System.Windows.Forms.DataVisualization.Charting;


namespace QuanLyQuanTraSua.GUI
{
    public partial class FormThongKe : Form
    {
        private ThongKeBLL thongkeBLL;
        private Chart chart;
        private readonly string THANG_TYPE = "Tháng";
        private readonly string NAM_TYPE = "Năm";
        public FormThongKe()
        {
            InitializeComponent();
            this.thongkeBLL = new ThongKeBLL();
            createNewChart();
            ptNoData.Hide();
            LoadCbSelectType();
        }
        public void LoadCbSelectType()
        {
            cbSelectType.Items.Add(THANG_TYPE);
            cbSelectType.Items.Add(NAM_TYPE);
            cbSelectType.SelectedItem = THANG_TYPE;
        }
        private void createNewChart()
        {
            // Tạo một control Chart mới
            Chart chart = new Chart();
            chart.Dock = DockStyle.Fill;
            chart.Location = new System.Drawing.Point(10, 10);
            chart.Name = "chart";
        }
        private void FormThongKe_Load(object sender, EventArgs e)
        {
            InitializeChart();
            LoadYearsIntoComboBox();
            LoadMonthsIntoComboBox();
        }
        private void LoadYearsIntoComboBox()
        {
            // Lấy năm hiện tại
            int currentYear = DateTime.Now.Year;

            // Thêm các năm từ năm hiện tại đến năm hiện tại + 10 vào ComboBox
            for (int i = currentYear - 10; i <= currentYear; i++)
            {
                cbYear.Items.Add(i);
            }

            // Optional: Đặt giá trị mặc định cho ComboBox là năm hiện tại
            cbYear.SelectedItem = currentYear;
        }
        private void LoadMonthsIntoComboBox()
        {
            int currentMonth = DateTime.Now.Month;

            for (int i = 1; i <= 12; i++)
            {
                cbMonth.Items.Add(i);
            }
            cbMonth.SelectedItem = currentMonth;
        }
        private void InitializeChart()
        {
            reDrawChart();

            // Cập nhật biểu đồ với dữ liệu ban đầu
            UpdateChart(DateTime.Now.Month, DateTime.Now.Year);
        }
        private void UpdateChart(int month, int year)
        {
            reDrawChart();
            List<ThongKeDoanhThu> thongKe = thongkeBLL.ThongKeDoanhTHuTheoNgay(month, year);
            handleShowNoDataPanel(thongKe);

            // Tạo một chuỗi Series mới
            Series series = createSeries();
            // Thêm dữ liệu vào chuỗi Series
            foreach (ThongKeDoanhThu t in thongKe)
            {
                series.Points.AddXY(t.Ngay.ToString("dd/MM/yyyy"), t.DoanhThu);
                series.Points[series.Points.Count - 1].Label = Currency.convertToVND(t.DoanhThu); // Hiển thị số liệu doanh thu
            }

            // Thêm Series vào Chart
            chart.Series.Add(series);
            setChartTitle("Thống kê doanh thu theo tháng");
        }
        private void UpdateChart(int year)
        {
            reDrawChart();
            List<ThongKeDoanhThu> thongKe = thongkeBLL.ThongKeDoanhTHuTheoNam(year);
            handleShowNoDataPanel(thongKe);

            // Tạo một chuỗi Series mới
            Series series = createSeries();

            // Thêm dữ liệu vào chuỗi Series
            foreach (ThongKeDoanhThu t in thongKe)
            {
                series.Points.AddXY("Tháng " + t.Thang, t.DoanhThu);
                series.Points[series.Points.Count - 1].Label = Currency.convertToVND(t.DoanhThu); // Hiển thị số liệu doanh thu
            }

            // Thêm Series vào Chart
            chart.Series.Add(series);

            setChartTitle("Thống kê doanh thu theo năm");
        }
        private void reDrawChart()
        {
            if (chart != null)
            {
                this.Controls.Remove(chart);
            }

            // Tạo một control Chart mới
            chart = new Chart();
            chart.Dock = DockStyle.Fill;
            chart.Location = new System.Drawing.Point(10, 50);
            chart.Name = "chart";

            addChartArea();
            // Thêm Chart vào Controls của Form
            this.Controls.Add(chart);
        }
        private void addChartArea()
        {
            ChartArea chartArea = new ChartArea();
            // Đặt tiêu đề cho các trục
            chartArea.AxisY.Title = "Doanh Thu";

            // Đổi font và in đậm cho tiêu đề của trục Y
            chartArea.AxisY.TitleFont = new Font("Arial", 12, FontStyle.Bold);

            // Thiết lập màu sắc cho các đường lưới dọc và ngang
            chartArea.AxisX.MajorGrid.Enabled = false;
            chartArea.AxisY.MajorGrid.LineColor = Color.LightGray;

            chart.ChartAreas.Add(chartArea);
        }

        private Series createSeries()
        {
            Series series = new Series();
            series.Name = "DataSeries";
            series.ChartType = SeriesChartType.Line; // Loại biểu đồ là đường
            series.Color = Color.Blue; // Thiết lập màu sắc cho đường vẽ
            series.BorderWidth = 2; // Độ dày của đường
            return series;
        }
        private void handleShowNoDataPanel(List<ThongKeDoanhThu> thongKeData)
        {
            if (thongKeData == null || thongKeData?.Count == 0)
            {
                ptNoData.Show();
            }
            else
            {
                ptNoData.Hide();
            }
        }
        private void setChartTitle(string title)
        {
            // Thêm tiêu đề cho biểu đồ (thay đổi font và căn lề)
            Title chartTitle = new Title();
            chartTitle.Font = new Font("Arial", 14, FontStyle.Bold); // Thiết lập font, kích thước và kiểu chữ
            chartTitle.Text = title; // Nội dung của tiêu đề
            chartTitle.Alignment = ContentAlignment.TopCenter; // Căn lề giữa
            chart.Titles.Clear();
            chart.Titles.Add(chartTitle);
        }

        private void cbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMonth.SelectedItem != null && cbYear.SelectedItem != null)
            {
                int selectedMonth = int.Parse(cbMonth.SelectedItem.ToString());
                int selectedYear = int.Parse(cbYear.SelectedItem.ToString());

                UpdateChart(selectedMonth, selectedYear);
            }

        }
        private void UpdateChart()
        {
            int selectedMonth = getSelectedMonth();
            int selectedYear = getSelectedYear();

            if (cbSelectType.SelectedItem == NAM_TYPE)
            {
                UpdateChart(selectedYear);
            }
            else if (selectedMonth != 0 && selectedYear != 0)
            {
                UpdateChart(selectedMonth, selectedYear);
            }
        }
        private void cbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateChart();
        }
        private int getSelectedMonth()
        {
            if (cbMonth.SelectedItem != null)
            {
                return int.Parse(cbMonth.SelectedItem.ToString());
            }

            return 0;
        }
        private int getSelectedYear()
        {
            if (cbYear.SelectedItem != null)
            {
                return int.Parse(cbYear.SelectedItem.ToString());
            }

            return 0;
        }
        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSelectType.SelectedItem != null)
            {
                if (cbSelectType.SelectedItem == THANG_TYPE)
                {
                    showcbMonth();
                }
                else
                {
                    hidecbMonth();
                }
            }
            UpdateChart();
        }

        private void showcbMonth()
        {
            cbMonth.Show();
            lbSelectThang.Show();
        }

        private void hidecbMonth()
        {
            cbMonth.Hide();
            lbSelectThang.Hide();
        }


    }
}
