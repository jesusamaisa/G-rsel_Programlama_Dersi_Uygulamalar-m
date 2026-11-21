using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S5_ButonHareket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();

        private int adimOku()
        {
            int adim;
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("Lütfen hareket miktarını giriniz.", "Uyarı",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return -1;
            }
            if (!int.TryParse(textBox1.Text.Trim(), out adim) || adim <= 0)
            {
                MessageBox.Show("Hareket miktarı pozitif bir tam sayı olmalıdır.", "Hatalı Değer",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.SelectAll();
                textBox1.Focus();
                return -1;
            }
            return adim;
        }

        private void tasi(int dx, int dy)
        {
            int x = button1.Left + dx;
            int y = button1.Top + dy;

            if (x < 0) x = 0;
            if (x > 250) x = 250;
            if (y < 0) y = 0;
            if (y > 250) y = 250;

            button1.Location = new Point(x, y);
            this.Text = "H konumu: " + x + ", " + y;     
        }

        private void button2_Click(object sender, EventArgs e)     
        {
            int adim = adimOku();
            if (adim == -1) return;
            tasi(-adim, 0);
        }

        private void button3_Click(object sender, EventArgs e)    
        {
            int adim = adimOku();
            if (adim == -1) return;
            tasi(adim, 0);
        }

        private void button4_Click(object sender, EventArgs e)     
        {
            int adim = adimOku();
            if (adim == -1) return;
            tasi(0, -adim);
        }

        private void button5_Click(object sender, EventArgs e)     
            int adim = adimOku();
            if (adim == -1) return;
            tasi(0, adim);
        }

        private void button6_Click(object sender, EventArgs e)     
        {
            int x = rnd.Next(0, 251);      
            int y = rnd.Next(0, 251);
            button1.Location = new Point(x, y);
            this.Text = "H konumu: " + x + ", " + y;
        }
    }
}
