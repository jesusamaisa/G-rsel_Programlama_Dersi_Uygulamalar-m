using System.Globalization;

namespace VisualCSharpUygulamalari;

public static class StringSayiCevirimVeTabanlar
{
    public static KonuGrubu Grup()
    {
        var g = new KonuGrubu("4. String-Sayı Çevrimi ve Taban Dönüşümleri");
        g.Ornekler.Add(new OrnekBilgisi(27, "Parse ile String İfadeyi Sayıya Çevirme", () => new Ornek027()));
        g.Ornekler.Add(new OrnekBilgisi(28, "TryParse ile Hatasız Dönüşüm Kontrolü", () => new Ornek028()));
        g.Ornekler.Add(new OrnekBilgisi(29, "NumberStyles ile Para/Yüzde Formatlı Metni Sayıya Çevirme", () => new Ornek029()));
        g.Ornekler.Add(new OrnekBilgisi(30, "Hexadecimal (0x) Sayı Literali ile Değişken Atama", () => new Ornek030()));
        g.Ornekler.Add(new OrnekBilgisi(31, "Bir Sayıyı Farklı Tabana Çevirme (Convert.ToString)", () => new Ornek031()));
        g.Ornekler.Add(new OrnekBilgisi(32, "Farklı Tabandaki Bir String İfadeyi Sayıya Çevirme", () => new Ornek032()));
        return g;
    }
}

file class Ornek027 : OrnekFormBase
{
    public Ornek027() : base("Örnek 027 - Parse ile String İfadeyi Sayıya Çevirme",
        "int.Parse, decimal.Parse gibi metotlarla yazı (string) biçimindeki bir sayı, sayısal tipe dönüştürülür.")
    {
        var s1 = Satir(); s1.Controls.Add(YeniEtiket("Tam sayı metni:")); var txtInt = YeniKutu(150, "123"); s1.Controls.Add(txtInt);
        var s2 = Satir(); s2.Controls.Add(YeniEtiket("Ondalık sayı metni:")); var txtDec = YeniKutu(150, "123,45"); s2.Controls.Add(txtDec);
        IcerikPanel.Controls.Add(s1);
        IcerikPanel.Controls.Add(s2);
        IcerikPanel.Controls.Add(YeniDugme("Parse Et", (_, _) =>
        {
            Temizle();
            try
            {
                int i = int.Parse(txtInt.Text);
                Yaz($"int.Parse(\"{txtInt.Text}\") -> {i}");
            }
            catch (FormatException)
            {
                Yaz($"HATA: \"{txtInt.Text}\" geçerli bir tam sayı formatında değil.");
            }
            try
            {
                decimal d = decimal.Parse(txtDec.Text);
                Yaz($"decimal.Parse(\"{txtDec.Text}\") -> {d}");
            }
            catch (FormatException)
            {
                Yaz($"HATA: \"{txtDec.Text}\" geçerli bir ondalık sayı formatında değil.");
            }
        }));
    }
}

file class Ornek028 : OrnekFormBase
{
    public Ornek028() : base("Örnek 028 - TryParse ile Hatasız Dönüşüm Kontrolü",
        "Parse metodunun aksine TryParse, hatalı girişte programı patlatmaz; dönüşümün başarılı olup olmadığını true/false olarak bildirir.")
    {
        var satir = Satir();
        satir.Controls.Add(YeniEtiket("Yaş giriniz:"));
        var kutu = YeniKutu(150, "yirmi");
        satir.Controls.Add(kutu);
        IcerikPanel.Controls.Add(satir);
        IcerikPanel.Controls.Add(YeniDugme("TryParse ile Dene", (_, _) =>
        {
            Temizle();
            bool basarili = int.TryParse(kutu.Text, out int yas);
            if (basarili)
                Yaz($"Başarılı: Girdiğiniz yaş = {yas}");
            else
                Yaz($"Başarısız: \"{kutu.Text}\" bir tam sayı değil. (Program hata vermedi, akıllıca kontrol edildi.)");
        }));
    }
}

file class Ornek029 : OrnekFormBase
{
    public Ornek029() : base("Örnek 029 - NumberStyles ile Özel Formatlı Metni Sayıya Çevirme",
        "decimal.Parse(metin, NumberStyles.Currency, CultureInfo) kullanılarak '₺1.250,50' gibi para formatındaki bir metin sayıya çevrilir.")
    {
        var satir = Satir();
        satir.Controls.Add(YeniEtiket("Para metni:"));
        var kutu = YeniKutu(150, "1.250,50");
        satir.Controls.Add(kutu);
        IcerikPanel.Controls.Add(satir);
        IcerikPanel.Controls.Add(YeniDugme("Sayıya Çevir (tr-TR)", (_, _) =>
        {
            Temizle();
            try
            {
                var trKultur = new CultureInfo("tr-TR");
                decimal d = decimal.Parse(kutu.Text, NumberStyles.Number, trKultur);
                Yaz($"decimal.Parse(\"{kutu.Text}\", NumberStyles.Number, tr-TR) -> {d}");
            }
            catch (FormatException)
            {
                Yaz("HATA: Girilen metin tr-TR kültürüne göre geçerli bir sayı formatında değil.");
            }
        }));
    }
}

file class Ornek030 : OrnekFormBase
{
    public Ornek030() : base("Örnek 030 - Hexadecimal (0x) Sayı Literali",
        "Bir sayının hexadecimal (16'lık taban) biçiminde yazıldığını belirtmek için sayının önüne '0x' ifadesi eklenir.")
    {
        IcerikPanel.Controls.Add(YeniDugme("0x Literallerini Göster", (_, _) =>
        {
            Temizle();
            int a = 0xFF;
            int b = 0x1A;
            int c = 0x100;
            Yaz($"int a = 0xFF;   ->  a = {a}  (decimal karşılığı)");
            Yaz($"int b = 0x1A;   ->  b = {b}");
            Yaz($"int c = 0x100;  ->  c = {c}");
        }));
    }
}

file class Ornek031 : OrnekFormBase
{
    public Ornek031() : base("Örnek 031 - Bir Sayıyı Farklı Tabana Çevirme",
        "Convert.ToString(sayı, taban) metodu ile 10'luk tabandaki bir sayı 2'lik (binary), 8'lik (octal) veya 16'lık (hex) tabana çevrilir.")
    {
        var satir = Satir();
        satir.Controls.Add(YeniEtiket("10'luk tabanda sayı:"));
        var kutu = YeniKutu(150, "100");
        satir.Controls.Add(kutu);
        IcerikPanel.Controls.Add(satir);
        IcerikPanel.Controls.Add(YeniDugme("Tabanları Göster", (_, _) =>
        {
            Temizle();
            if (!int.TryParse(kutu.Text, out int sayi)) { Yaz("Geçerli bir tam sayı giriniz."); return; }
            Yaz($"{sayi} (10'luk)  -> 2'lik  (binary) : {Convert.ToString(sayi, 2)}");
            Yaz($"{sayi} (10'luk)  -> 8'lik  (octal)  : {Convert.ToString(sayi, 8)}");
            Yaz($"{sayi} (10'luk)  -> 16'lık (hex)    : {Convert.ToString(sayi, 16)}");
        }));
    }
}

file class Ornek032 : OrnekFormBase
{
    public Ornek032() : base("Örnek 032 - Farklı Tabandaki Bir String İfadeyi Sayıya Çevirme",
        "Convert.ToInt32(metin, taban) metodu ile 2'lik, 8'lik veya 16'lık tabanda yazılmış bir metin, 10'luk tabana (normal sayıya) çevrilir.")
    {
        var s1 = Satir(); s1.Controls.Add(YeniEtiket("Binary metin:")); var txtBin = YeniKutu(150, "1100100"); s1.Controls.Add(txtBin);
        var s2 = Satir(); s2.Controls.Add(YeniEtiket("Hex metin:")); var txtHex = YeniKutu(150, "64"); s2.Controls.Add(txtHex);
        IcerikPanel.Controls.Add(s1);
        IcerikPanel.Controls.Add(s2);
        IcerikPanel.Controls.Add(YeniDugme("10'luk Tabana Çevir", (_, _) =>
        {
            Temizle();
            try
            {
                int binSonuc = Convert.ToInt32(txtBin.Text, 2);
                Yaz($"Convert.ToInt32(\"{txtBin.Text}\", 2) -> {binSonuc}");
            }
            catch (FormatException) { Yaz("Binary metin geçersiz (sadece 0 ve 1 içermeli)."); }

            try
            {
                int hexSonuc = Convert.ToInt32(txtHex.Text, 16);
                Yaz($"Convert.ToInt32(\"{txtHex.Text}\", 16) -> {hexSonuc}");
            }
            catch (FormatException) { Yaz("Hex metin geçersiz (0-9, A-F karakterlerini içermeli)."); }
        }));
    }
}
