using System;
using Interface2;

namespace AbstractClass;

public class Focus : Otomobil
{
    public override Marka HangiMarkaninAraci()
    {
        return Marka.Ford;
    }
}
