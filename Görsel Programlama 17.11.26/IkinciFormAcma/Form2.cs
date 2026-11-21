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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public bool kapatinca_gizle = false;

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (kapatinca_gizle && e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;   
                this.Hide();       
            }
        }
    }
}
