namespace VisualCSharpUygulamalari;

public static class DegiskenlerVeVeriTipleri
{
    public static KonuGrubu Grup()
    {
        var g = new KonuGrubu("1. Değişkenler ve Veri Tipleri");
        g.Ornekler.Add(new OrnekBilgisi(1, "Değişken İsimlendirme Kuralları", () => new Ornek001()));
        g.Ornekler.Add(new OrnekBilgisi(2, "Sayısal Tiplerin Sınır Değerleri", () => new Ornek002()));
        g.Ornekler.Add(new OrnekBilgisi(3, "float / double / decimal Aralıkları", () => new Ornek003()));
        g.Ornekler.Add(new OrnekBilgisi(4, "Ondalık Değerin int Değişkene Atanması (Hata)", () => new Ornek004()));
        g.Ornekler.Add(new OrnekBilgisi(5, "İki Tam Sayının Bölümü ve Convert Sınıfı", () => new Ornek005()));
        g.Ornekler.Add(new OrnekBilgisi(6, "Bölme Sonucunun float/double Olarak Doğru Alınması", () => new Ornek006()));
        g.Ornekler.Add(new OrnekBilgisi(7, "Değişken Tipi Seçiminin Önemi (Maaş Hesabı)", () => new Ornek007()));
        return g;
    }
}

file class Ornek001 : OrnekFormBase
{
    public Ornek001() : base("Örnek 001 - Değişken İsimlendirme Kuralları",
        "Değişken isimlerinde Türkçe karakter, boşluk, rakamla başlama gibi kurallara uyulup uyulmadığını kontrol eder.")
    {
        var satir = Satir();
        satir.Controls.Add(YeniEtiket("Denenecek değişken adı:"));
        var kutu = YeniKutu();
        satir.Controls.Add(kutu);
        IcerikPanel.Controls.Add(satir);
        IcerikPanel.Controls.Add(YeniDugme("Kuralları Kontrol Et", (_, _) =>
        {
            Temizle();
            string ad = kutu.Text;
            bool gecerli = true;

            if (string.IsNullOrWhiteSpace(ad))
            {
                Yaz("Değişken adı boş olamaz.");
                return;
            }
            if (char.IsDigit(ad[0]))
            {
                Yaz("HATA: Değişken adı rakamla başlayamaz.");
                gecerli = false;
            }
            if (ad.Contains(' '))
            {
                Yaz("HATA: Değişken isminde boşluk olamaz. (alt çizgi '_' kullanılmalı)");
                gecerli = false;
            }
            string turkceKarakterler = "çğıöşüÇĞİÖŞÜ";
            foreach (char c in ad)
            {
                if (turkceKarakterler.Contains(c))
                {
                    Yaz($"HATA: '{c}' Türkçe karakteri değişken isminde kullanılmamalı.");
                    gecerli = false;
                    break;
                }
            }
            foreach (char c in ad)
            {
                if (!char.IsLetterOrDigit(c) && c != '_')
                {
                    Yaz($"HATA: '{c}' geçersiz bir karakter. Sadece harf, rakam ve '_' kullanılabilir.");
                    gecerli = false;
                    break;
                }
            }
            if (ad.Length > 255)
            {
                Yaz("HATA: Değişken ismi 255 karakterden uzun olamaz.");
                gecerli = false;
            }
            string[] anahtarKelimeler = { "true", "false", "int", "string", "class", "void", "if", "for" };
            if (Array.Exists(anahtarKelimeler, k => k == ad))
            {
                Yaz($"HATA: '{ad}' bir C# anahtar kelimesidir, değişken ismi olarak kullanılamaz.");
                gecerli = false;
            }

            if (gecerli) Yaz($"'{ad}' geçerli bir değişken ismidir. Örnek: string {ad};");
        }));
    }
}

file class Ornek002 : OrnekFormBase
{
    public Ornek002() : base("Örnek 002 - Sayısal Tiplerin Sınır Değerleri",
        "byte, sbyte, short, ushort, int, uint, long, ulong tiplerinin alabileceği minimum ve maksimum değerleri gösterir.")
    {
        IcerikPanel.Controls.Add(YeniDugme("Sınır Değerlerini Göster", (_, _) =>
        {
            Temizle();
            Yaz($"byte   : {byte.MinValue,25} .. {byte.MaxValue}");
            Yaz($"sbyte  : {sbyte.MinValue,25} .. {sbyte.MaxValue}");
            Yaz($"short  : {short.MinValue,25} .. {short.MaxValue}");
            Yaz($"ushort : {ushort.MinValue,25} .. {ushort.MaxValue}");
            Yaz($"int    : {int.MinValue,25} .. {int.MaxValue}");
            Yaz($"uint   : {uint.MinValue,25} .. {uint.MaxValue}");
            Yaz($"long   : {long.MinValue,25} .. {long.MaxValue}");
            Yaz($"ulong  : {ulong.MinValue,25} .. {ulong.MaxValue}");
        }));
    }
}

file class Ornek003 : OrnekFormBase
{
    public Ornek003() : base("Örnek 003 - float / double / decimal Aralıkları ve Basamak Hassasiyeti",
        "Aynı 19 basamaklı sayı float, double ve decimal değişkenlere atandığında hafızada tutulan gerçek değerler karşılaştırılır.")
    {
        IcerikPanel.Controls.Add(YeniDugme("Karşılaştır", (_, _) =>
        {
            Temizle();
            float sayi1 = 1234567890123456789f;
            double sayi2 = 1234567890123456789d;
            decimal sayi3 = 1234567890123456789m;

            Yaz("Aynı 19 basamaklı değer 3 farklı tipe atandığında:");
            Yaz($"float   (7 basamak hassasiyet) -> {sayi1}");
            Yaz($"double  (15 basamak hassasiyet)-> {sayi2}");
            Yaz($"decimal (29 basamak hassasiyet)-> {sayi3}");
            Yaz("");
            Yaz("Görüldüğü gibi float ve double, basamak hassasiyeti sınırlı olduğundan");
            Yaz("sayının gerçek değerini tam olarak tutamaz; decimal ise tutabilir.");
        }));
    }
}

file class Ornek004 : OrnekFormBase
{
    public Ornek004() : base("Örnek 004 - Ondalık Değerin int Değişkene Atanması",
        "int i = 4.3; şeklindeki bir atama neden derleme hatası verir? Convert sınıfı ile nasıl çözülür?")
    {
        IcerikPanel.Controls.Add(YeniDugme("Göster", (_, _) =>
        {
            Temizle();
            Yaz("Kod: int i = 4.3;  ->  DERLEME HATASI");
            Yaz("Nedeni: 4.3 derleyici tarafından 'double' olarak kabul edilir,");
            Yaz("double değeri int'e örtülü (implicit) olarak atanamaz.");
            Yaz("");
            double d = 4.3;
            int i1 = (int)d;              // kesme (truncate)
            int i2 = Convert.ToInt32(d);  // yuvarlama (rounding)
            Yaz($"(int)4.3            -> {i1}   (ondalık kısım kesilir)");
            Yaz($"Convert.ToInt32(4.3) -> {i2}   (en yakın tam sayıya yuvarlanır)");
            Yaz($"Convert.ToInt32(4.6) -> {Convert.ToInt32(4.6)}   (yuvarlanarak 5 olur)");
        }));
    }
}

file class Ornek005 : OrnekFormBase
{
    public Ornek005() : base("Örnek 005 - İki Tam Sayının Bölümü",
        "int i = 4/3; işleminde sonuç neden 1,333... değil 1 olarak hafızada tutulur?")
    {
        IcerikPanel.Controls.Add(YeniDugme("Göster", (_, _) =>
        {
            Temizle();
            int i = 4 / 3;
            Yaz($"int i = 4 / 3;  ->  i = {i}");
            Yaz("Her iki işlenen de int olduğundan C# bölme işlemini tam sayı bölmesi olarak yapar,");
            Yaz("ondalık kısım atılır (kesilir), yuvarlama yapılmaz.");
            Yaz("");
            Yaz("Doğru (ondalıklı) sonuç almak için Convert sınıfı kullanılabilir:");
            double sonuc = Convert.ToDouble(4) / Convert.ToDouble(3);
            Yaz($"Convert.ToDouble(4) / Convert.ToDouble(3) -> {sonuc}");
        }));
    }
}

file class Ornek006 : OrnekFormBase
{
    public Ornek006() : base("Örnek 006 - Bölme Sonucunun Doğru Alınması",
        "İki tam sayı bölümünden ondalıklı sonuç almanın doğru yolu: işlenenlerden birini float/double'a çevirmek.")
    {
        var s1 = Satir(); s1.Controls.Add(YeniEtiket("Birinci sayı (bölünen):")); var txt1 = YeniKutu(120, "22"); s1.Controls.Add(txt1);
        var s2 = Satir(); s2.Controls.Add(YeniEtiket("İkinci sayı (bölen):")); var txt2 = YeniKutu(120, "7"); s2.Controls.Add(txt2);
        IcerikPanel.Controls.Add(s1);
        IcerikPanel.Controls.Add(s2);
        IcerikPanel.Controls.Add(YeniDugme("Böl ve Karşılaştır", (_, _) =>
        {
            Temizle();
            if (!int.TryParse(txt1.Text, out int a) || !int.TryParse(txt2.Text, out int b) || b == 0)
            {
                Yaz("Lütfen geçerli ve sıfırdan farklı sayılar giriniz.");
                return;
            }
            int sonucYanlis = a / b;
            double sonucDogru1 = (double)a / b;
            float sonucDogru2 = (float)a / (float)b;
            Yaz($"int sonuc = {a} / {b};        -> {sonucYanlis}  (tam sayı bölmesi)");
            Yaz($"double sonuc = (double){a} / {b}; -> {sonucDogru1}");
            Yaz($"float sonuc = (float){a} / (float){b}; -> {sonucDogru2}");
        }));
    }
}

file class Ornek007 : OrnekFormBase
{
    public Ornek007() : base("Örnek 007 - Değişken Tipi Seçiminin Önemi (Maaş Hesabı)",
        "Çalışan sayısı ve toplam maaşın int ile bölünmesiyle oluşan hata, double'a çevrilerek düzeltilir.")
    {
        var s1 = Satir(); s1.Controls.Add(YeniEtiket("Toplam Maaş:")); var txtMaas = YeniKutu(120, "10000"); s1.Controls.Add(txtMaas);
        var s2 = Satir(); s2.Controls.Add(YeniEtiket("Çalışan Sayısı:")); var txtKisi = YeniKutu(120, "3"); s2.Controls.Add(txtKisi);
        IcerikPanel.Controls.Add(s1);
        IcerikPanel.Controls.Add(s2);
        IcerikPanel.Controls.Add(YeniDugme("Kişi Başı Maaşı Hesapla", (_, _) =>
        {
            Temizle();
            if (!int.TryParse(txtMaas.Text, out int maas) || !int.TryParse(txtKisi.Text, out int kisi) || kisi == 0)
            {
                Yaz("Lütfen geçerli sayılar giriniz.");
                return;
            }
            int yanlisSonuc = maas / kisi;
            double dogruSonuc = (double)maas / kisi;
            Yaz($"int ile hesap (yanlış): {maas} / {kisi} = {yanlisSonuc}  (ondalık kısım kayboldu)");
            Yaz($"double'a çevirerek (doğru): (double){maas} / {kisi} = {dogruSonuc:F2}");
        }));
    }
}
