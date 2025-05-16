int month = DateTime.Now.Month;

switch (month) //kontrol ettiğimiz koşulu
{
    case 1:
        Console.WriteLine("Ocak");
        break;
    case 2:
        Console.WriteLine("Şubat");
        break;
    case 4:
        Console.WriteLine("Nisan");
        break;
    case 3:
        Console.WriteLine("Mart");
        break;
    case 5:
        Console.WriteLine("Mayıs");
        break;
    case 6:
        Console.WriteLine("Haziran");
        break;

    default:
        Console.WriteLine("Yanlış veri girdiniz");
        break;
}


switch (month)
{
    case 12:
    case 1:
    case 2:
        Console.WriteLine("Kış");
        break;
    case 3:
    case 4:
    case 5:
        Console.WriteLine("İlkbahar");
        break;
    case 6:
    case 7:
    case 8:
        Console.WriteLine("Yaz");
        break;
    case 9:
    case 10:
    case 11:
        Console.WriteLine("Sonbahar");
        break;
    default:
        Console.WriteLine("Yanlış veri girdiniz");
    break;
}