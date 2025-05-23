//Söz dizimi
//Clas SınıfAdı
//{
//    // [Erişim Belirleyici] [Veri Türü] ÖzellikAdı;
//    // [Erişim Belirleyici] [Geri Dönüş Türü] MetotAdı([Parametre Listesi])
//    // {
//    //     // Metot gövdesi
//    // }
//}

//Erişim belirleyicileri
// *Public: Her yerden erişilebilir.
// *Private: Sadece tanımlandığı sınıf içinde erişilebilir.
// *Internal: Sadece aynı proje içinde erişilebilir.
// *Protected: Sadece tanımlandığı sınıf ve alt sınıflar içinde erişilebilir.
Calisan calisan1 = new Calisan();
calisan1.Ad = "Ayşe";
calisan1.Soyad = "Yılmaz";
calisan1.No = 12345;
calisan1.Departman = "İK";
calisan1.CalisanBilgileri();
Console.WriteLine("***************");
Calisan calisan2 = new Calisan();
calisan2.Ad = "Mehmet";
calisan2.Soyad="Demir";
calisan2.No = 67890;
calisan2.Departman = "Satın Alım";
calisan2.CalisanBilgileri();

class Calisan
{
    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;

    public void CalisanBilgileri()
    {
        Console.WriteLine("Çalışan Adı: " + Ad);
        Console.WriteLine("Çalışan Soyadı: " + Soyad);
        Console.WriteLine("Çalışan Numarası: " + No);
        Console.WriteLine("Çalışan Departmanı: " + Departman);
    }
}