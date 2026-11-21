using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U068_RgbRenkAyari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int red_deger, green_deger, blue_deger;

        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDown1_red.Maximum = 255;
            numericUpDown2_green.Maximum = 255;
            numericUpDown3_blue.Maximum = 255;
            numericUpDown1_red.Value = 179;
            numericUpDown2_green.Value = 71;
            numericUpDown3_blue.Value = 186;
        }

        private void renk_degisti(object sender, EventArgs e)
        {
            red_deger = Convert.ToInt16(numericUpDown1_red.Value);
            green_deger = Convert.ToInt16(numericUpDown2_green.Value);
            blue_deger = Convert.ToInt16(numericUpDown3_blue.Value);
            panel1.BackColor = Color.FromArgb(red_deger, green_deger, blue_deger);
            label4.Text = "RGB(" + red_deger + ", " + green_deger + ", " + blue_deger + ")";
        }
    }
}
