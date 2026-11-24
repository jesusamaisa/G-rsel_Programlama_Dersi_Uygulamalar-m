using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CokSatirliTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Visual\r\n" + "C#.Net\r\n" + "2008";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("textBox kontrolünde " + (textBox1.Lines.GetUpperBound(0) + 1).ToString() + " satır vardır");
            for (int i = 0; i <= textBox1.Lines.GetUpperBound(0); i++)
                MessageBox.Show((i + 1).ToString() + ". satırda " + textBox1.Lines[i].ToString() + " bilgisi vardır");
        }
    }
}
