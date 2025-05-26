using System;

namespace Inheritance;

public class Hayvanlar : Canlilar
{
    public void Adaptasyon()
    {
        Console.WriteLine("Hayvanlar adaptasyon gösterir.");
    }
}

public class Surungenler : Hayvanlar
{
    public void SogukKanli()
    {
        Console.WriteLine("Sürüngenler soğukkanlıdır.");
    }
}

public class Kuslar : Hayvanlar
{
    public void Ucmak()
    {
        Console.WriteLine("Kuşlar uçar.");
    }
}
