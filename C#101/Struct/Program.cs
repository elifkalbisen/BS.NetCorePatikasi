﻿namespace Struct;

class Program
{
    static void Main(string[] args)
    {
        Dikdortgen dikdortgen = new Dikdortgen();
        dikdortgen.KisaKenar = 5;
        dikdortgen.UzunKenar = 10;
        Console.WriteLine("Class Dikdörtgen Alanı: " + dikdortgen.AlanHesapla());

        Dikdortgen_Struct dikdortgenStruct = new Dikdortgen_Struct(5, 10);
        Console.WriteLine("Struct Dikdörtgen Alanı: " + dikdortgenStruct.AlanHesapla());
    }

    class Dikdortgen
    {
        public int KisaKenar;
        public int UzunKenar;
        public Dikdortgen()
        {
            KisaKenar = 3;
            UzunKenar = 4;
        }
        public long AlanHesapla()
        {
            return KisaKenar * UzunKenar;
        }

    }

    struct Dikdortgen_Struct
    {
        public int KisaKenar;
        public int UzunKenar;
        public Dikdortgen_Struct(int kisaKenar, int uzunKenar)
        {
            KisaKenar = kisaKenar;
            UzunKenar = uzunKenar;
        }
        public long AlanHesapla()
        {
            return KisaKenar * UzunKenar;
        }
    }
}
