Console.WriteLine("Çalışan Sayısı: {0}", Calisan.CalisanSayisi);

Calisan calisan = new Calisan("İsmail","Ersöz", "Satış");
Console.WriteLine("Çalışan Sayısı: {0}", Calisan.CalisanSayisi);

Calisan calisan1 = new Calisan("Nurettin", "Karabaş", "Pazarlama");
Calisan calisan2 = new Calisan("Emin", "Karabıyık", "Satış");
Console.WriteLine("Çalışan Sayısı: {0}", Calisan.CalisanSayisi);

Console.WriteLine("Toplama İşlemi Sonucu: {0}", Islemler.Topla(150,250));
Console.WriteLine("Çıkarma İşlemi Sonucu: {0}", Islemler.Cikar(450,100));





public class Calisan
{
    private static int calisanSayisi;

    public static int CalisanSayisi { get => calisanSayisi; }

    private string Isim;

    private string Soyisim;

    private string Departman;

    static Calisan()
    {
        calisanSayisi = 0;

    }

    public Calisan(string isim, string soyisim, string departman)
    {
        this.Departman = departman;
        this.Isim = isim;
        this.Soyisim = soyisim;
        calisanSayisi++;



    }


}

static class Islemler
{
    public static long Topla (int sayi1 , int sayi2)
    {
        return sayi1 + sayi2;
    }
    public static long Cikar(int sayi1, int sayi2)
    {
        return sayi1 - sayi2;
    }
}

