namespace VisualCSharpUygulamalari;

public static class BasamakHassasiyetiVeSinirAsimi
{
    public static KonuGrubu Grup()
    {
        var g = new KonuGrubu("2. Basamak Hassasiyeti ve Sınır Aşımı");
        g.Ornekler.Add(new OrnekBilgisi(8, "byte Tipinde Sınır Aşımı (Overflow)", () => new Ornek008()));
        g.Ornekler.Add(new OrnekBilgisi(9, "checked Deyimi ile Taşma Hatasının Yakalanması", () => new Ornek009()));
        g.Ornekler.Add(new OrnekBilgisi(10, "unchecked Bloğunda Taşma Davranışı", () => new Ornek010()));
        g.Ornekler.Add(new OrnekBilgisi(11, "Muhasebe Uygulamasında decimal Kullanımının Önemi", () => new Ornek011()));
        g.Ornekler.Add(new OrnekBilgisi(12, "float/double Yuvarlama Hassasiyeti Karşılaştırması", () => new Ornek012()));
        return g;
    }
}

file class Ornek008 : OrnekFormBase
{
    public Ornek008() : base("Örnek 008 - byte Tipinde Sınır Aşımı",
        "byte tipi 0-255 arasında değer tutar. 255'i geçen bir değer atandığında taşma (overflow) oluşur ve değer baştan sarar.")
    {
        var satir = Satir();
        satir.Controls.Add(YeniEtiket("byte'a atanacak değer:"));
        var kutu = YeniKutu(120, "350");
        satir.Controls.Add(kutu);
        IcerikPanel.Controls.Add(satir);
        IcerikPanel.Controls.Add(YeniDugme("unchecked Olarak Ata", (_, _) =>
        {
            Temizle();
            if (!int.TryParse(kutu.Text, out int deger)) { Yaz("Geçerli bir tam sayı giriniz."); return; }
            unchecked
            {
                byte x = (byte)deger;
                Yaz($"Girilen değer: {deger}");
                Yaz($"byte x = (byte){deger};  ->  x = {x}");
                Yaz("");
                Yaz($"Açıklama: {deger} mod 256 = {deger % 256} (byte 0-255 aralığında döner / taşar).");
            }
        }));
    }
}

file class Ornek009 : OrnekFormBase
{
    public Ornek009() : base("Örnek 009 - checked Deyimi ile Taşma Hatasının Yakalanması",
        "checked bloğu kullanıldığında sınır aşımı sessizce geçilmez, OverflowException fırlatılır ve kullanıcıya haber verilebilir.")
    {
        var satir = Satir();
        satir.Controls.Add(YeniEtiket("byte'a atanacak değer:"));
        var kutu = YeniKutu(120, "350");
        satir.Controls.Add(kutu);
        IcerikPanel.Controls.Add(satir);
        IcerikPanel.Controls.Add(YeniDugme("checked Olarak Ata", (_, _) =>
        {
            Temizle();
            if (!int.TryParse(kutu.Text, out int deger)) { Yaz("Geçerli bir tam sayı giriniz."); return; }
            try
            {
                checked
                {
                    byte x = (byte)deger;
                    Yaz($"Atama başarılı: x = {x}");
                }
            }
            catch (OverflowException)
            {
                Yaz($"HATA (OverflowException): {deger} değeri byte sınırlarını (0-255) aşıyor!");
            }
        }));
    }
}

file class Ornek010 : OrnekFormBase
{
    public Ornek010() : base("Örnek 010 - unchecked Bloğunda Taşma Davranışı",
        "int.MaxValue değerine 1 eklendiğinde unchecked blokta sessizce int.MinValue'ya döner; checked blokta ise hata fırlatılır.")
    {
        IcerikPanel.Controls.Add(YeniDugme("Karşılaştır", (_, _) =>
        {
            Temizle();
            int maks = int.MaxValue;
            unchecked
            {
                int sonucUnchecked = maks + 1;
                Yaz($"unchecked: int.MaxValue + 1 = {sonucUnchecked}  (sessizce taşar / sarar)");
            }
            try
            {
                checked
                {
                    int sonucChecked = maks + 1;
                    Yaz($"checked: {sonucChecked}");
                }
            }
            catch (OverflowException)
            {
                Yaz("checked: int.MaxValue + 1 -> OverflowException fırlatıldı!");
            }
        }));
    }
}

file class Ornek011 : OrnekFormBase
{
    public Ornek011() : base("Örnek 011 - Muhasebe Uygulamasında decimal Kullanımının Önemi",
        "Para ile ilgili hesaplamalarda double yerine decimal kullanılmalıdır; aksi halde yuvarlama hataları oluşabilir.")
    {
        IcerikPanel.Controls.Add(YeniDugme("0.1 + 0.2 İşlemini Karşılaştır", (_, _) =>
        {
            Temizle();
            double d1 = 0.1, d2 = 0.2;
            decimal m1 = 0.1m, m2 = 0.2m;
            Yaz($"double: 0.1 + 0.2 = {d1 + d2:G17}   <- beklenmedik ondalık hata içerebilir");
            Yaz($"decimal: 0.1m + 0.2m = {m1 + m2}     <- tam ve beklenen sonuç");
            Yaz("");
            Yaz("Bu nedenle para/muhasebe/stok hesaplarında decimal tipi tercih edilmelidir.");
        }));
    }
}

file class Ornek012 : OrnekFormBase
{
    public Ornek012() : base("Örnek 012 - float / double Yuvarlama Hassasiyeti Karşılaştırması",
        "Aynı matematiksel işlem float ve double ile yapıldığında basamak hassasiyeti farkından dolayı sonuçlar farklılaşabilir.")
    {
        IcerikPanel.Controls.Add(YeniDugme("1/3 İşlemini Karşılaştır", (_, _) =>
        {
            Temizle();
            float f = 1f / 3f;
            double d = 1d / 3d;
            Yaz($"float  1f/3f  = {f:G9}   (7 basamak hassasiyet)");
            Yaz($"double 1d/3d  = {d:G17}  (15 basamak hassasiyet)");
        }));
    }
}
