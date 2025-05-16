
//ekrana girilen sayıya kadar olan tek sayıları ekrana yazdıran program
Console.WriteLine("Bir sayı giriniz:");
int sayac = int.Parse(Console.ReadLine());
for (int i = 1; i <= sayac; i++)
{
    //komutlar

    if (i % 2 == 1)
    {
        Console.WriteLine(i);
    }

}

//1 ile 1000 arasındaki tek ve çift sayıların toplamını hesaplayın
int tekToplam = 0;
int ciftToplam = 0;

for (int i = 1; i <= 1000; i++)
{
    if (i % 2 == 0)
    {
        ciftToplam += i;
    }
    else
    {
        tekToplam += i;
    }
}
Console.WriteLine("Tek sayıların toplamı: " + tekToplam);
Console.WriteLine("Çift sayıların toplamı: " + ciftToplam);

//break ve continue komutları

for (int i = 1; i < 10; i++)
{
    if (i == 4)
    {
        Console.WriteLine(i);
        break; // döngüden çık
    }
}
System.Console.WriteLine("-----------------");
for (int i = 0; i < 10; i++)
{
    if (i == 4)
    {
        //Console.WriteLine(i);
        continue; // bu iterasyonu atla
    }
}