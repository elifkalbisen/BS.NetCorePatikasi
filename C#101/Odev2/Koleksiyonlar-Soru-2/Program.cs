Console.WriteLine("Lütfen bir sayı giriniz: ");
int[] sayi = new int[20];
for (int i = 0; i < 20; i++)
{
    sayi[i] = int.Parse(Console.ReadLine());
}
Array.Sort(sayi);
int[] enKucukUc = new int[3];
int[] enBuyukUc = new int[3];
for (int i = 0; i < 3; i++)
{
    enKucukUc[i] = sayi[i];
    enBuyukUc[i] = sayi[17 + i];
}
double kucukOrtalama = OrtalamaHesapla(enKucukUc);
double buyukOrtalama = OrtalamaHesapla(enBuyukUc);



static double OrtalamaHesapla(int[] dizi)
{
    int toplam = 0;
    for (int i = 0; i < dizi.Length; i++)
    {
        toplam += dizi[i];
    }
    return (double)toplam / dizi.Length;
}