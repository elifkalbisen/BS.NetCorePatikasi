//Sort : sıralama işlemi
int[] sayiDizisi = { 23, 12, 4, 86, 72, 3, 11, 17 };
Console.WriteLine("Sırasız Dizi");
foreach (int sayi in sayiDizisi)
{
    Console.WriteLine(sayi);
}
Console.WriteLine("Sıralı Dizi");
Array.Sort(sayiDizisi);
foreach (int sayi in sayiDizisi)
{
    Console.WriteLine(sayi);
}

//clear
Console.WriteLine("Dizi Temizleme");
Array.Clear(sayiDizisi, 2, 2); // 2. indisten başla 2 tane elemanı temizle sıfırla
foreach (int sayi in sayiDizisi)
{
    Console.WriteLine(sayi);
}

//reverse : tersine çevirme

Console.WriteLine("Dizi Ters Çevirme");
Array.Reverse(sayiDizisi);
foreach (int sayi in sayiDizisi)
{
    Console.WriteLine(sayi);
}

//index of : dizideki elemanın indexini bulma
Console.WriteLine(Array.IndexOf(sayiDizisi, 23)); // 23 sayısının dizideki indexini bul

//resize : dizinin boyutunu değiştirme yniden boyutlandırma
Array.Resize<int>(ref sayiDizisi, 9); // dizinin boyutunu 9 yap
sayiDizisi[8] = 99; // dizinin sonuna 99 ekle
foreach (int sayi in sayiDizisi)
{
    Console.WriteLine(sayi);
}