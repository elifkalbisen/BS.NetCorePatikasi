using System;
using Interface2;

namespace AbstractClass;

public class Civic : Otomobil
{
    public override Marka HangiMarkaninAraci()
    {
        return Marka.Honda;
    }
    public override Renk StandartRenk()
    {
        return Renk.Gri; // Civic için standart renk gri olarak belirlenmiştir.
    }
}