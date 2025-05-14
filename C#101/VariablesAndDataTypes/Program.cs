
int deger = 2;
string degisken = null;
string Degisken = null;
byte b = 5 ; // 1 byte = 0 - 255
sbyte s = 5; // 1 byte = -128 - 127
short s1 = 5; // 2 byte = -32768 - 32767
ushort us = 5; // 2 byte = 0 - 65535
Int16 i16 = 2; // 2 byte = -32768 - 32767
int i = 2; // 4 byte = -2147483648 - 2147483647
Int32 i32 = 2; // 4 byte = -2147483648 - 2147483647
Int64 i64 = 2; // 8 byte = -9223372036854775808 - 9223372036854775807
uint u = 2; // 4 byte = 0 - 4294967295
long l = 2; // 8 byte = -9223372036854775808 - 9223372036854775807
ulong ul = 2; // 8 byte = 0 - 18446744073709551615
float f = 5; // 4 byte = 1.5 x 10^-45 to 3.4 x 10^38
double d = 5; // 8 byte = 5.0 x 10^-324 to 1.7 x 10^308
decimal de = 5;


char c = 'A'; // 2 byte = 0 - 65535
string str = "Hello World"; // 2 byte = 0 - 65535
bool b1 = true; // 1 byte = 0 - 255 //true or false
DateTime dt = DateTime.Now;
Console.WriteLine("Hello, World!");

object o = "x";
object o1 = 'y';
object o2 = 4;
object o3 = 4.3;

//string ifadeler

string str1 = string.Empty;
str1 = "Ahmet Yılmaz";
string ad = "Ahmet";
string soyad = "Yılmaz";
string tamAd = ad + " " + soyad;
Console.WriteLine(tamAd);

//integer ifadeler

int integer1 = 5;
int integer2 = 3;
int integer3 = integer1 * integer2;
Console.WriteLine(integer3);

//boolean ifadeler

bool bool1 = 10 > 2;
bool bool2 = 10 < 2;

//değişken dönüşümleri

string str20 = "20";
int int20 = 20;

string yeniDeger = str20 + int20.ToString();
Console.WriteLine(yeniDeger); // 2020

int int21 = int20 + Convert.ToInt32(str20);
Console.WriteLine(yeniDeger); // 40


int int22 = int20 + int.Parse(str20);

//datetime
string datetime = DateTime.Now.ToString("dd.MM.yyyy");
Console.WriteLine(datetime); // 23.10.2023

string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
Console.WriteLine(datetime2); // 23/10/2023

string datetime3 = DateTime.Now.ToString("HH:mm");
Console.WriteLine(datetime3); // 14:30