using vb = Microsoft.VisualBasic.Interaction;

namespace InputBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sinav_notu;
            string giris = Microsoft.VisualBasic.Interaction.InputBox("Sınav notunu girin", "Not Girişi", "", 100, 100);
            if (!int.TryParse(giris, out sinav_notu))
                return;
            if (sinav_notu >= 50)
                MessageBox.Show("Tebrikler. Dersten geçtiniz");
            else
                MessageBox.Show("Üzgünüm. Dersten kaldınız");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            double ortalama;
            int adet;
            // Hocam bu üstteki  using vb = Microsoft.VisualBasic.Interaction kullanarak kısaltmayı yapay zeka önerdi ondan dolayı kullandım
            if (!int.TryParse(vb.InputBox("Eleman sayısı", "Giriş", "5", 100, 100), out adet) || adet <= 0)
                return;
            int[] dizi = new int[adet];
            listBox1.Items.Clear();
            for (int i = 0; i < dizi.Length; i++)
            {
                int.TryParse(vb.InputBox((i + 1) + ". inci sayı", "Dizinin elemanlarını giriniz", "0", 100, 100), out dizi[i]);
                listBox1.Items.Add(dizi[i]);
                toplam += dizi[i];
            }
            ortalama = Convert.ToDouble(toplam) / dizi.Length;
            listBox1.Items.Add("Ortalama: " + ortalama);
        }
    }
}
