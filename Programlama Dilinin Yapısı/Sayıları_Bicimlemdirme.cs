// Sayiyi para birimi þeklinde göstermek için C

private void button1_Click(object sender, EventArgs e)
{
    double sayi;
    sayi = 128000000;
    MessageBox.Show(sayi.ToString("C"));

}

// Sayilarý ondalýklarýný kaldýrma C_sayi

private void button1_Click(object sender, EventArgs e)
{
    double sayi;
    sayi = 128000000;
    MessageBox.Show(sayi.ToString("C0"));

}

// Sayýnýn binlik basamaklara ayrýlmasýný saðlar N para birimi eklemez

private void button1_Click(object sender, EventArgs e)
{
    double sayi;
    sayi = 128000000;
    MessageBox.Show(sayi.ToString("N"));

}

// Binlik ayýrýr ve yazýlan sayý deðeri kadar ondalýk gösterim yapar

private void button1_Click(object sender, EventArgs e)
{
    double sayi;
    sayi = 128000000;
    MessageBox.Show(sayi.ToString("N0"));

}

// 16lýk tabanda gösterim X

private void button1_Click(object sender, EventArgs e)
{
    double sayi;
    sayi = 128000000;
    MessageBox.Show(sayi.ToString("X"));

}

// hexadecimal belirli sayý hanessi gösterimi X_sayý

private void button1_Click(object sender, EventArgs e)
{
    double sayi;
    sayi = 128000000;
    MessageBox.Show(sayi.ToString("X4"));

}

// Özel Format ifadeleri

private void button1_Click(object sender, EventArgs e)
{
    long telno;
    telno = Convert.ToInt64(textBox1.Text);
    textBox2.Text = telno.ToString("+## (###) ### ## ##");

}
