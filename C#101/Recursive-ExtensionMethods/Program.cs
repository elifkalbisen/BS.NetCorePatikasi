//rekürsif - öz yinelemeli fonksiyon : kendi kendini çağıran fonksiyondur.
//faktöriyel hesaplama gibi ve ya üs hesaplama gibi işlemlerde kullanılır.

using System.Diagnostics.Contracts;

int result = 1;
for (int i = 1; i < 5; i++)
{
    result = result * 3;
}
Console.WriteLine(result); // 81 - 3^4 = 81
Islemler instance = new();
Console.WriteLine(instance.Expo(3, 4)); // 81 - 3^4 = 81

//extension metotlar
//extension metotlar - var olan bir sınıfa yeni metot eklemek için kullanılır.
string ifade = "Ali Veli";
bool sonuc = ifade.CheckSpaces();
Console.WriteLine(sonuc); // true - boşluk var
if (sonuc)
{
    Console.WriteLine(ifade.RemoveWithSpaces()); // AliVeli - boşlukları kaldır
}

Console.WriteLine(ifade.MakeUpperCase()); // ALİ VELİ - büyük harf yap
Console.WriteLine(ifade.MakeLowerCase()); // ali veli - küçük harf yap

int[] dizi = { 9, 3, 6, 2, 1, 5, 0 };
dizi.SortArray();
dizi.EkranaYazdir(); // 0 1 2 3 5 6 9 - sıralı dizi
int sayi = 5;
Console.WriteLine(sayi.IsEvenNumber()); // false - çift sayı mı
Console.WriteLine(ifade.GetFirstCharacter()); // 5 - ilk karakteri al


public class Islemler
{
    public int Expo(int sayi, int us)
    {
        if (us < 2)
            return sayi;
        return Expo(sayi, us - 1) * sayi;
    }
    //expo(3,4)
    //expo(3,3) * 3
    //expo(3,2) * 3 * 3
    //expo(3,1) * 3 * 3 * 3
    //expo(3,0) * 3 * 3 * 3 * 3
    //expo(3,0) = 1
    //3 * 3 * 3 * 3 = 81

}

public static class Extension
{
    public static bool CheckSpaces(this string param)
    {
        return param.Contains(" ");
    }
    public static string RemoveWithSpaces(this string param)
    {
        string[] dizi = param.Split(" ");
        return string.Join("*", dizi);
    }

    public static string MakeUpperCase(this string param)
    {
        return param.ToUpper();
    }

    public static string MakeLowerCase(this string param)
    {
        return param.ToLower();
    }

    public static int[] SortArray(this int[] param)
    {
        Array.Sort(param);
        return param;
    }

    public static void EkranaYazdir(this int[] param)
    {
        foreach (var item in param)
        {
            Console.WriteLine(item);
        }
    }

    public static bool IsEvenNumber(this int param)
    {
        return param % 2 == 0;
    }
    
    public static string GetFirstCharacter(this string param)
    {
        return param.Substring(0, 1);
    }

}
