using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IkinciFormAcma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Form2 bizim_ikinci_formumuz;
        Form2 kapandi_formu;
        Form2 gizlenen_form;
        int sayac = 0;

        private void button1_Click(object sender, EventArgs e)
        {

            Form2 yeni_form = new Form2();
            sayac++;
            yeni_form.Text = "Form2 - " + sayac;
            yeni_form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form2 modal_form = new Form2();
            modal_form.Text = "Form2 (ShowDialog)";
            modal_form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if ((bizim_ikinci_formumuz == null) || (bizim_ikinci_formumuz.IsDisposed))
            {
                bizim_ikinci_formumuz = new Form2();
                bizim_ikinci_formumuz.Text = "Form2 (IsDisposed)";
                bizim_ikinci_formumuz.Show();
            }
            else
                bizim_ikinci_formumuz.Activate();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (kapandi_formu == null)
            {
                kapandi_formu = new Form2();
                kapandi_formu.Text = "Form2 (FormClosed)";

                kapandi_formu.FormClosed += new FormClosedEventHandler(kapandi);
                kapandi_formu.Show();
            }
            else
                kapandi_formu.Activate();
        }

        private void kapandi(object sender, EventArgs e)
        {
            kapandi_formu = null;
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (gizlenen_form == null)
            {
                gizlenen_form = new Form2();
                gizlenen_form.kapatinca_gizle = true;
                gizlenen_form.Text = "Form2 (gizlenen)";
            }
            gizlenen_form.Show();
            gizlenen_form.Activate();
        }
    }
}
