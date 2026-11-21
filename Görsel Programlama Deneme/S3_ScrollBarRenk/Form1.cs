using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S3_ScrollBarRenk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void renk_degisti(object sender, ScrollEventArgs e)
        {
            Color renk = Color.FromArgb(sb1.Value, sb2.Value, sb3.Value);

            if (radioButton1.Checked)
                panel1.BackColor = renk;        
            else
                panel1.ForeColor = renk;        

            label2.Text = "Kırmızı: " + sb1.Value;
            label3.Text = "Yeşil: " + sb2.Value;
            label4.Text = "Mavi: " + sb3.Value;
        }

        private void secim_degisti(object sender, EventArgs e)
        {
            RadioButton secilen = (RadioButton)sender;
            if (!secilen.Checked) return;       

            Color simdiki;
            if (radioButton1.Checked)
                simdiki = panel1.BackColor;
            else
                simdiki = panel1.ForeColor;

            sb1.Value = simdiki.R;
            sb2.Value = simdiki.G;
            sb3.Value = simdiki.B;
            renk_degisti(null, null);           
        }
    }
}
