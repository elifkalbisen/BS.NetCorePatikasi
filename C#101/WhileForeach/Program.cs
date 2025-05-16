//While
//1den başlayarak consoleden girilen sayıya kadar (sayı dahil) ortalama hesaplayıp konsola yazdıran programı yazınız.
Console.WriteLine("Bir sayı giriniz: ");
int sayi = int.Parse(Console.ReadLine());
int toplam = 0;
int sayac = 1;
int ortalama = 0;
while (sayac<=sayi) //koşul sağlanana kadar çalışır.
{
    toplam += sayac;
    sayac++;
}
ortalama = toplam / sayi;
Console.WriteLine("Ortalama: " + ortalama);



//a dan z ye kadar tüm harfleri console yazdır.
char character = 'a';
while (character < 'z') //koşul sağlanana kadar çalışır.
{
    Console.Write(character + " ");
    character++;
}


//foreach 
Console.WriteLine("*********foreach**********");
//araba isimlerinden oluşan bir dizi

string[] arabalar = { "BMW", "Mercedes", "Audi", "Toyota", "Honda" };
foreach (var araba in arabalar) //dizinin her bir elemanını tek tek alır.
{
    Console.WriteLine(araba);
}