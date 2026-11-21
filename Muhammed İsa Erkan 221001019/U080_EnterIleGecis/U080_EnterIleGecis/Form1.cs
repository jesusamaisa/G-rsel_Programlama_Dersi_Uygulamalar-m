using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U080_EnterIleGecis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            textBox2.KeyPress += new KeyPressEventHandler(textBox1_KeyPress);
            textBox3.KeyPress += new KeyPressEventHandler(textBox1_KeyPress);
            textBox2.Enter += new EventHandler(textBox1_Enter);
            textBox3.Enter += new EventHandler(textBox1_Enter);
            textBox2.Leave += new EventHandler(textBox1_Leave);
            textBox3.Leave += new EventHandler(textBox1_Leave);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)  
            {
                this.SelectNextControl(sender as Control, true, true, true, true);
                e.Handled = true;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            (sender as Control).BackColor = Color.Red;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            (sender as Control).BackColor = Color.White;
        }
    }
}
