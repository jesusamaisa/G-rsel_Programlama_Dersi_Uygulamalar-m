using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U074_RakamYaziya
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string[] rakamlar = { "Sıfır ", "Bir ", "İki ", "Üç ", "Dört ", "Beş ", "Altı ", "Yedi ", "Sekiz ", "Dokuz " };
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                textBox1.SelectedText = rakamlar[e.KeyChar - (char)'0'];
                e.Handled = true;
            }
        }
    }
}
