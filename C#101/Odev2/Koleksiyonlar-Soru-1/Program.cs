using System.Collections;


ArrayList asalListesi = new ArrayList();
ArrayList asalOlmayanListesi = new ArrayList();
Console.WriteLine("Pozitif bir tam sayı giriniz:");
int sayiCount = 0;
while (sayiCount < 20)
{
    try
    {
        int sayi = int.Parse(Console.ReadLine());

        if (sayi <= 0)
        {
            Console.WriteLine("Pozitif bir tam sayı giriniz.");
            continue;
        }
        sayiCount++;

        if (AsalMi(sayi))
            asalListesi.Add(sayi);
        else
            asalOlmayanListesi.Add(sayi);
    }
    catch
    {
        Console.WriteLine("Lütfen geçerli bir sayı giriniz.");
    }
}

asalListesi.Sort();
asalListesi.Reverse();

asalOlmayanListesi.Sort();
asalOlmayanListesi.Reverse();

Console.WriteLine("Asal Sayılar:");
foreach (int sayi in asalListesi)
    Console.Write(sayi + " ");
Console.WriteLine();

Console.WriteLine("Asal Olmayan Sayılar:");
foreach (int sayi in asalOlmayanListesi)
    Console.Write(sayi + " ");
Console.WriteLine();

Console.WriteLine(OrtalamaHesapla(asalListesi));
Console.WriteLine(OrtalamaHesapla(asalOlmayanListesi));

static bool AsalMi(int sayi)
{
    if (sayi < 2)
        return false;
    for (int i = 2; i <= Math.Sqrt(sayi); i++)
    {
        if (sayi % i == 0)
            return false;
    }
    return true;
}

static double OrtalamaHesapla(ArrayList liste)
{
    int toplam = 0;
    foreach (int sayi in liste)
        toplam += sayi;

    return liste.Count > 0 ? (double)toplam / liste.Count : 0;
}

