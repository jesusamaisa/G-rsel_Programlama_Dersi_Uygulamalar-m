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

namespace SekilliButon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SekilVer(button1);
            SekilVer(button2);
        }

        private void SekilVer(Control kontrol)
        {
            GraphicsPath grafik_sekil = new GraphicsPath();
            grafik_sekil.AddEllipse(0, 0, kontrol.Width, kontrol.Height);
            kontrol.Region = new Region(grafik_sekil);
        }

        private void dugme_Click(object sender, EventArgs e)
        {
            MessageBox.Show((sender as Button).Text + " tıklandı");
        }
    }
}
