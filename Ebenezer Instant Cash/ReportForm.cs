using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Printing;

namespace Ebenezar
{
    public partial class ReportForm : Form
    {
        private PrintDocument PrintDocument1 = new PrintDocument();

        public ReportForm()
        {
            InitializeComponent();
            PrintDocument1.PrintPage += new PrintPageEventHandler(PrintDocument1_PrintPage);
        }

        private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            CaptureScreen();
            PrintDocument1.Print();
        }

        Bitmap memoryImage;

        private void CaptureScreen()
        {
            btnPrint.Hide();
            Graphics myGraphics = panel1.CreateGraphics();
            Size s = panel1.ClientSize;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);

            Point panelLocation = PointToScreen(panel1.Location);
            memoryGraphics.CopyFromScreen(panelLocation.X, panelLocation.Y, 0, 0, s);

            btnPrint.Show();
        }
    }
}
