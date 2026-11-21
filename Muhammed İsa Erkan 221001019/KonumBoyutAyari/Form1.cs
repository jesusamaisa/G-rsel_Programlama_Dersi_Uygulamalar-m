namespace KonumBoyutAyari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // textBox kontrolünün boyutlarının değişebilmesi için Multiline özelliğinin true olması lazım.
            textBox1.Multiline = true;
            // koordinat değerleri 0-500 arasında değişmesi
            numericUpDown_sol.Maximum = 500;
            numericUpDown_ust.Maximum = 500;
            numericUpDown_genislik.Maximum = 500;
            numericUpDown_yukseklik.Maximum = 500;
            // textBox kontrolünün mevcut durumdaki koordinat değerlerinin NumericUpDown kontrollerine yüklenmesi
            numericUpDown_sol.Value = textBox1.Left;
            numericUpDown_ust.Value = textBox1.Top;
            numericUpDown_genislik.Value = textBox1.Width;
            numericUpDown_yukseklik.Value = textBox1.Height;
        }

        private void numericUpDown_sol_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Left = (int)numericUpDown_sol.Value;   // sol koordinat ayarı
        }

        private void numericUpDown_ust_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Top = (int)numericUpDown_ust.Value;    // üst koordinat ayarı
        }

        private void numericUpDown_genislik_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Width = (int)numericUpDown_genislik.Value;   // genişlik ayarı
        }

        private void numericUpDown_yukseklik_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Height = (int)numericUpDown_yukseklik.Value;   // yükseklik ayarı
        }
    }
}
