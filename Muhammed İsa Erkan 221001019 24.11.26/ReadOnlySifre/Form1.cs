using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadOnlySifre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Txt_adiniz.ReadOnly = true;
            Txt_soyadiniz.ReadOnly = true;
        }

        private void Btn_tamam_Click(object sender, EventArgs e)
        {
            if (Txt_sifre.Text == "1234")
            {
                Txt_adiniz.ReadOnly = false;
                Txt_soyadiniz.ReadOnly = false;
                Txt_adiniz.Focus();
            }
            else
            {
                Txt_adiniz.ReadOnly = true;
                Txt_soyadiniz.ReadOnly = true;
                MessageBox.Show("Şifre yanlış (doğru şifre: 1234)");
            }
        }
    }
}
