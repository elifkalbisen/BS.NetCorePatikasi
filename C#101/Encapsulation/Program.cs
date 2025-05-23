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
        Ogrenci ogrenci1 = new Ogrenci("Ali", "Demir", 123, 1);
        ogrenci1.OgrenciBilgileriniGetir();
        ogrenci1.SinifDusur();
        ogrenci1.SinifDusur();
        ogrenci1.OgrenciBilgileriniGetir();
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
    public int Sinif
    {
        get => sinif;
        set
        {
            if (value < 1)
            {
                Console.WriteLine("Sınıf 1'den küçük olamaz.");
                sinif = 1;
                
            }
            else
                sinif = value;
        }
    }

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
        this.Sinif = this.Sinif + 1;
        //Sinif++;
    }
    public void SinifDusur()
    {
        Sinif--;
    }
}