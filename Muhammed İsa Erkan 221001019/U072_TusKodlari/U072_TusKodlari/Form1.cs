using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U072_TusKodlari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            label1.Text = e.KeyCode.ToString();
            this.Text = "Basılan tuşun sayısal kodu: " + e.KeyValue.ToString() + " Sembolik adı: " + e.KeyCode.ToString();
        }
    }
}
