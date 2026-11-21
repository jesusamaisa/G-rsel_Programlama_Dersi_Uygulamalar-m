using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U077_FareTuslari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            int deger = Convert.ToInt32(textBox1.Text);
            if (e.Button == MouseButtons.Left)
                deger = deger + 1;
            if (e.Button == MouseButtons.Right)
                deger = deger - 1;
            if (e.Button == MouseButtons.XButton1)
                deger = deger + 10;
            if (e.Button == MouseButtons.XButton2)
                deger = deger - 10;
            textBox1.Text = deger.ToString();
        }
    }
}
