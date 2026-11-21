private void button1_Click(object sender, EventArgs e)
{
    byte x = 250;
    x += 6;
    MessageBox.Show(x.ToString(), "x'in deðeri"); 
}

//  X'in deðerini 100 artýralým

private void button1_Click(object sender, EventArgs e)
{
    byte x = 250;
    x += 100;
    MessageBox.Show(x.ToString(), "x'in deðeri");
}

// Deðer oluþumunda hata mesajý gösterimi Checked ile

private void button1_Click(object sender, EventArgs e)
{
    int x = 250000000000;
    x = checked(x * 100000000);
    MessageBox.Show(x.ToString(), "x'in deðeri");
}