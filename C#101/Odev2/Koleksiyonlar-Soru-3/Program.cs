using System.ComponentModel;

Console.WriteLine("Lütfen bir cümle yazın.");
string? cumle = Console.ReadLine();
char[] dizi = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' ,'A', 'E', 'I', 'İ', 'O', 'Ö', 'U', 'Ü' };
List<Char> sesliler = new List<char>();
foreach (char harf in cumle)
{
    if (dizi.Contains(harf))
        sesliler.Add(harf);
}

sesliler.Sort();
foreach (char sesli in sesliler)
{
    Console.Write(sesli+" ");
}