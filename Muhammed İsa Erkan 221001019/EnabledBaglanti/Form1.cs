namespace EnabledBaglanti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;
            label1.Text = "Durum: bağlı";
            MessageBox.Show("Programla bağlantı sağlandı", "Bağlantı durumu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button1.Enabled = true;
            label1.Text = "Durum: bağlı değil";
            MessageBox.Show("Programla olan bağlantı sonlandı", "Bağlantı durumu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
