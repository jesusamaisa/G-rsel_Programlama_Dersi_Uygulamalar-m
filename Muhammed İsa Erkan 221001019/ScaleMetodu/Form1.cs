namespace ScaleMetodu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float mevcut_oran = 1f;

        private void Form1_Load(object sender, EventArgs e)
        {
            // form ilk ekrana gelirken orana ait değerlerin comboBox kontrolüne yazdırılması sağlanıyor
            for (int i = 50; i <= 200; i += 10)
                comboBox1.Items.Add("%" + i.ToString());
            comboBox1.SelectedIndex = comboBox1.Items.IndexOf("%100");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // comboBox kontrolünde yer alan değerlerin başındaki % ifadesinin olmaması için 1.noktadan sonraki kısımlar alınarak
            // float tipine dönüştürülüyor
            float yeni_oran = float.Parse(comboBox1.Text.Substring(1)) / 100;
            // Scale her çağrıldığında mevcut boyuta göre ölçeklediği için önceki orana bölünür
            this.Scale(new SizeF(yeni_oran / mevcut_oran, yeni_oran / mevcut_oran));
            mevcut_oran = yeni_oran;
        }
    }
}
