using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U076_FareTakip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = e.X.ToString() + " , " + e.Y.ToString();
            textBox1.Left = e.X + 10;
            textBox1.Top = e.Y + 10;
            textBox1.Text = e.X.ToString() + " , " + e.Y.ToString();
        }
    }
}
