using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MdiForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int yeni_form_sayisi = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            yeniToolStripMenuItem_Click(sender, e);
        }

        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yeni_form_sayisi++;
            Form2 cocuk_form = new Form2();
            cocuk_form.MdiParent = this;
            cocuk_form.Text = "Yeni Form" + yeni_form_sayisi.ToString();
            cocuk_form.Show();
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();
        }

        private void yatayDoseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void dikeyDoseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void basamaklaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void simgeleriYerlestirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }
    }
}
