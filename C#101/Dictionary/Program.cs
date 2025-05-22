//system.collections.generic
Dictionary<int, string> kullanicilar = new Dictionary<int, string>();
kullanicilar.Add(10, "Ahmet");
kullanicilar.Add(12, "Mehmet");
kullanicilar.Add(18, "Ali");
kullanicilar.Add(20, "Ayşe");

//Dizi elamanlarına erişim
Console.WriteLine("****Elamana erişim****");
Console.WriteLine(kullanicilar[12]);

foreach (var item in kullanicilar)
    Console.WriteLine(item);

//count
Console.WriteLine("****Count****");
Console.WriteLine(kullanicilar.Count);

//Contains
Console.WriteLine("****Contains****");
Console.WriteLine(kullanicilar.ContainsKey(12)); //true
Console.WriteLine(kullanicilar.ContainsValue("Mehmet denk")); //false

//Remove
Console.WriteLine("****Remove****");
kullanicilar.Remove(12);
foreach (var item in kullanicilar)
    Console.WriteLine(item);

//keys
Console.WriteLine("****Keys****");
foreach (var item in kullanicilar.Keys)
    Console.WriteLine(item);
//values
Console.WriteLine("****Values****");
foreach (var item in kullanicilar.Values)
    Console.WriteLine(item);



