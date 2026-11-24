using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormOzellikleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = this.Text;
            foreach (FormBorderStyle stil in Enum.GetValues(typeof(FormBorderStyle)))
                comboBox1.Items.Add(stil);
            comboBox1.SelectedItem = this.FormBorderStyle;
            this.MinimumSize = new Size(300, 250);   // formun alabileceği en küçük boyut
            label4.Text = "MinimumSize = 300x250, StartPosition = " + this.StartPosition;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.Text = textBox1.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.FormBorderStyle = (FormBorderStyle)comboBox1.SelectedItem;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.ControlBox = checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = checkBox2.Checked;   
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            this.ShowInTaskbar = checkBox3.Checked;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            this.Opacity = trackBar1.Value / 100.0;   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Form üzerindeki kontrol sayısı: " + this.Controls.Count + "\nAktif kontrol: " + this.ActiveControl.Name);
        }
    }
}
