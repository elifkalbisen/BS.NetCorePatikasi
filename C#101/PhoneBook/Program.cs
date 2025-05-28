using PhoneBook.Services;
using PhoneBook.Models;

namespace PhoneBook;

class Program
{
    static void Main(string[] args)
    {
        var service = new PhoneBookService();
        while (true)
        {

            Console.WriteLine(" Lütfen yapmak istediğiniz işlemi seçiniz :)");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncellemek");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak");
            string? choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    AddContact.Add(service);
                    break;
                case "2":
                    DeleteContact.Delete(service);
                    break;
                case "3":
                    UpdateContact.Update(service);
                    break;
                case "4":
                    ListContacts.List(service);
                    break;
                case "5":
                    SearchContacts.Search(service);
                    break;
                default:
                    Console.WriteLine("Geçersiz seçim yaptınız");
                    break;
            }
        }
    }
}
