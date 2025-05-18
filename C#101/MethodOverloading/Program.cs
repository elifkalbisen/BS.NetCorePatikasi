// out : bir fonksiyona bir işlevi geçerken, o işlevin bir kopyasını değil, referansını geçer.

string sayi = "999";
int outSayi;
bool sonuc=int.TryParse(sayi, out outSayi);
if (sonuc)
{
    Console.WriteLine("Başarılı!");
    Console.WriteLine(outSayi);
}
else
{
    Console.WriteLine("Başarısız!");

}

Methodlar instance = new Methodlar();
instance.Topla(3, 6, out int toplamSonucu);
Console.WriteLine(toplamSonucu);

//Metot Aşırı Yükleme -Overloading

int ifade = 999;
instance.EkranaYazdir(Convert.ToString(ifade));
instance.EkranaYazdir(ifade);
instance.EkranaYazdir("Ahmet", "Mehmet");

//metot imzası
//metotAdı+parametre sayisi + parametre bu üçü aynı ise olmaz. parametresi farklı olmalıdır.


class Methodlar
{
    public void Topla(int a, int b, out int toplam)
    {
        toplam = a + b;
    }

    public void EkranaYazdir(string veri) //overloading
    {
        Console.WriteLine(veri);
    }

    public void EkranaYazdir(int veri) //Overloading
    {
        Console.WriteLine(veri);
    }

    public void EkranaYazdir(string veri1, string veri2) //Overloading
    {
        Console.WriteLine(veri1 + " " + veri2);
    }


}

