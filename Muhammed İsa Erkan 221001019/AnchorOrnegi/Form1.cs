namespace AnchorOrnegi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AnchorAyarla(true);
        }

        private void AnchorAyarla(bool aktif)
        {
            if (aktif)
            {
                panel_sol.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
                panel_ust.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                panel_sag.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
                textBox1.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
                checkBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            }
            else
            {
                // varsayılan Anchor değeri Top Lefttir form büyüse de kontroller aynı yerde kalır
                panel_sol.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                panel_ust.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                panel_sag.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                checkBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            AnchorAyarla(checkBox1.Checked);
        }
    }
}
