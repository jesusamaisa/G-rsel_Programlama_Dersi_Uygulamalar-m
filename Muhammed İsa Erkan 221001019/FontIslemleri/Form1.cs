namespace FontIslemleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FontBilgisi()
        {
            label2.Text = "Name: " + Txt_yazi.Font.Name + "  Size: " + Txt_yazi.Font.Size + "  Bold: " + Txt_yazi.Font.Bold +
                          "  Italic: " + Txt_yazi.Font.Italic;
        }

        private void Btn_kalin_Click(object sender, EventArgs e)
        {
            // Txt_yazi kontrolünün içindeki yazı kalın değilse kalın kalınsa kalın değil yapıyor  bu işlem için ^ işareti kullanıyor
            Txt_yazi.Font = new Font(Txt_yazi.Font, Txt_yazi.Font.Style ^ FontStyle.Bold);
            FontBilgisi();
        }

        private void Btn_egik_Click(object sender, EventArgs e)
        {
            // yazı eğik değilse eğik eğikse eğik değil yapılıyor
            Txt_yazi.Font = new Font(Txt_yazi.Font, Txt_yazi.Font.Style ^ FontStyle.Italic);
            FontBilgisi();
        }

        private void Btn_altcizili_Click(object sender, EventArgs e)
        {
            // yazının altı çizili değilse altı çizili altı çiziliyse altı çizili değil yapıyor
            Txt_yazi.Font = new Font(Txt_yazi.Font, Txt_yazi.Font.Style ^ FontStyle.Underline);
            FontBilgisi();
        }

        private void Btn_ustucizili_Click(object sender, EventArgs e)
        {
            // yazının üstü çizili değilse üstü çizili üstü çiziliyse üstü çizili değil yapıyor
            Txt_yazi.Font = new Font(Txt_yazi.Font, Txt_yazi.Font.Style ^ FontStyle.Strikeout);
            FontBilgisi();
        }

        private void numericUpDown_boyut_ValueChanged(object sender, EventArgs e)
        {
            // numericUpDown_boyut kontrolünün içindeki değere göre yazı boyutu ayarlanıyor
            Txt_yazi.Font = new Font(Txt_yazi.Font.Name, (float)numericUpDown_boyut.Value, Txt_yazi.Font.Style);
            FontBilgisi();
        }

        private void Btn_reset_Click(object sender, EventArgs e)
        {
            Txt_yazi.ResetFont();   // font ayarları orijinal varsayılan değerlerine dönüyor
            FontBilgisi();
        }
    }
}
