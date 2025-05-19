#region Soru1

//Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.

/*
Console.Write("Kaç adet pozitif sayı gireceksiniz? ");
int n = Convert.ToInt32(Console.ReadLine());

if (n <= 0)
{
    Console.WriteLine("Lütfen pozitif bir sayı girin.");
    return;
}

int[] sayilar = new int[n];

for (int i = 0; i < n; i++)
{
    Console.WriteLine("{0}. Pozitif bir sayı girin:", i + 1);
    sayilar[i] = Convert.ToInt32(Console.ReadLine());
}

for (int i = 0; i < n; i++)
{
    if (sayilar[i] % 2 == 0)
    {
        Console.WriteLine("Çift sayı: {0}", sayilar[i]);
    }
}  
*/

#endregion

#region Soru2
//Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.

/*

Console.WriteLine("pozitif iki sayı girin (n, m): ");
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
int[] sayilar = new int[n];



for (int i = 0; i < n; i++)
{
    Console.WriteLine("{0}. Pozitif bir sayı girin:", i + 1);
    sayilar[i] = Convert.ToInt32(Console.ReadLine());
}

for (int i = 0; i < n; i++)
{
    if (sayilar[i] == m || sayilar[i] % m == 0)
    {
        Console.WriteLine("m'e eşit veya tam bölünen sayı: {0}", sayilar[i]);
    }
}
*/
#endregion

#region Soru3
//Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

/*
Console.WriteLine("Pozitif bir sayı girin (n): ");
int n = Convert.ToInt32(Console.ReadLine());
string[] kelimeler = new string[n];
for (int i = 0; i < n; i++)
{
    Console.WriteLine("{0}. Kelimeyi girin:", i + 1);
    kelimeler[i] = Console.ReadLine();
}
Array.Reverse(kelimeler);
Console.WriteLine("Kelimeler sondan başa doğru:");
foreach (string kelime in kelimeler)
{
    Console.WriteLine(kelime);
}
*/
#endregion

#region Soru4
//Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

Console.WriteLine("Bir cümle yazın:");
string cümle = Console.ReadLine();
string[] kelimeler = cümle.Split(' ');
int kelimeSayisi = kelimeler.Length;
int harfSayisi = 0;
foreach (string kelime in kelimeler)
{
    harfSayisi += kelime.Length;
}

Console.WriteLine("Kelime sayısı: " + kelimeSayisi);
Console.WriteLine("Harf sayısı: " + harfSayisi);

#endregion

