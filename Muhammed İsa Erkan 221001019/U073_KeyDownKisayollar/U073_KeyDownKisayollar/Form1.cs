using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U073_KeyDownKisayollar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Multiline = true;
            this.KeyPreview = true;   

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                if (e.KeyCode == Keys.Left)
                    textBox1.Left = textBox1.Left - 5;
                else if (e.KeyCode == Keys.Right)
                    textBox1.Left = textBox1.Left + 5;
                else if (e.KeyCode == Keys.Up)
                    textBox1.Top = textBox1.Top - 5;
                else if (e.KeyCode == Keys.Down)
                    textBox1.Top = textBox1.Top + 5;
            }
            if (e.Alt)
            {
                if (e.KeyCode == Keys.Left)
                    textBox1.Width = textBox1.Width - 5;
                else if (e.KeyCode == Keys.Right)
                    textBox1.Width = textBox1.Width + 5;
                else if (e.KeyCode == Keys.Up)
                    textBox1.Height = textBox1.Height - 5;
                else if (e.KeyCode == Keys.Down)
                    textBox1.Height = textBox1.Height + 5;
                e.Handled = true;
            }

            if (e.KeyCode == Keys.F5)
            {
                if (e.Alt)
                    textBox1.Text = textBox1.Text.ToUpper();
                if (e.Control)
                    textBox1.Text = textBox1.Text.ToLower();
            }
            if (e.Shift && e.KeyCode == Keys.Back)
                textBox1.Text = "";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F10)
                Close();
        }
    }
}
