namespace FontAileleri
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            FontFamily[] fontlar = FontFamily.GetFamilies(e.Graphics);
            Font fnt = null;
            float x = 0, y = 0;
            string ifade;
            for (int i = 0; i < fontlar.Length; i++)
            {
                try
                {
                    fnt = new Font(fontlar[i].Name, 10, FontStyle.Regular);
                    ifade = fontlar[i].Name;
                }
                catch
                {
                    fnt = new Font("Arial", 10, FontStyle.Regular);
                    ifade = fontlar[i].Name + " bu font görüntülenemedi";
                }
                e.Graphics.DrawString(ifade, fnt, Brushes.Black, x, y);
                y += fnt.Height;
                fnt.Dispose();
                // her sütuna 30 tane font yazılsın
                if ((i + 1) % 30 == 0)
                {
                    x = x + 200;
                    y = 0;
                }
            }
        }
    }
}
