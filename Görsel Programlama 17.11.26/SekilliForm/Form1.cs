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

namespace SekilliForm
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

            Bitmap resim = new Bitmap(300, 300);
            using (Graphics g = Graphics.FromImage(resim))
            {
                g.SmoothingMode = SmoothingMode.None;
                g.Clear(Color.Magenta);
                g.FillEllipse(Brushes.Orange, 20, 20, 260, 260);
                PointF[] yildiz = new PointF[10];
                for (int i = 0; i < 10; i++)
                {
                    double aci = Math.PI / 2 + i * Math.PI / 5;
                    float r = (i % 2 == 0) ? 120 : 50;
                    yildiz[i] = new PointF(150 + (float)(r * Math.Cos(aci)), 150 - (float)(r * Math.Sin(aci)));
                }
                g.FillPolygon(Brushes.Gold, yildiz);

                StringFormat ortala = new StringFormat();
                ortala.Alignment = StringAlignment.Center;
                g.DrawString("Muhammed İsa Erkan\n221001019", new Font("Segoe UI", 11F, FontStyle.Bold),
                             Brushes.DarkRed, new RectangleF(40, 198, 220, 50), ortala);
            }
            this.BackgroundImage = resim;
            this.TransparencyKey = Color.Magenta;   
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            tiklanan_nokta = new Point(e.X, e.Y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point koordinatlar;
                koordinatlar = Control.MousePosition;
                koordinatlar.Offset(-tiklanan_nokta.X, -tiklanan_nokta.Y);
                this.Location = koordinatlar;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
