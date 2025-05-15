
// try
// {
//     Console.WriteLine("Bir sayı giriniz:");
//     int sayi = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Sayı: " + sayi);
// }

// catch (Exception ex)
// {
//     Console.WriteLine("Hata: " + ex.Message.ToString());
// }

// finally
// {
//     Console.WriteLine("İşlem Tamamlandı.");
// }



//***************************

try
{
    //int a = int.Parse(null);
    //int a = int.Parse("test");
    int a= int.Parse("-20000000000");
}

catch (ArgumentNullException ex)
{
    Console.WriteLine("Boş değer girdiniz. ");
    Console.WriteLine(ex);
}
catch (FormatException ex)
{
    Console.WriteLine("Veri formatı hatalı. ");
    Console.WriteLine(ex);
}
catch (OverflowException ex)
{
    Console.WriteLine("Sayı çok büyük ve çok küçük bir değer. ");
    Console.WriteLine(ex);
}
finally
{
    Console.WriteLine("İşlem Tamamlandı.");
}


