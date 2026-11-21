using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelpButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Visual C#.NET 2008";
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.HelpButton = true;
        }

        private void textBox1_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowPopup(textBox1, "Bu kutu bilgi girişi amaçlı kullanılır", hlpevent.MousePos);
            hlpevent.Handled = true;
        }

        private void button1_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowPopup(button1, "Bu düğme girilen bilgiyi kaydeder", hlpevent.MousePos);
            hlpevent.Handled = true;
        }
    }
}
