namespace MesajPencereleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Visual C#.Net 2008");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Visual C#.Net 2008", "Hoşgeldin");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Çıkmak istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNoCancel);
            label1.Text = "Seçilen düğme: " + sonuc.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Çıkmak istediğinizden emin misiniz?", "Onay",
                MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning);
            label1.Text = "Seçilen düğme: " + sonuc.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Çıkmak istediğinizden emin misiniz?", "Onay",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            label1.Text = "Seçilen düğme: " + sonuc.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Dosya silinsin mi?", "Onay",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            label1.Text = "Seçilen düğme: " + sonuc.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult a;
            a = MessageBox.Show("Form kapatılsın mı?", "Onay", MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (a == DialogResult.Yes)
                this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = MessageBox.Show("İşlemin çalışması çok uzun sürecektir. Devam edilsin mi?", "Onay",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (cevap == DialogResult.Yes)
            {
                decimal sayi = 0;
                for (int i = 0; i < 10000000; i++)
                    sayi = sayi + i;
                MessageBox.Show("Sonuç= " + sayi.ToString(), "İşlem sonucu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İşlemin çalışması çok uzun sürecektir.\r\n" +
                            "Bunun sonucunda aşağıdaki sorunlarla karşılaşabilirsiniz\r\n" +
                            "1- Bilgisayarınız kilitlenebilir\r\n" +
                            "2- İşlem bitene kadar beklemek zorunda kalabilirsiniz\r\n" +
                            "3- Program kendini kapatabilir", "Onay",
                            MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
        }
    }
}
