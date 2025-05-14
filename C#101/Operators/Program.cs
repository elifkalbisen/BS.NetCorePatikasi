//Atama ve İşlemli Atama
int x = 3;
int y = 3;
y = y + 2;
Console.WriteLine(y);
y += 2; //y=y+2
Console.WriteLine(y);
y /= 1; //y=y/1
Console.WriteLine(y);

x *= 2; //x=x*2
Console.WriteLine(x);


//Mantıksal Operatörler
// &&, ||, !

bool isSuccess = true;
bool isCopmleted = false;

if (isSuccess && isCopmleted)
{
    Console.WriteLine("Perfect!");
}
if (isSuccess || isCopmleted)
{
    Console.WriteLine("Great!");
}
if (isSuccess && !isCopmleted)
{
    Console.WriteLine("Fine!");
}

//İlişkisel Operatörler
// <, >, <=, >=, ==, !=

int a = 3;
int b = 4;
bool sonuc = a < b;
Console.WriteLine(sonuc); //true
sonuc = a > b;
Console.WriteLine(sonuc); //false
sonuc = a <= b;
Console.WriteLine(sonuc); //true
sonuc = a >= b;
Console.WriteLine(sonuc); //false
sonuc = a == b;
Console.WriteLine(sonuc); //false
sonuc = a != b;
Console.WriteLine(sonuc); //true



//Aritmetik Operatörler
// +, -, *, /, %

int sayi1 = 10;
int sayi2 = 5;
int sonuc1 = sayi1 / sayi2;
Console.WriteLine(sonuc1); //2
sonuc1 = sayi1 * sayi2;
Console.WriteLine(sonuc1); //50
sonuc1 = sayi1 + sayi2;
Console.WriteLine(sonuc1); //15
sonuc1 = ++sayi1;
Console.WriteLine(sonuc1); //11

// % mod alma
int sonuc2 = 20 % 3;
Console.WriteLine(sonuc2); //2
