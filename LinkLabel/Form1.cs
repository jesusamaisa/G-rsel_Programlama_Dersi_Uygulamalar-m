using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace LinkLabel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            linkLabel1.Text = "Sayfalarıma gitmek için buraya tıklayınız";
            linkLabel1.Links.Add(36, 6, "https://linktr.ee/jesusbutisa");
            linkLabel1.LinkColor = Color.Blue;
            linkLabel1.VisitedLinkColor = Color.Red;
            linkLabel1.ActiveLinkColor = Color.Brown;
            linkLabel1.LinkBehavior = LinkBehavior.AlwaysUnderline;
            linkLabel2.Text = "Mail göndermek için buraya tıklayınız";
            linkLabel2.Links.Add(20, 6, "mailto:ornek@ornek.com");
            linkLabel2.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel3.Text = "Not Defteri programını çalıştırmak için buraya tıklayınız";
            linkLabel3.Links.Add(40, 6, "notepad.exe");
            linkLabel4.Text = "Windows klasörünü açmak için buraya tıklayınız";
            linkLabel4.Links.Add(29, 6, Environment.GetFolderPath(Environment.SpecialFolder.Windows));
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            e.Link.Visited = true;
            try
            {
                Process.Start(new ProcessStartInfo(e.Link.LinkData.ToString()) { UseShellExecute = true });
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }
    }
}
