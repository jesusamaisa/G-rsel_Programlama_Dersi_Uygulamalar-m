using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S1_ListBoxArama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(new string[] { "Muhammed", "İsa", "Erkan", "Ayşe", "Paycı",
                                                   "Muhammed", "Ayşe", "İsa", "Muhammed", "Ayşe" });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string aranan = textBox1.Text.Trim();
            listBox1.ClearSelected();              

            if (aranan == "")
            {
                MessageBox.Show("Lütfen aranacak değeri giriniz.");
                textBox1.Focus();
                return;
            }

            int adet = 0;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (listBox1.Items[i].ToString().ToUpper() == aranan.ToUpper())
                {
                    listBox1.SetSelected(i, true);  
                    adet++;
                }
            }

            if (adet > 0)
                label2.Text = aranan + " listede " + adet + " kez bulundu ve seçildi.";
            else
                label2.Text = aranan + " listede bulunamadı.";
        }
    }
}
