//dizi tanımlaması
string[] renkler = new string[5];
string[] hayvanlar = { "kedi", "köpek", "kuş", "balık", "tavşan" };

int[] dizi;
dizi = new int[5];

//dizileere değer atama ve erişim
renkler[0] = "mavi";
Console.WriteLine(hayvanlar[1]);
dizi[3] = 10;
Console.WriteLine(dizi[3]);
Console.WriteLine(renkler[0]);

//dönglerle dizi kullanımı
//klavyeden girilen n tane sıyının ortalamasını hesaplama
Console.WriteLine("eleman sayısını giriniz");
int diziUzunlugu = int.Parse(Console.ReadLine());
int[] sayilar = new int[diziUzunlugu];
for (int i = 0; i < diziUzunlugu; i++)
{
    Console.WriteLine("lütfen {0}. sayıyı giriniz", i + 1);
    sayilar[i] = int.Parse(Console.ReadLine());
}

int toplam = 0;
foreach (int sayi in sayilar)
{
    toplam += sayi;
}
Console.WriteLine("ortalama: " + toplam / diziUzunlugu);
