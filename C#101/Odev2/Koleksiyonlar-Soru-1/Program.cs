using System.Collections;

ArrayList asalListesi = new ArrayList();
ArrayList asalOlmayanListesi = new ArrayList();
Console.WriteLine("Pozitif bir tam sayı giriniz:");
for (int i = 0; i < 20; i++)
{
    int sayi = Convert.ToInt32(Console.ReadLine());
    if (AsalMi(sayi))
        asalListesi.Add(sayi);
    else
        asalOlmayanListesi.Add(sayi);
}
Console.WriteLine("Asal sayılar:");
foreach (int item in asalListesi)
    Console.WriteLine(item);

Console.WriteLine("Asal olmayan sayılar:");
foreach (int item in asalOlmayanListesi)
    Console.WriteLine(item);

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