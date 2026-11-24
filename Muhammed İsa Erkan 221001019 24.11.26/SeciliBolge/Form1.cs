using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeciliBolge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Txt_anametin.ScrollBars = ScrollBars.Vertical;
            Txt_anametin.HideSelection = false;
        }

        private void Btn_tumunu_sec_Click(object sender, EventArgs e)
        {
            Txt_anametin.SelectAll();
        }

        private void Btn_buyuk_harf_Click(object sender, EventArgs e)
        {
            if (Txt_anametin.SelectionLength > 0)
                Txt_anametin.SelectedText = Txt_anametin.SelectedText.ToUpper();
            else
                Txt_anametin.Text = Txt_anametin.Text.ToUpper();
        }

        private void Btn_kucuk_harf_Click(object sender, EventArgs e)
        {
            if (Txt_anametin.SelectionLength > 0)
                Txt_anametin.SelectedText = Txt_anametin.SelectedText.ToLower();
            else
                Txt_anametin.Text = Txt_anametin.Text.ToLower();
        }

        private void Btn_bul_Click(object sender, EventArgs e)
        {
            int yer = 0;
            string aranan_kelime;
            aranan_kelime = Txt_aranan.Text;
            if (aranan_kelime == "") return;
            if (Txt_anametin.SelectionLength > 0)
            {
                int bolgede = Txt_anametin.SelectedText.IndexOf(aranan_kelime);
                yer = bolgede < 0 ? -1 : Txt_anametin.SelectionStart + bolgede;
            }
            else
                yer = Txt_anametin.Text.IndexOf(aranan_kelime);
            if (yer < 0)
                MessageBox.Show("Aranan ifade bulunamadı");
            else
            {
                Txt_anametin.Select(yer, aranan_kelime.Length);
                Txt_anametin.ScrollToCaret();
            }
        }

        private void Btn_sil_Click(object sender, EventArgs e)
        {
            if (Txt_anametin.SelectionLength > 0)
                Txt_anametin.SelectedText = "";
            else
                Txt_anametin.Text = "";
        }
    }
}
