namespace VisualCSharpUygulamalari;

public static class BosluklarVeParcalama
{
    public static KonuGrubu Grup()
    {
        var g = new KonuGrubu("7. Boşlukları Atma, Substring ve Split");
        g.Ornekler.Add(new OrnekBilgisi(50, "Trim, TrimStart, TrimEnd ile Boşluk Atma", () => new Ornek050()));
        g.Ornekler.Add(new OrnekBilgisi(51, "Belirli Karakterlerin Trim ile Atılması", () => new Ornek051()));
        g.Ornekler.Add(new OrnekBilgisi(52, "Substring ile String Parçalama", () => new Ornek052()));
        g.Ornekler.Add(new OrnekBilgisi(53, "Kayan Yazı (Marquee) Uygulaması", () => new Ornek053()));
        g.Ornekler.Add(new OrnekBilgisi(54, "Split ile Kelimelere Ayırma", () => new Ornek054()));
        g.Ornekler.Add(new OrnekBilgisi(55, "Split(ayırıcı, adet) ile Sınırlı Parçalama", () => new Ornek055()));
        g.Ornekler.Add(new OrnekBilgisi(56, "CSV Formatındaki Bir Satırı Split ile Ayrıştırma", () => new Ornek056()));
        return g;
    }
}

file class Ornek050 : OrnekFormBase
{
    public Ornek050() : base("Örnek 050 - Trim, TrimStart, TrimEnd ile Boşluk Atma",
        "Kullanıcının yanlışlıkla bıraktığı baş/son boşluklar Trim ailesi metotlarıyla temizlenir.")
    {
        var satir = Satir();
        satir.Controls.Add(YeniEtiket("Metin (başına/sonuna boşluk ekleyin):"));
        var kutu = YeniKutu(220, "   Merhaba Dünya   ");
        satir.Controls.Add(kutu);
        IcerikPanel.Controls.Add(satir);
        IcerikPanel.Controls.Add(YeniDugme("Temizle ve Göster", (_, _) =>
        {
            Temizle();
            Yaz($"Orijinal   : \"{kutu.Text}\"  (Length={kutu.Text.Length})");
            Yaz($"TrimStart()  : \"{kutu.Text.TrimStart()}\"");
            Yaz($"TrimEnd()    : \"{kutu.Text.TrimEnd()}\"");
            Yaz($"Trim()       : \"{kutu.Text.Trim()}\"  (Length={kutu.Text.Trim().Length})");
        }));
    }
}

file class Ornek051 : OrnekFormBase
{
    public Ornek051() : base("Örnek 051 - Belirli Karakterlerin Trim ile Atılması",
        "Trim(karakter) veya TrimEnd(karakter1, karakter2) kullanılarak sadece belirtilen karakterler ifadeden atılır.")
    {
        var satir = Satir();
        satir.Controls.Add(YeniEtiket("Metin:"));
        var kutu = YeniKutu(220, "###Başlık###");
        satir.Controls.Add(kutu);
        IcerikPanel.Controls.Add(satir);
        IcerikPanel.Controls.Add(YeniDugme("'#' Karakterini At", (_, _) =>
        {
            Temizle();
            Yaz($"Orijinal        : \"{kutu.Text}\"");
            Yaz($"Trim('#')       : \"{kutu.Text.Trim('#')}\"");
        }));
        var satir2 = Satir();
        satir2.Controls.Add(YeniEtiket("Tarih metni:"));
        var kutu2 = YeniKutu(220, "13.10.2026..:");
        satir2.Controls.Add(kutu2);
        IcerikPanel.Controls.Add(satir2);
        IcerikPanel.Controls.Add(YeniDugme("'.' ve ':' Karakterlerini Sondan At", (_, _) =>
        {
            Temizle();
            Yaz($"Orijinal              : \"{kutu2.Text}\"");
            Yaz($"TrimEnd('.', ':')     : \"{kutu2.Text.TrimEnd('.', ':')}\"");
        }));
    }
}

file class Ornek052 : OrnekFormBase
{
    public Ornek052() : base("Örnek 052 - Substring ile String Parçalama",
        "Substring(başlangıç) ve Substring(başlangıç, uzunluk) kullanılarak bir metnin istenen bölümü alınır.")
    {
        var s1 = Satir(); s1.Controls.Add(YeniEtiket("Metin:")); var kutu = YeniKutu(220, "VisualCSharpProgramlama"); s1.Controls.Add(kutu);
        var s2 = Satir(); s2.Controls.Add(YeniEtiket("Başlangıç indisi:")); var txtBaslangic = YeniKutu(60, "6"); s2.Controls.Add(txtBaslangic);
        var s3 = Satir(); s3.Controls.Add(YeniEtiket("Uzunluk:")); var txtUzunluk = YeniKutu(60, "6"); s3.Controls.Add(txtUzunluk);
        IcerikPanel.Controls.Add(s1);
        IcerikPanel.Controls.Add(s2);
        IcerikPanel.Controls.Add(s3);
        IcerikPanel.Controls.Add(YeniDugme("Parçayı Al", (_, _) =>
        {
            Temizle();
            if (!int.TryParse(txtBaslangic.Text, out int b) || !int.TryParse(txtUzunluk.Text, out int u))
            {
                Yaz("Geçerli değerler giriniz.");
                return;
            }
            if (b < 0 || b >= kutu.Text.Length || b + u > kutu.Text.Length)
            {
                Yaz("Girilen aralık metin sınırlarının dışında.");
                return;
            }
            Yaz($"\"{kutu.Text}\".Substring({b})     -> \"{kutu.Text.Substring(b)}\"");
            Yaz($"\"{kutu.Text}\".Substring({b}, {u}) -> \"{kutu.Text.Substring(b, u)}\"");
        }));
    }
}

file class Ornek053 : OrnekFormBase
{
    private readonly System.Windows.Forms.Timer _zamanlayici = new();
    private string _metin = "Bu bir kayan yazı (marquee) uygulamasıdır... Visual C# ile hazırlanmıştır... ";
    private int _konum = 0;
    private readonly Label _kayanEtiket;

    public Ornek053() : base("Örnek 053 - Kayan Yazı (Marquee) Uygulaması",
        "Substring metodundan yararlanılarak, bir metnin belirli bir kısmı sürekli kaydırılarak kayan yazı efekti elde edilir.")
    {
        _kayanEtiket = new Label
        {
            Text = "",
            Font = new Font("Consolas", 14f, FontStyle.Bold),
            ForeColor = Color.DarkBlue,
            AutoSize = false,
            Width = 500,
            Height = 30
        };
        IcerikPanel.Controls.Add(_kayanEtiket);

        var s1 = Satir(); s1.Controls.Add(YeniEtiket("Yazı:")); var txtMetin = YeniKutu(300, _metin); s1.Controls.Add(txtMetin);
        IcerikPanel.Controls.Add(s1);

        IcerikPanel.Controls.Add(YeniDugme("Başlat / Durdur", (_, _) =>
        {
            if (_zamanlayici.Enabled)
            {
                _zamanlayici.Stop();
                Yaz("Kayan yazı durduruldu.");
            }
            else
            {
                _metin = string.IsNullOrWhiteSpace(txtMetin.Text) ? _metin : txtMetin.Text + "   ";
                _konum = 0;
                _zamanlayici.Start();
                Yaz("Kayan yazı başlatıldı.");
            }
        }));

        _zamanlayici.Interval = 200;
        _zamanlayici.Tick += (_, _) =>
        {
            string genisletilmis = _metin + _metin;
            _kayanEtiket.Text = genisletilmis.Substring(_konum, Math.Min(40, _metin.Length));
            _konum = (_konum + 1) % _metin.Length;
        };

        FormClosed += (_, _) => _zamanlayici.Stop();
    }
}

file class Ornek054 : OrnekFormBase
{
    public Ornek054() : base("Örnek 054 - Split ile Kelimelere Ayırma",
        "Split(ayırıcı_karakter) metodu, bir string ifadeyi belirtilen karaktere göre parçalara ayırıp bir dizi olarak döner.")
    {
        var satir = Satir();
        satir.Controls.Add(YeniEtiket("Cümle:"));
        var kutu = YeniKutu(260, "Visual C# ile nesneye yönelik programlama");
        satir.Controls.Add(kutu);
        IcerikPanel.Controls.Add(satir);
        IcerikPanel.Controls.Add(YeniDugme("Boşluğa Göre Ayır", (_, _) =>
        {
            Temizle();
            string[] parcalar = kutu.Text.Split(' ');
            Yaz($"Toplam kelime sayısı: {parcalar.Length}");
            for (int i = 0; i < parcalar.Length; i++)
                Yaz($"  [{i}] = \"{parcalar[i]}\"");
        }));
    }
}

file class Ornek055 : OrnekFormBase
{
    public Ornek055() : base("Örnek 055 - Split(ayırıcı, adet) ile Sınırlı Parçalama",
        "Split metoduna ikinci parametre olarak kaç parça oluşturulacağı belirtilebilir; kalan kısım son parçada bütün olarak kalır.")
    {
        var satir = Satir();
        satir.Controls.Add(YeniEtiket("Metin:"));
        var kutu = YeniKutu(260, "ad:Ahmet:soyad:Yılmaz:sehir:Ankara");
        satir.Controls.Add(kutu);
        IcerikPanel.Controls.Add(satir);
        IcerikPanel.Controls.Add(YeniDugme("':' ile İlk 2 Parçaya Ayır", (_, _) =>
        {
            Temizle();
            string[] parcalar = kutu.Text.Split(':', 2);
            Yaz($"Split(':', 2) sonucu ({parcalar.Length} parça):");
            for (int i = 0; i < parcalar.Length; i++)
                Yaz($"  [{i}] = \"{parcalar[i]}\"");
        }));
    }
}

file class Ornek056 : OrnekFormBase
{
    public Ornek056() : base("Örnek 056 - CSV Formatındaki Bir Satırı Split ile Ayrıştırma",
        "Virgülle ayrılmış (CSV) bir öğrenci bilgisi satırı Split ile parçalara ayrılıp etiketler halinde gösterilir.")
    {
        var satir = Satir();
        satir.Controls.Add(YeniEtiket("CSV satırı (ad,soyad,no,not):"));
        var kutu = YeniKutu(260, "Ayşe,Demir,20231234,87");
        satir.Controls.Add(kutu);
        IcerikPanel.Controls.Add(satir);
        IcerikPanel.Controls.Add(YeniDugme("Ayrıştır", (_, _) =>
        {
            Temizle();
            string[] alanlar = kutu.Text.Split(',');
            if (alanlar.Length != 4) { Yaz("Beklenen format: ad,soyad,numara,not"); return; }
            Yaz($"Ad     : {alanlar[0]}");
            Yaz($"Soyad  : {alanlar[1]}");
            Yaz($"Numara : {alanlar[2]}");
            Yaz($"Not    : {alanlar[3]}");
        }));
    }
}
