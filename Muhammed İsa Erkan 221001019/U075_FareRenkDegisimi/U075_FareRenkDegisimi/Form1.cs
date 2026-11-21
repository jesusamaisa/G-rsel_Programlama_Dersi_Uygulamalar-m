using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U075_FareRenkDegisimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.MouseEnter += new EventHandler(textBox1_MouseEnter);
            textBox3.MouseEnter += new EventHandler(textBox1_MouseEnter);
            textBox2.MouseLeave += new EventHandler(textBox1_MouseLeave);
            textBox3.MouseLeave += new EventHandler(textBox1_MouseLeave);
            textBox2.MouseHover += new EventHandler(textBox1_MouseHover);
            textBox3.MouseHover += new EventHandler(textBox1_MouseHover);
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            (sender as Control).BackColor = Color.Green;
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            (sender as Control).BackColor = Color.White;
        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            (sender as Control).BackColor = Color.Yellow;
        }
    }
}
