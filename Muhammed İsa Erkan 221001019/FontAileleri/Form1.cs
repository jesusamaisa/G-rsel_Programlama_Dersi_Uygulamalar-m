namespace FontAileleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FontFamily[] fontlar = FontFamily.Families;
            for (int i = 0; i < fontlar.Length; i++)
                listBox_fontlar.Items.Add(fontlar[i].Name);
        }

        private void listBox_fontlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Txt_yazi.Font = new Font(listBox_fontlar.Text, 16, FontStyle.Regular);
            }
            catch
            {
                MessageBox.Show("Bu font görüntülenemiyor");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }
    }
}
