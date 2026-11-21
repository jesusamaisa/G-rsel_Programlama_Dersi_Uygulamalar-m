namespace ZiplayanTop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sx = 5, sy = 5;   // yatay ve dikey artış miktarları

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 20;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // formun üstüne veya altına ulaşıldıysa artış yönü ters çevriliyor
            if (radioButton1.Top <= 0 || radioButton1.Bottom >= this.ClientSize.Height)
                sy = -sy;
            // formun soluna veya sağına ulaşıldıysa artış yönü ters çevriliyor
            if (radioButton1.Left <= 0 || radioButton1.Right >= this.ClientSize.Width)
                sx = -sx;
            radioButton1.Left += sx;
            radioButton1.Top += sy;
        }
    }
}
