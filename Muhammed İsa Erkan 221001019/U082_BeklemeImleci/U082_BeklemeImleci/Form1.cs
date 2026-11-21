using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U082_BeklemeImleci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            double toplam = 0;
            for (int i = 0; i < 500000000; i++)
                toplam += i;
            this.Cursor = Cursors.Default;
            label1.Text = "İşlem bitti. Toplam = " + toplam.ToString("N0");
        }
    }
}
