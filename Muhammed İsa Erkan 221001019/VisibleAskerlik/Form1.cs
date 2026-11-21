namespace VisibleAskerlik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int yas;

        private void AskerlikGoster(bool durum)
        {
            label4.Visible = durum;
            label5.Visible = durum;
            label6.Visible = durum;
            textBox3.Visible = durum;
            textBox4.Visible = durum;
            textBox5.Visible = durum;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AskerlikGoster(false);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // Bay ifadesinin olduğu radioButton seçili olduğunda ve yaşın textBox kontrolündeki
            // sayı değeri 30 dan küçükse if bloğu devreye giriyor
            int.TryParse(textBox2.Text, out yas);
            if ((radioButton1.Checked == true) && (yas < 30))
                AskerlikGoster(true);
            else
                AskerlikGoster(false);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            // Bayan ifadesinin olduğu radioButton seçili olduğunda yaş değerine bakılmadan if bloğu devreye giriyor
            if (radioButton2.Checked == true)
                AskerlikGoster(false);
        }
    }
}
