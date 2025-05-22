using System.Collections.Generic;
using System.Linq.Expressions;

// Koleksiyonlar - Collections
// List<T> - List
//system.Collections.Generic;
// T-> Generic. object türündedir.

List<int> sayiListesi = new List<int>();
sayiListesi.Add(23);
sayiListesi.Add(10);
sayiListesi.Add(4);
sayiListesi.Add(5);
sayiListesi.Add(92);
sayiListesi.Add(34);

List<string> renkListesi = new List<string>();
renkListesi.Add("Kırmızı");
renkListesi.Add("Mavi");
renkListesi.Add("Turuncu");
renkListesi.Add("Sarı");
renkListesi.Add("Yeşil");

//Count

Console.WriteLine("Sayı Listesi Eleman Sayısı: " + sayiListesi.Count);
Console.WriteLine("Renk Listesi Eleman Sayısı: " + renkListesi.Count);

//Foreach ile elemanlara erişim

foreach (var sayi in sayiListesi)
{
    Console.WriteLine(sayi);
}

foreach (var renk in renkListesi)
{
    Console.WriteLine(renk);
}

sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
renkListesi.ForEach(renk => Console.WriteLine(renk));

// Listeden eleman çıkarma

sayiListesi.Remove(4);
renkListesi.Remove("Yeşil");

sayiListesi.RemoveAt(0); // 0. indexi siler
renkListesi.RemoveAt(1); // 1. indexi siler

sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
renkListesi.ForEach(renk => Console.WriteLine(renk));

//liste içerisinde arama

if (sayiListesi.Contains(10))
{
    Console.WriteLine("10 sayısı listede mevcut.");
}
else
{
    Console.WriteLine("10 sayısı listede mevcut değil.");
}

//Eleman ile indexe erişim.
renkListesi.Sort();
Console.WriteLine(renkListesi.BinarySearch("Sarı")); // Sarı elemanının indexi

//Diziyi Listeye çevirme
string[] hayvanlar = { "Kedi", "Köpek", "Kuş" };
List<string> hayvanListesi = new List<string>(hayvanlar);

//Listeyi nasıl temizleriz.
hayvanListesi.Clear();

//List içerisinde nesne tutmak

List<Kisi> kisiListesi = new List<Kisi>();
Kisi kisi1 = new Kisi();
kisi1.Isim = "Ali";
kisi1.Soyisim = "Yılmaz";
kisi1.Yas = 30;

Kisi kisi2 = new Kisi();
kisi2.Isim = "Ayşe";
kisi2.Soyisim = "Demir";
kisi2.Yas = 25;

kisiListesi.Add(kisi1);
kisiListesi.Add(kisi2);

List<Kisi> yeniListesi = new List<Kisi>();
yeniListesi.Add(new Kisi()
{
    Isim = "Mehmet",
    Soyisim = "Kara",
    Yas = 28
});

foreach (var kisi in kisiListesi)
{
    Console.WriteLine("İsim: " + kisi.Isim);
    Console.WriteLine("Soyisim: " + kisi.Soyisim);
    Console.WriteLine("Yaş: " + kisi.Yas);
}

foreach (var kisi in yeniListesi)
{
    Console.WriteLine("İsim: " + kisi.Isim);
    Console.WriteLine("Soyisim: " + kisi.Soyisim);
    Console.WriteLine("Yaş: " + kisi.Yas);
}

yeniListesi.Clear(); 

public class Kisi
{
    string isim;
    string soyisim;
    int yas;

    public string Isim { get => isim; set => isim = value; }
    public string Soyisim { get => soyisim; set => soyisim = value; }
    public int Yas { get => yas; set => yas = value; }
}