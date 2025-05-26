namespace AbstractClass;

class Program
{
    static void Main(string[] args)
    {
        Focus focus = new Focus();
        Console.WriteLine(focus.HangiMarkaninAraci().ToString());
        Console.WriteLine(focus.KacTekerlektenbOlusur());
        Console.WriteLine(focus.StandartRenk().ToString());

        Console.WriteLine("--------------------");

        Civic civic = new Civic();
        Console.WriteLine(civic.HangiMarkaninAraci().ToString());
        Console.WriteLine(civic.KacTekerlektenbOlusur());
        Console.WriteLine(civic.StandartRenk().ToString());
    }
}
