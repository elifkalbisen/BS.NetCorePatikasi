using System;
using Interface2;

namespace AbstractClass;

public abstract class Otomobil
{
    public int KacTekerlektenbOlusur()
    {
        return 4; // Otomobiller genellikle 4 tekerleklidir.
    }
    public virtual Renk StandartRenk()
    {
        return Renk.Beyaz; // Otomobillerin standart rengi genellikle beyazdır.
    }
    public abstract Marka HangiMarkaninAraci(); // Her otomobil markası için farklı bir marka adı döndürülmelidir.

}
