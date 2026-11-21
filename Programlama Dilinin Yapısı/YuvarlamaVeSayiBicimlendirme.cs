namespace VisualCSharpUygulamalari;

public static class YuvarlamaVeSayiBicimlendirme
{
    public static KonuGrubu Grup()
    {
        var g = new KonuGrubu("3. Sayıları Yuvarlama ve Biçimlendirme");
        g.Ornekler.Add(new OrnekBilgisi(13, "Math.Round ile Sayı Yuvarlama", () => new Ornek013()));
        g.Ornekler.Add(new OrnekBilgisi(14, "'C' Formatı - Para Birimi Gösterimi", () => new Ornek014()));
        g.Ornekler.Add(new OrnekBilgisi(15, "'C0' Formatı - Ondalıksız Para Gösterimi", () => new Ornek015()));
        g.Ornekler.Add(new OrnekBilgisi(16, "'N' Formatı - Binlik Ayraçlı Gösterim", () => new Ornek016()));
        g.Ornekler.Add(new OrnekBilgisi(17, "'N_sayı' Formatı - Ondalık Basamak Sayısı Belirleme", () => new Ornek017()));
        g.Ornekler.Add(new OrnekBilgisi(18, "'E' Formatı - Bilimsel (Üstel) Gösterim", () => new Ornek018()));
        g.Ornekler.Add(new OrnekBilgisi(19, "'E_sayı' Formatı - Basamak Sayısı Ayarlama", () => new Ornek019()));
        g.Ornekler.Add(new OrnekBilgisi(20, "'F_sayı' Formatı - Sabit Ondalık Basamak", () => new Ornek020()));
        g.Ornekler.Add(new OrnekBilgisi(21, "'P' Formatı - Yüzde Gösterimi", () => new Ornek021()));
        g.Ornekler.Add(new OrnekBilgisi(22, "'X' Formatı - Hexadecimal (16'lık Taban) Gösterim", () => new Ornek022()));
        g.Ornekler.Add(new OrnekBilgisi(23, "'X_sayı' Formatı - Hane Sayısı Belirleme", () => new Ornek023()));
        g.Ornekler.Add(new OrnekBilgisi(24, "'0' Formatı - Sıfır ile Doldurma (Zero Padding)", () => new Ornek024()));
        g.Ornekler.Add(new OrnekBilgisi(25, "Tüm Sayı Formatlarının Tek Ekranda Karşılaştırılması", () => new Ornek025()));
        g.Ornekler.Add(new OrnekBilgisi(26, "Telefon Numarasını Otomatik Biçimlendirme", () => new Ornek026()));
        return g;
    }
}

file class Ornek013 : OrnekFormBase
{
    public Ornek013() : base("Örnek 013 - Math.Round ile Sayı Yuvarlama",
        "Math.Round(sayı, basamak_sayısı) fonksiyonu ile ondalıklı bir sayı istenen basamağa yuvarlanır.")
    {
        var satir = Satir();
        satir.Controls.Add(YeniEtiket("Sayı:"));
        var kutuSayi = YeniKutu(140, "3.14159265");
        satir.Controls.Add(kutuSayi);
        satir.Controls.Add(YeniEtiket("Basamak:", 70));
        var kutuBasamak = YeniKutu(60, "2");
        satir.Controls.Add(kutuBasamak);
        IcerikPanel.Controls.Add(satir);
        IcerikPanel.Controls.Add(YeniDugme("Yuvarla", (_, _) =>
        {
            Temizle();
            if (!double.TryParse(kutuSayi.Text, out double sayi) || !int.TryParse(kutuBasamak.Text, out int basamak))
            {
                Yaz("Lütfen geçerli değerler giriniz.");
                return;
            }
            Yaz($"Math.Round({sayi}, {basamak}) = {Math.Round(sayi, basamak)}");
            Yaz($"Math.Round({sayi}, 0) = {Math.Round(sayi, 0)}");
            Yaz($"Math.Round({sayi}, 4) = {Math.Round(sayi, 4)}");
        }));
    }
}

file class Ornek014 : OrnekFormBase
{
    public Ornek014() : base("Örnek 014 - 'C' Formatı: Para Birimi Gösterimi",
        "değişken.ToString(\"C\") kullanılarak sayı, işletim sistemi kültür ayarına göre para birimi formatında gösterilir.")
    {
        var satir = Satir();
        satir.Controls.Add(YeniEtiket("Tutar:"));
        var kutu = YeniKutu(160, "1500");
        satir.Controls.Add(kutu);
        IcerikPanel.Controls.Add(satir);
        IcerikPanel.Controls.Add(YeniDugme("'C' Formatında Göster", (_, _) =>
        {
            Temizle();
            if (!decimal.TryParse(kutu.Text, out decimal tutar)) { Yaz("Geçerli bir sayı giriniz."); return; }
            Yaz($"{tutar}.ToString(\"C\")  ->  {tutar.ToString("C")}");
            Yaz("(Girilen sayı tam sayı olsa bile, sistem ayarına göre otomatik olarak ondalıklı para formatında gösterilir.)");
        }));
    }
}

file class Ornek015 : OrnekFormBase
{
    public Ornek015() : base("Örnek 015 - 'C0' Formatı: Ondalıksız Para Gösterimi",
        "'C' formatına eklenen 0 sayısı, virgülden sonraki basamakların gösterilmemesini sağlar.")
    {
        var satir = Satir();
        satir.Controls.Add(YeniEtiket("Tutar:"));
        var kutu = YeniKutu(160, "1500.75");
        satir.Controls.Add(kutu);
        IcerikPanel.Controls.Add(satir);
        IcerikPanel.Controls.Add(YeniDugme("'C0' Formatında Göster", (_, _) =>
        {
            Temizle();
            if (!decimal.TryParse(kutu.Text, out decimal tutar)) { Yaz("Geçerli bir sayı giriniz."); return; }
            Yaz($"{tutar}.ToString(\"C\")   ->  {tutar.ToString("C")}");
            Yaz($"{tutar}.ToString(\"C0\")  ->  {tutar.ToString("C0")}");
        }));
    }
}

file class Ornek016 : OrnekFormBase
{
    public Ornek016() : base("Örnek 016 - 'N' Formatı: Binlik Ayraçlı Gösterim",
        "'N' formatı sayıyı binlik basamaklara ayırır, ancak 'C' formatından farklı olarak para birimi eklemez.")
    {
        var satir = Satir();
        satir.Controls.Add(YeniEtiket("Sayı:"));
        var kutu = YeniKutu(160, "1234567");
        satir.Controls.Add(kutu);
        IcerikPanel.Controls.Add(satir);
        IcerikPanel.Controls.Add(YeniDugme("'N' Formatında Göster", (_, _) =>
        {
            Temizle();
            if (!double.TryParse(kutu.Text, out double sayi)) { Yaz("Geçerli bir sayı giriniz."); return; }
            Yaz($"{sayi}.ToString(\"N\")  ->  {sayi.ToString("N")}");
        }));
    }
}

file class Ornek017 : OrnekFormBase
{
    public Ornek017() : base("Örnek 017 - 'N_sayı' Formatı: Ondalık Basamak Sayısı Belirleme",
        "'N' formatına eklenen sayı, gösterilecek ondalık basamak adedini belirler.")
    {
        var satir = Satir();
        satir.Controls.Add(YeniEtiket("Sayı:"));
        var kutu = YeniKutu(160, "1234567.8912");
        satir.Controls.Add(kutu);
        IcerikPanel.Controls.Add(satir);
        IcerikPanel.Controls.Add(YeniDugme("Karşılaştır (N0, N2, N4)", (_, _) =>
        {
            Temizle();
            if (!double.TryParse(kutu.Text, out double sayi)) { Yaz("Geçerli bir sayı giriniz."); return; }
            Yaz($"{sayi}.ToString(\"N0\")  ->  {sayi.ToString("N0")}");
            Yaz($"{sayi}.ToString(\"N2\")  ->  {sayi.ToString("N2")}");
            Yaz($"{sayi}.ToString(\"N4\")  ->  {sayi.ToString("N4")}");
        }));
    }
}

file class Ornek018 : OrnekFormBase
{
    public Ornek018() : base("Örnek 018 - 'E' Formatı: Bilimsel (Üstel) Gösterim",
        "'E' formatı tam veya ondalık sayıları 10 üzeri (bilimsel/üstel) biçimde gösterir.")
    {
        var satir = Satir();
        satir.Controls.Add(YeniEtiket("Sayı:"));
        var kutu = YeniKutu(160, "123456.789");
        satir.Controls.Add(kutu);
        IcerikPanel.Controls.Add(satir);
        IcerikPanel.Controls.Add(YeniDugme("'E' Formatında Göster", (_, _) =>
        {
            Temizle();
            if (!double.TryParse(kutu.Text, out double sayi)) { Yaz("Geçerli bir sayı giriniz."); return; }
            Yaz($"{sayi}.ToString(\"E\")  ->  {sayi.ToString("E")}");
        }));
    }
}

file class Ornek019 : OrnekFormBase
{
    public Ornek019() : base("Örnek 019 - 'E_sayı' Formatı: Basamak Sayısı Ayarlama",
        "'E' formatına eklenen sayı, üstel ifadenin ondalık kısmındaki basamak adedini belirler.")
    {
        var satir = Satir();
        satir.Controls.Add(YeniEtiket("Sayı:"));
        var kutu = YeniKutu(160, "123456.789");
        satir.Controls.Add(kutu);
        IcerikPanel.Controls.Add(satir);
        IcerikPanel.Controls.Add(YeniDugme("Karşılaştır (E2, E4)", (_, _) =>
        {
            Temizle();
            if (!double.TryParse(kutu.Text, out double sayi)) { Yaz("Geçerli bir sayı giriniz."); return; }
            Yaz($"{sayi}.ToString(\"E2\")  ->  {sayi.ToString("E2")}");
            Yaz($"{sayi}.ToString(\"E4\")  ->  {sayi.ToString("E4")}");
        }));
    }
}

file class Ornek020 : OrnekFormBase
{
    public Ornek020() : base("Örnek 020 - 'F_sayı' Formatı: Sabit Ondalık Basamak",
        "'F' formatı, sayının virgülden sonraki basamak sayısını sabit olarak belirlemeyi sağlar.")
    {
        var satir = Satir();
        satir.Controls.Add(YeniEtiket("Sayı:"));
        var kutu = YeniKutu(160, "3.14159");
        satir.Controls.Add(kutu);
        IcerikPanel.Controls.Add(satir);
        IcerikPanel.Controls.Add(YeniDugme("Karşılaştır (F0, F2, F4)", (_, _) =>
        {
            Temizle();
            if (!double.TryParse(kutu.Text, out double sayi)) { Yaz("Geçerli bir sayı giriniz."); return; }
            Yaz($"{sayi}.ToString(\"F0\")  ->  {sayi.ToString("F0")}");
            Yaz($"{sayi}.ToString(\"F2\")  ->  {sayi.ToString("F2")}");
            Yaz($"{sayi}.ToString(\"F4\")  ->  {sayi.ToString("F4")}");
        }));
    }
}

file class Ornek021 : OrnekFormBase
{
    public Ornek021() : base("Örnek 021 - 'P' Formatı: Yüzde Gösterimi",
        "'P' formatı 0 ile 1 arasındaki bir ondalık sayıyı yüzde (%) olarak gösterir.")
    {
        var satir = Satir();
        satir.Controls.Add(YeniEtiket("Oran (0-1 arası):"));
        var kutu = YeniKutu(160, "0.4567");
        satir.Controls.Add(kutu);
        IcerikPanel.Controls.Add(satir);
        IcerikPanel.Controls.Add(YeniDugme("'P' Formatında Göster", (_, _) =>
        {
            Temizle();
            if (!double.TryParse(kutu.Text, out double sayi)) { Yaz("Geçerli bir sayı giriniz."); return; }
            Yaz($"{sayi}.ToString(\"P\")   ->  {sayi.ToString("P")}");
            Yaz($"{sayi}.ToString(\"P1\")  ->  {sayi.ToString("P1")}");
        }));
    }
}

file class Ornek022 : OrnekFormBase
{
    public Ornek022() : base("Örnek 022 - 'X' Formatı: Hexadecimal (16'lık Taban) Gösterim",
        "'X' formatı bir tam sayıyı 16'lık tabanda (hexadecimal) gösterir.")
    {
        var satir = Satir();
        satir.Controls.Add(YeniEtiket("Tam sayı:"));
        var kutu = YeniKutu(160, "255");
        satir.Controls.Add(kutu);
        IcerikPanel.Controls.Add(satir);
        IcerikPanel.Controls.Add(YeniDugme("'X' Formatında Göster", (_, _) =>
        {
            Temizle();
            if (!int.TryParse(kutu.Text, out int sayi)) { Yaz("Geçerli bir tam sayı giriniz."); return; }
            Yaz($"{sayi}.ToString(\"X\")  ->  {sayi.ToString("X")}");
            Yaz($"{sayi}.ToString(\"x\")  ->  {sayi.ToString("x")}  (küçük harf)");
        }));
    }
}

file class Ornek023 : OrnekFormBase
{
    public Ornek023() : base("Örnek 023 - 'X_sayı' Formatı: Hane Sayısı Belirleme",
        "'X' formatına eklenen sayı, hexadecimal gösterimin minimum hane sayısını belirler (eksik haneler 0 ile doldurulur).")
    {
        var satir = Satir();
        satir.Controls.Add(YeniEtiket("Tam sayı:"));
        var kutu = YeniKutu(160, "255");
        satir.Controls.Add(kutu);
        IcerikPanel.Controls.Add(satir);
        IcerikPanel.Controls.Add(YeniDugme("Karşılaştır (X4, X8)", (_, _) =>
        {
            Temizle();
            if (!int.TryParse(kutu.Text, out int sayi)) { Yaz("Geçerli bir tam sayı giriniz."); return; }
            Yaz($"{sayi}.ToString(\"X4\")  ->  {sayi.ToString("X4")}");
            Yaz($"{sayi}.ToString(\"X8\")  ->  {sayi.ToString("X8")}");
        }));
    }
}

file class Ornek024 : OrnekFormBase
{
    public Ornek024() : base("Örnek 024 - '0' Formatı: Sıfır ile Doldurma",
        "'0' karakteri, sayının önünde istenen sayıda sıfır gösterilmesini sağlar (örn. sipariş/fiş numarası).")
    {
        var satir = Satir();
        satir.Controls.Add(YeniEtiket("Sipariş No:"));
        var kutu = YeniKutu(160, "42");
        satir.Controls.Add(kutu);
        IcerikPanel.Controls.Add(satir);
        IcerikPanel.Controls.Add(YeniDugme("6 Haneli Göster", (_, _) =>
        {
            Temizle();
            if (!int.TryParse(kutu.Text, out int sayi)) { Yaz("Geçerli bir tam sayı giriniz."); return; }
            Yaz($"{sayi}.ToString(\"000000\")  ->  {sayi.ToString("000000")}");
            Yaz($"'SPR-' + {sayi}.ToString(\"000000\")  ->  SPR-{sayi:000000}");
        }));
    }
}

file class Ornek025 : OrnekFormBase
{
    public Ornek025() : base("Örnek 025 - Tüm Sayı Formatlarının Karşılaştırılması",
        "C, N, E, F, P, X formatlarının aynı sayı için ürettiği sonuçlar tek ekranda listelenir.")
    {
        var satir = Satir();
        satir.Controls.Add(YeniEtiket("Sayı:"));
        var kutu = YeniKutu(160, "1234.5678");
        satir.Controls.Add(kutu);
        IcerikPanel.Controls.Add(satir);
        IcerikPanel.Controls.Add(YeniDugme("Tüm Formatları Göster", (_, _) =>
        {
            Temizle();
            if (!double.TryParse(kutu.Text, out double sayi)) { Yaz("Geçerli bir sayı giriniz."); return; }
            Yaz($"C (Para)    : {sayi:C}");
            Yaz($"N (Binlik)  : {sayi:N}");
            Yaz($"E (Üstel)   : {sayi:E2}");
            Yaz($"F (Sabit)   : {sayi:F2}");
            Yaz($"P (Yüzde)   : {sayi:P2}");
            if (double.IsInteger(sayi) || sayi == Math.Truncate(sayi))
                Yaz($"X (Hex)     : {(long)sayi:X}");
        }));
    }
}

file class Ornek026 : OrnekFormBase
{
    public Ornek026() : base("Örnek 026 - Telefon Numarasını Otomatik Biçimlendirme",
        "Peş peşe girilen 10-11 haneli bir telefon numarası, 0(5XX) XXX XX XX şeklinde biçimlendirilir.")
    {
        var s1 = Satir(); s1.Controls.Add(YeniEtiket("Telefon (örn: 05321234567):")); var txtGiris = YeniKutu(180); s1.Controls.Add(txtGiris);
        IcerikPanel.Controls.Add(s1);
        var txtSonuc = YeniKutu(220);
        txtSonuc.ReadOnly = true;
        var s2 = Satir(); s2.Controls.Add(YeniEtiket("Biçimlendirilmiş hâli:")); s2.Controls.Add(txtSonuc);
        IcerikPanel.Controls.Add(s2);
        IcerikPanel.Controls.Add(YeniDugme("Biçimlendir", (_, _) =>
        {
            Temizle();
            string ham = new string(txtGiris.Text.Where(char.IsDigit).ToArray());
            if (ham.Length != 11)
            {
                Yaz("Lütfen 0 ile başlayan 11 haneli bir telefon numarası giriniz (örn: 05321234567).");
                return;
            }
            string bicimli = $"0({ham.Substring(1, 3)}) {ham.Substring(4, 3)} {ham.Substring(7, 2)} {ham.Substring(9, 2)}";
            txtSonuc.Text = bicimli;
            Yaz($"Girilen (ham)        : {txtGiris.Text}");
            Yaz($"Biçimlendirilmiş hâli: {bicimli}");
        }));
    }
}
