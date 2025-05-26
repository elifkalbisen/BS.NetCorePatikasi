namespace StaticClass;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Çalışan Sayısı: " + Calisan.CalisanSayisi);
        Calisan calisan1 = new Calisan("Ahmet", "Yılmaz", "IT");
        Console.WriteLine("Çalışan Sayısı: " + Calisan.CalisanSayisi);
        Calisan calisan2 = new Calisan("Ayşe", "Demir", "HR");
        Calisan calisan3 = new Calisan("Mehmet", "Kara", "Finance");
        Console.WriteLine("Çalışan Sayısı: " + Calisan.CalisanSayisi);

        Console.WriteLine("Toplama Sonucu: " + Islemler.Topla(100, 200));
        Console.WriteLine("Çıkarma Sonucu: " + Islemler.Cikar(400, 50));
    }
}

class Calisan
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
        Isim = isim;
        Soyisim = soyisim;
        Departman = departman;
        calisanSayisi++;
    }

}
static class Islemler
{
    public static long Topla(long a, long b)
    {
        return a + b;
    }
    public static long Cikar(long a, long b)
    {
        return a - b;
    }
}