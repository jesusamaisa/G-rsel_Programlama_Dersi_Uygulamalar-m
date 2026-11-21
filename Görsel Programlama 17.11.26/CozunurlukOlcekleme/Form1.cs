using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CozunurlukOlcekleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int orinal_x = 800;
        int orinal_y = 600;

        private void button1_Click(object sender, EventArgs e)
        {
            Rectangle cozunurluk = new Rectangle();
            cozunurluk = Screen.GetBounds(cozunurluk);
            float oran_x, oran_y;
            oran_x = (float)cozunurluk.Width / orinal_x;
            oran_y = (float)cozunurluk.Height / orinal_y;
            this.Left = 0;
            this.Top = 0;
            this.Scale(new SizeF(oran_x, oran_y));
            label1.Text = "Ekran çözünürlüğü: " + cozunurluk.Width + "x" + cozunurluk.Height +
                          "\nÖlçek oranı: " + oran_x.ToString("0.00") + " x " + oran_y.ToString("0.00");
            button1.Enabled = false;
        }
    }
}
