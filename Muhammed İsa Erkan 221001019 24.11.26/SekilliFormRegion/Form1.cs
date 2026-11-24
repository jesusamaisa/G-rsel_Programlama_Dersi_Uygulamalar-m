using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace SekilliFormRegion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Point tiklanan_nokta;

        private void Form1_Load(object sender, EventArgs e)
        {

            GraphicsPath grafik_sekil = new GraphicsPath();
            grafik_sekil.AddRectangle(new Rectangle(0, 0, this.ClientSize.Width, 90));
            grafik_sekil.AddString("Formumuz", new FontFamily("Tahoma"), (int)FontStyle.Bold, 72f, new PointF(0, 100),
                                   new StringFormat(StringFormat.GenericDefault));
            grafik_sekil.AddRectangle(new Rectangle(0, this.ClientSize.Height - 90, this.ClientSize.Width, 90));
            this.Region = new Region(grafik_sekil);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            tiklanan_nokta = new Point(e.X, e.Y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point koordinatlar = Control.MousePosition;
                koordinatlar.Offset(-tiklanan_nokta.X, -tiklanan_nokta.Y);
                this.Location = koordinatlar;
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawString("Muhammed İsa Erkan 221001019", new Font("Segoe UI", 16F, FontStyle.Bold),
                                  Brushes.White, 20, 28);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
