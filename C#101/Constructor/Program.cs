namespace Constructor;

class Program
{
    static void Main(string[] args)
    {
        Calisan calisan1 = new Calisan("Ali", "Kara", 12345, "Yazılım");
        calisan1.CalisanBilgileri();
        calisan1.Ad = "Ayşe";
        calisan1.Soyad = "Yılmaz";
        calisan1.No = 12345;
        calisan1.Departman = "İK";
        calisan1.CalisanBilgileri();
        Console.WriteLine("***************");
        Calisan calisan2 = new Calisan();
        calisan2.Ad = "Mehmet";
        calisan2.Soyad = "Demir";
        calisan2.No = 67890;
        calisan2.Departman = "Satın Alım";
        calisan2.CalisanBilgileri();
        Console.WriteLine("***************");
        Calisan calisan3 = new Calisan("Fatma", "Çelik");
        calisan3.CalisanBilgileri();
    }
}

class Calisan
{
    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;
    public Calisan(string ad, string soyad, int no, string departman)
    {
        this.Ad = ad;
        this.Soyad = soyad;
        this.No = no;
        this.Departman = departman;
    }
    
    public Calisan(string ad, string soyad)
    {
        this.Ad = ad;
        this.Soyad = soyad;
    }

    public Calisan() { }
    
        

    public void CalisanBilgileri()
    {
        Console.WriteLine("Çalışan Adı: " + Ad);
        Console.WriteLine("Çalışan Soyadı: " + Soyad);
        Console.WriteLine("Çalışan Numarası: " + No);
        Console.WriteLine("Çalışan Departmanı: " + Departman);
    }
}