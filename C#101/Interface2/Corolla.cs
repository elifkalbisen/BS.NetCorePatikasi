using System;

namespace Interface2;

public class Corolla : IOtomobil
{
    public Marka HangiMarkaninAraci()
    {
        return Marka.Toyota;
    }

    public int KacTekerlektenOlusur()
    {
        return 4;
    }

    public Renk StandartRengiNe()
    {
        return Renk.Beyaz;
    }
}
