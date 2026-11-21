using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S4_UrunListesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> urunAdlari = new List<string>();
        List<decimal> urunFiyatlari = new List<decimal>();

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            string ad = txtProductName.Text.Trim();
            string fiyatYazi = txtProductPrice.Text.Trim();

            if (ad == "" || fiyatYazi == "")
            {
                MessageBox.Show("Lütfen ürün adını ve fiyatını giriniz.", "Eksik Bilgi",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (ad == "") txtProductName.Focus();
                else txtProductPrice.Focus();
                return;
            }

            decimal fiyat;
            if (!decimal.TryParse(fiyatYazi, out fiyat) || fiyat <= 0)
            {
                MessageBox.Show("Fiyat 0'dan büyük bir sayı olmalıdır.", "Hatalı Fiyat",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProductPrice.Focus();
                return;
            }

            urunAdlari.Add(ad);
            urunFiyatlari.Add(fiyat);
            lblTotal.Text = urunAdlari.Count + " ürün eklendi. Görmek için listeleyin.";

            txtProductName.Clear();
            txtProductPrice.Clear();
            txtProductName.Focus();
        }

        private void btnShowTotal_Click(object sender, EventArgs e)
        {
            lstProducts.Items.Clear();

            if (urunAdlari.Count == 0)
            {
                lblTotal.Text = "Toplam Tutar: 0,00 TL";
                MessageBox.Show("Henüz ürün eklenmedi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            decimal toplam = 0;
            for (int i = 0; i < urunAdlari.Count; i++)
            {
                lstProducts.Items.Add(urunAdlari[i] + " - " + urunFiyatlari[i].ToString("N2") + " TL");
                toplam += urunFiyatlari[i];
            }
            lblTotal.Text = "Toplam Tutar: " + toplam.ToString("N2") + " TL";
        }

        private void txtProductPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == 8)
                e.Handled = false;
            else if (e.KeyChar == ',' && !txtProductPrice.Text.Contains(","))
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
