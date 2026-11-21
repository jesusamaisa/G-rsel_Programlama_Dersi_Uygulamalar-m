namespace ButonHizalama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Aşağıdaki 3 ayrı kod bloğuyla aynı işlemler gerçekleştirilebilir
        private void button3_Click(object sender, EventArgs e)
        {
            // Left Top Width Height özellikleriyle hizalama
            button2.Left = button1.Left;
            button2.Top = button1.Top + button1.Height + 20;
            button2.Width = button1.Width;
            button2.Height = button1.Height;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Aynı işlem SetBounds metodu ile de yapılabilir.
            button2.SetBounds(button1.Left, button1.Top + button1.Height + 20, button1.Width, button1.Height);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Aynı işlem Location ve Size ile de yapılabilir.
            button2.Location = new Point(button1.Left, button1.Top + button1.Height + 20);
            button2.Size = new Size(button1.Width, button1.Height);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button2.SetBounds(220, 150, 90, 25);
        }
    }
}
