using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SifreGirisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int hak = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.PasswordChar = '*';
            this.CancelButton = Btn_iptal;
            this.AcceptButton = Btn_tamam;
        }

        private void Btn_tamam_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "1234")
            {
                MessageBox.Show("Ana menüye yönlendiriliyorsunuz");
            }
            else
            {
                textBox1.Text = "";
                hak++;
                MessageBox.Show("Yanlış şifre girdiniz");
                if (hak == 3)
                {
                    this.DialogResult = DialogResult.Cancel;
                    MessageBox.Show("Şifreyi 3 defa yanlış girdiniz. Program kapatılacaktır");
                    this.Close();
                }
            }
        }

        private void Btn_iptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
