using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S2_SurukleBirak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(new string[] { "Muhammed İsa Erkan", "Ayşe Paycı", "Ahmet Yeşilmen", "Onur Meşe",
                                                   "Fatih Şengün", "Abdurrahman Kral", "Miraç Azer", "Hakan Boz" });
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;         

            int sira = listBox1.IndexFromPoint(e.X, e.Y);       
            if (sira == ListBox.NoMatches) return;              

            string kisi = listBox1.Items[sira].ToString();
            DragDropEffects sonuc = listBox1.DoDragDrop(kisi, DragDropEffects.Move);

            if (sonuc == DragDropEffects.Move)                  
                listBox1.Items.RemoveAt(sira);                  
        }

        private void listBox2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Move;               
            else
                e.Effect = DragDropEffects.None;               
        }

        private void listBox2_DragDrop(object sender, DragEventArgs e)
        {
            string kisi = e.Data.GetData(DataFormats.Text).ToString();
            listBox2.Items.Add(kisi);
        }
    }
}
