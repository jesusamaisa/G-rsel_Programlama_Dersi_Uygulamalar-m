using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U079_FareTekerlek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MouseWheel += new MouseEventHandler(OnMouseWheel);
        }

        private void OnMouseWheel(object sender, MouseEventArgs e)
        {
            this.Height = this.Height - Math.Sign(e.Delta) * 10;
        }
    }
}
