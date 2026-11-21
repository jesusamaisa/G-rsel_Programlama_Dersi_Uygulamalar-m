using System.Globalization;

namespace VisualCSharpUygulamalari;

public static class StringTemelVeKarsilastirma
{
    public static KonuGrubu Grup()
    {
        var g = new KonuGrubu("6. string Tipi Temelleri ve Karşılaştırma");
        g.Ornekler.Add(new OrnekBilgisi(38, "string Değişkenin Length Özelliği", () => new Ornek038()));
        g.Ornekler.Add(new OrnekBilgisi(39, "string İfadeye Dizi Gibi Erişim ([i])", () => new Ornek039()));
        g.Ornekler.Add(new OrnekBilgisi(40, "ToUpper() ve ToLower() Metotları", () => new Ornek040()));
        g.Ornekler.Add(new OrnekBilgisi(41, "String.Compare ile Alfabetik Karşılaştırma", () => new Ornek041()));
        g.Ornekler.Add(new OrnekBilgisi(42, "Büyük/Küçük Harf Duyarsız Karşılaştırma", () => new Ornek042()));
        g.Ornekler.Add(new OrnekBilgisi(43, "String İfadenin Bir Parçasının Karşılaştırılması", () => new Ornek043()));
        g.Ornekler.Add(new OrnekBilgisi(44, "CultureInfo'ya Göre String Karşılaştırma", () => new Ornek044()));
        g.Ornekler.Add(new OrnekBilgisi(45, "CompareTo Metodu ile Karşılaştırma", () => new Ornek045()));
        g.Ornekler.Add(new OrnekBilgisi(46, "Equals Metodu ile Eşitlik Kontrolü", () => new Ornek046()));
        g.Ornekler.Add(new OrnekBilgisi(47, "StartsWith Metodu ile Önek Kontrolü", () => new Ornek047()));
        g.Ornekler.Add(new OrnekBilgisi(48, "EndsWith Metodu ile Sonek Kontrolü", () => new Ornek048()));
        g.Ornekler.Add(new OrnekBilgisi(49, "Kullanıcı Girişi Doğrulama (StartsWith + Equals Birlikte)", () => new Ornek049()));
        return g;
    }
}

file class Ornek038 : OrnekFormBase
{
    public Ornek038() : base("Örnek 038 - string Değişkenin Length Özelliği",
        "Length özelliği, bir string ifadenin kaç karakterden oluştuğunu (uzunluğunu) verir.")
    {
        var satir = Satir();
        satir.Controls.Add(YeniEtiket("Metin:"));
        var kutu = YeniKutu(220, "Visual C# ile Programlama");
        satir.Controls.Add(kutu);
        IcerikPanel.Controls.Add(satir);
        IcerikPanel.Controls.Add(YeniDugme("Uzunluğu Göster", (_, _) =>
        {
            Temizle();
            Yaz($"\"{kutu.Text}\".Length -> {kutu.Text.Length}");
        }));
    }
}

file class Ornek039 : OrnekFormBase
{
    public Ornek039() : base("Örnek 039 - string İfadeye Dizi Gibi Erişim",
        "string tipindeki bir değişken, aslında karakterlerden oluşan bir dizi gibi davranır. metin[i] ile n. karakter okunabilir.")
    {
        var s1 = Satir(); s1.Controls.Add(YeniEtiket("Metin:")); var kutu = YeniKutu(220, "Programlama"); s1.Controls.Add(kutu);
        var s2 = Satir(); s2.Controls.Add(YeniEtiket("Kaçıncı karakter (0'dan başlar):")); var kutuIndex = YeniKutu(60, "3"); s2.Controls.Add(kutuIndex);
        IcerikPanel.Controls.Add(s1);
        IcerikPanel.Controls.Add(s2);
        IcerikPanel.Controls.Add(YeniDugme("Karakteri Göster", (_, _) =>
        {
            Temizle();
            if (!int.TryParse(kutuIndex.Text, out int index) || index < 0 || index >= kutu.Text.Length)
            {
                Yaz("Geçerli bir indis giriniz (0 ile Length-1 arasında).");
                return;
            }
            Yaz($"\"{kutu.Text}\"[{index}] -> '{kutu.Text[index]}'");
            Yaz("");
            Yaz("Tüm karakterler (indisleriyle birlikte):");
            for (int i = 0; i < kutu.Text.Length; i++)
                Yaz($"  [{i}] = '{kutu.Text[i]}'");
        }));
    }
}

file class Ornek040 : OrnekFormBase
{
    public Ornek040() : base("Örnek 040 - ToUpper() ve ToLower() Metotları",
        "ToUpper() metni tamamen büyük harfe, ToLower() metni tamamen küçük harfe çevirir.")
    {
        var satir = Satir();
        satir.Controls.Add(YeniEtiket("Metin:"));
        var kutu = YeniKutu(220, "Merhaba Dünya");
        satir.Controls.Add(kutu);
        IcerikPanel.Controls.Add(satir);
        IcerikPanel.Controls.Add(YeniDugme("Çevir", (_, _) =>
        {
            Temizle();
            Yaz($"ToUpper() -> {kutu.Text.ToUpper()}");
            Yaz($"ToLower() -> {kutu.Text.ToLower()}");
        }));
    }
}

file class Ornek041 : OrnekFormBase
{
    public Ornek041() : base("Örnek 041 - String.Compare ile Alfabetik Karşılaştırma",
        "String.Compare iki ifadeyi karşılaştırır: eşitse 0, birinci alfabetik olarak sonra geliyorsa pozitif, önce geliyorsa negatif değer döner.")
    {
        var s1 = Satir(); s1.Controls.Add(YeniEtiket("1. metin:")); var txt1 = YeniKutu(160, "elma"); s1.Controls.Add(txt1);
        var s2 = Satir(); s2.Controls.Add(YeniEtiket("2. metin:")); var txt2 = YeniKutu(160, "armut"); s2.Controls.Add(txt2);
        IcerikPanel.Controls.Add(s1);
        IcerikPanel.Controls.Add(s2);
        IcerikPanel.Controls.Add(YeniDugme("Karşılaştır", (_, _) =>
        {
            Temizle();
            int sonuc = string.Compare(txt1.Text, txt2.Text);
            Yaz($"String.Compare(\"{txt1.Text}\", \"{txt2.Text}\") -> {sonuc}");
            if (sonuc == 0) Yaz("Sonuç: İfadeler birbirine eşit.");
            else if (sonuc > 0) Yaz("Sonuç: Birinci ifade alfabetik olarak SONRA gelir.");
            else Yaz("Sonuç: Birinci ifade alfabetik olarak ÖNCE gelir.");
        }));
    }
}

file class Ornek042 : OrnekFormBase
{
    public Ornek042() : base("Örnek 042 - Büyük/Küçük Harf Duyarsız Karşılaştırma",
        "String.Compare(ifade1, ifade2, true) kullanılarak büyük/küçük harf farkı göz ardı edilerek karşılaştırma yapılır.")
    {
        var s1 = Satir(); s1.Controls.Add(YeniEtiket("1. metin:")); var txt1 = YeniKutu(160, "ANKARA"); s1.Controls.Add(txt1);
        var s2 = Satir(); s2.Controls.Add(YeniEtiket("2. metin:")); var txt2 = YeniKutu(160, "ankara"); s2.Controls.Add(txt2);
        IcerikPanel.Controls.Add(s1);
        IcerikPanel.Controls.Add(s2);
        IcerikPanel.Controls.Add(YeniDugme("Karşılaştır", (_, _) =>
        {
            Temizle();
            int duyarli = string.Compare(txt1.Text, txt2.Text, false);
            int duyarsiz = string.Compare(txt1.Text, txt2.Text, true);
            Yaz($"Duyarlı  (false): String.Compare(\"{txt1.Text}\", \"{txt2.Text}\", false) -> {duyarli}");
            Yaz($"Duyarsız (true) : String.Compare(\"{txt1.Text}\", \"{txt2.Text}\", true)  -> {duyarsiz}");
        }));
    }
}

file class Ornek043 : OrnekFormBase
{
    public Ornek043() : base("Örnek 043 - String İfadenin Bir Parçasının Karşılaştırılması",
        "String.Compare(ifade1, başlangıç1, ifade2, başlangıç2, kaç_harf) ile her iki ifadenin belirlenen bölümleri karşılaştırılır.")
    {
        var s1 = Satir(); s1.Controls.Add(YeniEtiket("1. metin:")); var txt1 = YeniKutu(160, "istanbul"); s1.Controls.Add(txt1);
        var s2 = Satir(); s2.Controls.Add(YeniEtiket("2. metin:")); var txt2 = YeniKutu(160, "istasyon"); s2.Controls.Add(txt2);
        var s3 = Satir(); s3.Controls.Add(YeniEtiket("Kaç harf karşılaştırılsın:")); var txtAdet = YeniKutu(60, "3"); s3.Controls.Add(txtAdet);
        IcerikPanel.Controls.Add(s1);
        IcerikPanel.Controls.Add(s2);
        IcerikPanel.Controls.Add(s3);
        IcerikPanel.Controls.Add(YeniDugme("İlk N Harfi Karşılaştır", (_, _) =>
        {
            Temizle();
            if (!int.TryParse(txtAdet.Text, out int adet)) { Yaz("Geçerli bir harf sayısı giriniz."); return; }
            int sonuc = string.Compare(txt1.Text, 0, txt2.Text, 0, adet);
            Yaz($"String.Compare(\"{txt1.Text}\", 0, \"{txt2.Text}\", 0, {adet}) -> {sonuc}");
            Yaz(sonuc == 0 ? "İlk kısımlar birbirine eşit." : "İlk kısımlar birbirinden farklı.");
        }));
    }
}

file class Ornek044 : OrnekFormBase
{
    public Ornek044() : base("Örnek 044 - CultureInfo'ya Göre String Karşılaştırma",
        "String.Compare(ifade1, ifade2, duyarlılık, CultureInfo) ile belirtilen dil/kültür kurallarına göre karşılaştırma yapılır (örn. Türkçe 'i/İ' kuralları).")
    {
        var s1 = Satir(); s1.Controls.Add(YeniEtiket("1. metin:")); var txt1 = YeniKutu(160, "İstanbul"); s1.Controls.Add(txt1);
        var s2 = Satir(); s2.Controls.Add(YeniEtiket("2. metin:")); var txt2 = YeniKutu(160, "istanbul"); s2.Controls.Add(txt2);
        IcerikPanel.Controls.Add(s1);
        IcerikPanel.Controls.Add(s2);
        IcerikPanel.Controls.Add(YeniDugme("tr-TR ve en-US Kültürüne Göre Karşılaştır", (_, _) =>
        {
            Temizle();
            int trSonuc = string.Compare(txt1.Text, txt2.Text, true, new CultureInfo("tr-TR"));
            int enSonuc = string.Compare(txt1.Text, txt2.Text, true, new CultureInfo("en-US"));
            Yaz($"tr-TR kültürüne göre (duyarsız) -> {trSonuc}");
            Yaz($"en-US kültürüne göre (duyarsız) -> {enSonuc}");
            Yaz("");
            Yaz("Not: Türkçede 'İ'nin küçüğü 'i', 'I'nın küçüğü 'ı' olduğundan,");
            Yaz("kültüre göre büyük/küçük harf dönüşüm kuralları farklılık gösterebilir.");
        }));
    }
}

file class Ornek045 : OrnekFormBase
{
    public Ornek045() : base("Örnek 045 - CompareTo Metodu ile Karşılaştırma",
        "ifade1.CompareTo(ifade2) de String.Compare ile aynı mantıkta çalışan bir örnek (instance) metodudur.")
    {
        var s1 = Satir(); s1.Controls.Add(YeniEtiket("1. metin:")); var txt1 = YeniKutu(160, "kedi"); s1.Controls.Add(txt1);
        var s2 = Satir(); s2.Controls.Add(YeniEtiket("2. metin:")); var txt2 = YeniKutu(160, "köpek"); s2.Controls.Add(txt2);
        IcerikPanel.Controls.Add(s1);
        IcerikPanel.Controls.Add(s2);
        IcerikPanel.Controls.Add(YeniDugme("CompareTo ile Karşılaştır", (_, _) =>
        {
            Temizle();
            int sonuc = txt1.Text.CompareTo(txt2.Text);
            Yaz($"\"{txt1.Text}\".CompareTo(\"{txt2.Text}\") -> {sonuc}");
        }));
    }
}

file class Ornek046 : OrnekFormBase
{
    public Ornek046() : base("Örnek 046 - Equals Metodu ile Eşitlik Kontrolü",
        "Equals metodu iki string ifadenin birebir eşit olup olmadığını true/false olarak döner.")
    {
        var s1 = Satir(); s1.Controls.Add(YeniEtiket("1. metin:")); var txt1 = YeniKutu(160, "sifre123"); s1.Controls.Add(txt1);
        var s2 = Satir(); s2.Controls.Add(YeniEtiket("2. metin:")); var txt2 = YeniKutu(160, "sifre123"); s2.Controls.Add(txt2);
        IcerikPanel.Controls.Add(s1);
        IcerikPanel.Controls.Add(s2);
        IcerikPanel.Controls.Add(YeniDugme("Eşit mi?", (_, _) =>
        {
            Temizle();
            bool esitMi = txt1.Text.Equals(txt2.Text);
            Yaz($"\"{txt1.Text}\".Equals(\"{txt2.Text}\") -> {esitMi}");
        }));
    }
}

file class Ornek047 : OrnekFormBase
{
    public Ornek047() : base("Örnek 047 - StartsWith Metodu ile Önek Kontrolü",
        "StartsWith(kelime), bir string'in belirtilen kelime ile başlayıp başlamadığını kontrol eder.")
    {
        var s1 = Satir(); s1.Controls.Add(YeniEtiket("Metin:")); var txt1 = YeniKutu(180, "merhaba@example.com"); s1.Controls.Add(txt1);
        var s2 = Satir(); s2.Controls.Add(YeniEtiket("Başlangıç ifadesi:")); var txt2 = YeniKutu(100, "merhaba"); s2.Controls.Add(txt2);
        IcerikPanel.Controls.Add(s1);
        IcerikPanel.Controls.Add(s2);
        IcerikPanel.Controls.Add(YeniDugme("Kontrol Et", (_, _) =>
        {
            Temizle();
            bool sonuc = txt1.Text.StartsWith(txt2.Text);
            Yaz($"\"{txt1.Text}\".StartsWith(\"{txt2.Text}\") -> {sonuc}");
        }));
    }
}

file class Ornek048 : OrnekFormBase
{
    public Ornek048() : base("Örnek 048 - EndsWith Metodu ile Sonek Kontrolü",
        "EndsWith(kelime), bir string'in belirtilen kelime ile bitip bitmediğini kontrol eder (örn. dosya uzantısı kontrolü).")
    {
        var s1 = Satir(); s1.Controls.Add(YeniEtiket("Dosya adı:")); var txt1 = YeniKutu(180, "rapor.pdf"); s1.Controls.Add(txt1);
        var s2 = Satir(); s2.Controls.Add(YeniEtiket("Uzantı:")); var txt2 = YeniKutu(100, ".pdf"); s2.Controls.Add(txt2);
        IcerikPanel.Controls.Add(s1);
        IcerikPanel.Controls.Add(s2);
        IcerikPanel.Controls.Add(YeniDugme("Kontrol Et", (_, _) =>
        {
            Temizle();
            bool sonuc = txt1.Text.EndsWith(txt2.Text);
            Yaz($"\"{txt1.Text}\".EndsWith(\"{txt2.Text}\") -> {sonuc}");
        }));
    }
}

file class Ornek049 : OrnekFormBase
{
    public Ornek049() : base("Örnek 049 - Kullanıcı Girişi Doğrulama (Birden Fazla Metot Birlikte)",
        "Kullanıcı adının 'adm_' ile başlaması ve şifrenin tam olarak doğru olması StartsWith ve Equals birlikte kullanılarak kontrol edilir.")
    {
        var s1 = Satir(); s1.Controls.Add(YeniEtiket("Kullanıcı adı:")); var txtKul = YeniKutu(160, "adm_ali"); s1.Controls.Add(txtKul);
        var s2 = Satir(); s2.Controls.Add(YeniEtiket("Şifre:")); var txtSifre = YeniKutu(160, "12345"); s2.Controls.Add(txtSifre);
        IcerikPanel.Controls.Add(s1);
        IcerikPanel.Controls.Add(s2);
        IcerikPanel.Controls.Add(YeniDugme("Giriş Yap", (_, _) =>
        {
            Temizle();
            bool yoneticiMi = txtKul.Text.StartsWith("adm_");
            bool sifreDogruMu = txtSifre.Text.Equals("12345");
            if (yoneticiMi && sifreDogruMu)
                Yaz("Giriş başarılı: Yönetici olarak giriş yapıldı.");
            else if (!yoneticiMi)
                Yaz("Giriş reddedildi: Kullanıcı adı 'adm_' ile başlamalı.");
            else
                Yaz("Giriş reddedildi: Şifre hatalı.");
        }));
    }
}
