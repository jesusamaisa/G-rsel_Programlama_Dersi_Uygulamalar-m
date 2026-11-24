using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinamikButon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int say = 0, y = 30;

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            say++;
            Button komut_dugmesi = new Button();
            komut_dugmesi.Top = y;
            komut_dugmesi.Left = 10;
            komut_dugmesi.Width = 150;
            komut_dugmesi.Text = "Yeni komut düğmesi " + say.ToString();
            y += komut_dugmesi.Height + 5;
            komut_dugmesi.Click += new EventHandler(tikla);
            this.Controls.Add(komut_dugmesi);
            komut_dugmesi.Focus();
        }

        private void tikla(object sender, System.EventArgs e)
        {
            MessageBox.Show((sender as Button).Text + " tıklandı");
        }


        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveControl is Button)
                this.Controls.Remove(this.ActiveControl);
            else
                MessageBox.Show("Silmek için önce bir düğme seçiniz.");
        }
    }
}
