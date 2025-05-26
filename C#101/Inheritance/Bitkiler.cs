using System;

namespace Inheritance;

public class Bitkiler : Canlilar
{
    protected void Fotosentez()
    {
        Console.WriteLine("Bitkiler fotosentez yapar.");
    }

}

public class TohumluBitkiler : Bitkiler
{
    public TohumluBitkiler()
    {
        base.Fotosentez(); // Tohumlu bitkiler de fotosentez yapar.
    }

    public void TohumUretme()
    {
        Console.WriteLine("Tohumlu bitkiler tohum üretir.");
    }
}

public class TohumsuzBitkiler : Bitkiler
{
    public TohumsuzBitkiler()
    {
        base.Fotosentez(); // Tohumsuz bitkiler de fotosentez yapar.
    }
    public void SporUretme()
    {
        Console.WriteLine("Tohumsuz bitkiler spor üretir.");
    }
}