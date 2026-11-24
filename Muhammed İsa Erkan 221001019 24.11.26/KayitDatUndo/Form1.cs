using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace KayitDatUndo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "";
            try
            {
                System.IO.TextReader dosya = System.IO.File.OpenText("kayit.dat");
                string satir;
                while ((satir = dosya.ReadLine()) != null)
                    textBox1.Text += satir + (char)13 + (char)10;
                dosya.Close();
            }
            catch
            {
            }
            textBox1.Modified = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (textBox1.Modified == true)
            {
                DialogResult c;
                c = MessageBox.Show("Değişiklikler kaydedilsin mi?", "Kayıt", MessageBoxButtons.YesNo);
                if (c == DialogResult.Yes)
                {
                    System.IO.TextWriter dosya = System.IO.File.CreateText("kayit.dat");
                    dosya.Write(textBox1.Text);
                    dosya.Close();
                }
            }
        }

        private void Btn_gerial_Click(object sender, EventArgs e)
        {
            if (textBox1.CanUndo)
                textBox1.Undo();
            else
                MessageBox.Show("Geri alma işleminiz gerçekleştirilemez");
        }
    }
}
