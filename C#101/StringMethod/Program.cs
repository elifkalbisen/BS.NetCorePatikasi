
string degişken = "Dersimiz CSharp, Hoşgeldiniz!";
string degisken2 = "CSharp";

//Length
Console.WriteLine(degişken.Length);
//ToUpper,ToLower
Console.WriteLine(degişken.ToUpper());
Console.WriteLine(degişken.ToLower());
//Concat
Console.WriteLine(string.Concat(degişken, " Merhaba!"));

//compare, compareto
Console.WriteLine(degişken.CompareTo(degisken2)); // 0 ise eşit, 1 ise büyük, -1 ise küçük
Console.WriteLine(string.Compare(degişken, degisken2, true)); // true ise büyük/küçük harf duyarsız, false ise duyarlı
Console.WriteLine(string.Compare(degişken, degisken2, false)); // true ise büyük/küçük harf duyarsız, false ise duyarlı

//Contains
Console.WriteLine(degişken.Contains(degisken2)); // true ise içeriyor, false ise içermiyor.
Console.WriteLine(degişken.EndsWith("Hoşgeldiniz!")); // true ise bitiyorsa, false ise bitmiyorsa
Console.WriteLine(degişken.StartsWith("Merhaba")); // true ise başlıyorsa, false ise başlamıyorsa

//indexof
Console.WriteLine(degişken.IndexOf("CS")); // "CS" ifadesinin ilk geçtiği indexi verir. Eğer yoksa -1 döner.
Console.WriteLine(degişken.IndexOf("selam")); // "selam" ifadesinin ilk geçtiği indexi verir. Eğer yoksa -1 döner.

//Insert
Console.WriteLine(degişken.Insert(0, "Merhaba! ")); // 0. indexe Merhaba! ekler.

//LastIndexOf
Console.WriteLine(degişken.LastIndexOf("i")); // "i" ifadesinin son geçtiği indexi verir. Eğer yoksa -1 döner.

//PadLeft, PadRight
Console.WriteLine(degişken + degisken2.PadLeft(30)); // 30 karaktere tamamlar, soldan boşluk ekler.
Console.WriteLine(degişken + degisken2.PadLeft(30,'*')); // 30 karaktere tamamlar, soldan * ekler.
Console.WriteLine(degişken.PadRight(50) + degisken2); // 50 karaktere tamamlar, sağdan boşluk ekler.
Console.WriteLine(degişken.PadRight(50, '-') + degisken2); // 50 karaktere tamamlar, sağdan - ekler.

//REMOVE

Console.WriteLine(degişken.Remove(10)); // 10. indexten sonrasını siler.
Console.WriteLine(degişken.Remove(5, 3)); // 5. indexten 3 karakter siler.
Console.WriteLine(degişken.Remove(0, 1)); // 0. indexten 1 karakter siler.

//Replace
Console.WriteLine(degişken.Replace("CSharp", "C#")); // CSharp kelimesini C# ile değiştirir.
Console.WriteLine(degişken.Replace(" ", "*")); // Boşlukları * ile değiştirir.

//Split

Console.WriteLine(degişken.Split(' ')[1]); // Boşluktan ayırır ve 1. indexi alır.

//Substring
Console.WriteLine(degişken.Substring(4)); // 4. indexten sonrasını alır.
Console.WriteLine(degişken.Substring(4, 6)); // 4. indexten 6 karakter alır.