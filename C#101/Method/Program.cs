//metotlar aslında fonksiyonlardır.
//programaları kodları parçalarına ayırmak için kullanılır.
//daha anlaşılır ve daha kolay yönetilebilir hale getirir.
//method bir çok yerde kullanıldığında tek bir yerde değişim yaparak tüm programda değişiklik yapmamızı sağlar.
//methodlar classların içinde tanımlanır.
//



//erişim_belirteci geri_dönüş_tipi method_ismi(parametreler)
//{
//method gövdesi
//}

//method ismi ve parametreler camelCase ile yazılır.
//method ismi önemlidir.
//isminden içindeki işlevi anlamalıyız.



int a = 2;
int b = 3;
Console.WriteLine(a + b);


int sonuc = Topla(a, b); // method çağrısı
Console.WriteLine(sonuc);

Metotlar ornek = new Metotlar(); // Metotlar classından örnek alıyoruz.
ornek.EkranaYazdir(Convert.ToString(sonuc)); // EkranaYazdir methodunu çağırıyoruz.

int sonuc2 = ornek.ArttırVeTopla(ref a, ref b); // ArttırVeTopla methodunu çağırıyoruz.
ornek.EkranaYazdir(Convert.ToString(sonuc2)); // EkranaYazdir methodunu çağırıyoruz.
ornek.EkranaYazdir(Convert.ToString(a+b));


static int Topla(int deger1, int deger2) // static yazıyoruz çünkü mainde çağırabilmemiz için static olmalı.
//static yazmazsak methodu çağırmak için class ismiyle çağırmamız gerekir.
{
    return deger1 + deger2;
}


class Metotlar
{
    public void EkranaYazdir(string veri) //erişilebilir olması için public yazıyoruz.
    //erişim belirteci public, private, internal, protected olabilir.
    {
        Console.WriteLine(veri);
    }

    public int ArttırVeTopla(ref int deger1,ref int deger2)
    {
        deger1 += 1; // deger1'i 1 arttırıyoruz.
        deger2 += 1; // deger2'yi 1 arttırıyoruz.
        return deger1 + deger2; // deger1 ve deger2'yi topluyoruz.
    }
} 

//Ref Kullanımı

//Bir fonksiyona parametre aktarırken değer veya referans tipinde paramtere verebiliriz.

//Değer tipleri metoda bit bit kopyalanır. Yani int bir değişkeni parametre olarak değer tipinde bir fonksiyona verdiğimizde; fonksiyon çalışırken bellekten integer bir değişkeni saklayabilecek kadar yer ayrılır ve gönderilen parametre orada saklanır Fonksiyon içerisinde parametre üzerinde değişiklik yapıldığında ana değişken değişmez. Sadece kopyası üzerinde değişiklik yapılmış olur. Fonksiyon sonlandığındaysa bellekten silinir. Yani yaşam süresi sona erer.
//Değer Tiplerini şu şekildedir: int, long, float, double, decimal, char, bool, byte, short, struct, enum

//Referans olarak bir atama yapıldığında ise fonksiyona ilgili değişkenin bellekteki adresi gönderilmiş gibi düşünebilirsiniz. Dolayısıyla fonksiyon asıl değişken üzerinde değişiklik yapar. Fonksiyon içerisinde bir değişiklik yapıldığında çağırıldığı yerdeki değişken de değişikliğe uğramış olur. Yani değeri değişir. Bu nedenle ref anahtar kelimesini kullanırken çok dikkatli olunmalıdır.