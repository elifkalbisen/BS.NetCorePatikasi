using System.Runtime;
using System.Runtime.CompilerServices;

namespace Enum;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Days.Pazartesi);
        Console.WriteLine((int)Days.Cumartesi);
        int sicaklik = 32;

        if (sicaklik <= (int)Weather.Normal)
            Console.WriteLine("Dışarıya çıkmak için havanın biraz daha ısınmasını beklelim.");
        else if (sicaklik >= (int)Weather.Sicak)
            Console.WriteLine("Dışarıya çıkmak için çok sıcak bir gün");
        else if (sicaklik >= (int)Weather.Normal && sicaklik < (int)Weather.CokSicak)
            Console.WriteLine("Hadi dışarıya çıkalım, hava güzel.");
            
        


    }
    enum Days
    {
        Pazartesi,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma = 23,
        Cumartesi,
        Pazar
    }

    enum Weather
    {
        Soguk = 5,
        Normal = 20,
        Sicak = 25,
        CokSicak = 30
    }
}
