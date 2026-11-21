namespace DockOrnegi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ifadeler = { "Yok", "Sağa", "Sola", "Üste", "Alta", "İçine" };
            // ifadeler dizisindeki tüm elemanlar bir seferde comboBox kontrollerine aktarılıyor
            comboBox1.Items.AddRange(ifadeler);
            comboBox2.Items.AddRange(ifadeler);
            comboBox3.Items.AddRange(ifadeler);
        }

        // 3 comboBoxun SelectedIndexChanged olayı birleştirilmiştir.
        // Parent ifadesi comboBox kontrolünün bulunduğu groupBox kontrolünü verir.
        private void dock_ayarlari(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.Text == "Yok")
                cb.Parent.Dock = DockStyle.None;
            else if (cb.Text == "Sağa")
                cb.Parent.Dock = DockStyle.Right;
            else if (cb.Text == "Sola")
                cb.Parent.Dock = DockStyle.Left;
            else if (cb.Text == "Üste")
                cb.Parent.Dock = DockStyle.Top;
            else if (cb.Text == "Alta")
                cb.Parent.Dock = DockStyle.Bottom;
            else if (cb.Text == "İçine")
                cb.Parent.Dock = DockStyle.Fill;
        }
    }
}
