//DateTime
Console.WriteLine(DateTime.Now); //günün tarihini getirir.
Console.WriteLine(DateTime.Now.Date); //sadece tarihi getirir.
Console.WriteLine(DateTime.Now.Day); //günün numarasını getirir.
Console.WriteLine(DateTime.Now.Month); //ayın numarasını getirir.
Console.WriteLine(DateTime.Now.Year); //yılı getirir.
Console.WriteLine(DateTime.Now.Hour); //saati getirir.
Console.WriteLine(DateTime.Now.Minute); //dakikayı getirir.
Console.WriteLine(DateTime.Now.Second); //saniyeyi getirir.

Console.WriteLine(DateTime.Now.DayOfWeek); //haftanın gününü getirir.
Console.WriteLine(DateTime.Now.DayOfYear); //yılın kaçıncı günü olduğunu getirir.

Console.WriteLine(DateTime.Now.ToLongDateString()); //tarihi uzun formatta getirir.
Console.WriteLine(DateTime.Now.ToShortDateString()); //tarihi kısa formatta getirir.
Console.WriteLine(DateTime.Now.ToLongTimeString()); //saati uzun formatta getirir.
Console.WriteLine(DateTime.Now.ToShortTimeString()); //saati kısa formatta getirir.

Console.WriteLine(DateTime.Now.AddDays(2)); //5 gün ekler.
Console.WriteLine(DateTime.Now.AddHours(2)); //2 saat ekler.
Console.WriteLine(DateTime.Now.AddSeconds(2)); //2 saniye ekler.
Console.WriteLine(DateTime.Now.AddMonths(2)); //2 ay ekler.
Console.WriteLine(DateTime.Now.AddYears(2)); //2 yıl ekler.
Console.WriteLine(DateTime.Now.AddMilliseconds(50)); //50 milisaniye ekler.

//DateTime format
Console.WriteLine(DateTime.Now.ToString("dd")); //24
Console.WriteLine(DateTime.Now.ToString("ddd")); //sal
Console.WriteLine(DateTime.Now.ToString("dddd")); //salı

Console.WriteLine(DateTime.Now.ToString("MM")); //10
Console.WriteLine(DateTime.Now.ToString("MMM")); //Eki
Console.WriteLine(DateTime.Now.ToString("MMMM")); //Ekim

Console.WriteLine(DateTime.Now.ToString("yy")); //23
Console.WriteLine(DateTime.Now.ToString("yyyy")); //2023

Console.WriteLine(DateTime.Now.ToString("HH")); //14
Console.WriteLine(DateTime.Now.ToString("hh")); //02
Console.WriteLine(DateTime.Now.ToString("mm")); //30

//Math Kütüphaneleri

Console.WriteLine(Math.Abs(-25)); //mutlak değer //25
Console.WriteLine(Math.Sin(30)); //sinüs değeri
Console.WriteLine(Math.Cos(30)); //kosinüs değeri
Console.WriteLine(Math.Tan(30)); //tanjant değeri

Console.WriteLine(Math.Ceiling(25.3)); //25.3'ü yukarı yuvarlar //26
Console.WriteLine(Math.Round(25.3)); //25.3'ü en yakın tam sayıya yuvarlar //25
Console.WriteLine(Math.Floor(25.7)); //25.7'yi aşağı yuvarlar //25

