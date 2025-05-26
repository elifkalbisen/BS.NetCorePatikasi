namespace Inheritance;

class Program
{
    static void Main(string[] args)
    {
        //                      Canlılar
        //                         |
        //         Bitkiler                   Hayvanlar
        //      |           |            |                |
        //  Tohumlu      Tohumsuz    Sürüngenler       Kuşlar

        TohumluBitkiler tohumluBitki = new TohumluBitkiler();
        tohumluBitki.Beslenme();
        tohumluBitki.Solunum();
        tohumluBitki.Bosaltim();
        tohumluBitki.TohumUretme();
        Console.WriteLine("--------------------");
        Kuslar marti = new Kuslar();
        marti.Beslenme();
        marti.Solunum();
        marti.Bosaltim();
        marti.Adaptasyon();
        marti.Ucmak();    
    }
}
