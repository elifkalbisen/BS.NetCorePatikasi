//System.Collections namespace

using System.Collections;

ArrayList liste = new ArrayList();
// liste.Add("Ayşe");
// liste.Add(2);
// liste.Add(true);
// liste.Add('A');

// //içerisinde verilere erişim
// Console.WriteLine(liste[1]); // 2
// foreach (var item in liste)
// {
//     Console.WriteLine(item);
// }

//AddRange metodu
Console.WriteLine("AddRange metodu");
//string[] renkler = { "Kırmızı", "Sarı", "Yeşil" };
List<int> sayilar = new List<int>() { 1, 2, 3, 44, 5, 92, 6 };
//liste.AddRange(renkler);
liste.AddRange(sayilar);
foreach (var item in liste)
{
    Console.WriteLine(item);
}

//sort sıralama
Console.WriteLine("Sort metodu");
liste.Sort();
foreach (var item in liste)
{
    Console.WriteLine(item);
}

//BinarySearch
Console.WriteLine("BinarySearch metodu"); //sıralı liste arama
Console.WriteLine(liste.BinarySearch(5));

//reverse
Console.WriteLine("Reverse metodu");
liste.Reverse();
foreach (var item in liste)
{
    Console.WriteLine(item);
}

//clear
Console.WriteLine("Clear metodu");
liste.Clear();
Console.WriteLine("Liste eleman sayısı: " + liste.Count);