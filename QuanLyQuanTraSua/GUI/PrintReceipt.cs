using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanTraSua.GUI
{
    public partial class PrintReceipt : Form
    {
        PrintDocument printDocument = new PrintDocument();
        PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
        public PrintReceipt()
        {
            InitializeComponent();

            printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);
            printPreviewDialog.Document = printDocument;
        }
        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Hello, World!", new Font("Arial", 20), Brushes.Black, new PointF(100, 100));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog.ShowDialog();
        }
    }
}
