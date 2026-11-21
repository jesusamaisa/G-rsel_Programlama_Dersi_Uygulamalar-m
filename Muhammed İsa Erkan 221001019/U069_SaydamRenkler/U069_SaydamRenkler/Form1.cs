using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U069_SaydamRenkler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool ciz = false;

        private void button1_Click(object sender, EventArgs e)
        {
            ciz = true;
            this.Invalidate();   // Paint olayı yeniden çalıştırılır
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (!ciz) return;
            Graphics kare = e.Graphics;
            // kırmızı kare
            kare.FillRectangle(new SolidBrush(Color.FromArgb(200, 255, 0, 0)), 10, 10, 100, 100);
            // yeşil kare çizdiriliyor
            kare.FillRectangle(new SolidBrush(Color.FromArgb(200, 0, 255, 0)), 90, 50, 100, 100);
            // mavi kare çizdiriliyor
            kare.FillRectangle(new SolidBrush(Color.FromArgb(200, 0, 0, 255)), 150, 10, 100, 100);
            // hexadecimal formatta renk: ilk 2 rakam saydamlık, sonrakiler kırmızı-yeşil-mavi
            kare.FillEllipse(new SolidBrush(Color.FromArgb(unchecked((int)0x80FFFF1D))), 60, 120, 140, 60);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // isimlendirilmiş renk ile saydamlık (form zemin rengi saydam olamayacağı için yarı ton elde edilir)
            this.BackColor = Color.FromArgb(255, Color.FromArgb(100, Color.AliceBlue));
            this.Opacity = this.Opacity == 1 ? 0.8 : 1;
        }
    }
}
