using System;
using Interface2;

namespace AbstractClass;

public class Corolla : Otomobil
{
    public override Marka HangiMarkaninAraci()
    {
        return Marka.Toyota;
    }

}
