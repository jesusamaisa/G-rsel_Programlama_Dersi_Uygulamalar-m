using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U071_TextChangedHesap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        decimal sayi1 = 0, sayi2 = 0, sonuc = 0;

        // textBox1 ve textBox2'nin TextChanged olayları birleştirilmiştir
        private void sayi_degisti(object sender, EventArgs e)
        {
            // hesaplamada kullanılan kontrollerin içinde başlangıçta sayısal değer olmalıdır
            if (!decimal.TryParse(textBox1.Text, out sayi1) || !decimal.TryParse(textBox2.Text, out sayi2))
            {
                textBox3.Text = "";
                return;
            }
            sonuc = sayi1 * sayi2;
            textBox3.Text = sonuc.ToString();
        }
    }
}
