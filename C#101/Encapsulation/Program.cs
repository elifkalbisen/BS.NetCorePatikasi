namespace Encapsulation;

class Program
{
    static void Main(string[] args)
    {
        //Encapsulation : Verilerin gizlenmesi ve korunmasıdır.
        //Encapsulation : Sınıfın dışındaki kodların sınıfın içindeki verilere erişimini kontrol etme işlemidir.
        Ogrenci ogrenci = new Ogrenci();
        ogrenci.Isim = "Ayşe";
        ogrenci.Soyisim = "Yılmaz";
        ogrenci.OgrenciNo = 293;
        ogrenci.Sinif = 3;
        ogrenci.OgrenciBilgileriniGetir();

        ogrenci.SinifAtla();
        ogrenci.OgrenciBilgileriniGetir();
    }
}

class Ogrenci
{
    private string isim;
    private string soyisim;
    private int ogrenciNo;
    private int sinif;

    public string Isim
    {
        get { return isim; }
        set { isim = value; }
    }
    public string Soyisim { get => soyisim; set => soyisim = value; }
    public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
    public int Sinif { get => sinif; set => sinif = value; }

    public Ogrenci(string isim, string soyisim, int ogrenciNo, int sinif)
    {
        Isim = isim;
        Soyisim = soyisim;
        OgrenciNo = ogrenciNo;
        Sinif = sinif;
    }
    public Ogrenci() { }

    public void OgrenciBilgileriniGetir()
    {
        Console.WriteLine("Öğrenci Bilgileri:");
        Console.WriteLine("İsim: {0}", Isim);
        Console.WriteLine("Soyisim: {0}", Soyisim);
        Console.WriteLine("Öğrenci No: {0}", OgrenciNo);
        Console.WriteLine("Sınıf: {0}", Sinif);
    }
    public void SinifAtla()
    {
        Sinif++;
        Console.WriteLine("Öğrenci sınıf atladı. Yeni sınıf: {0}", Sinif);
    }
    public void SinifDusur()
    {
        Sinif--;
        Console.WriteLine("Öğrenci sınıf düştü. Yeni sınıf: {0}", Sinif);
    }
}