using System;
using PhoneBook.Models;

namespace PhoneBook.Services;

public static class UpdateContact
{
    public static void Update(PhoneBookService service)
    {
        Console.WriteLine(" Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz:");
        string input = Console.ReadLine();
        Contact contact = null;
        foreach (var c in service.Contacts)
        {
            if (c.FirstName == input || c.LastName == input)
            {
                contact = c;
                break;
            }
        }
        if (contact == null)
        {
            Console.WriteLine(" Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
            Console.WriteLine("* Güncellemeyi sonlandırmak için : (1)");
            Console.WriteLine("* Yeniden denemek için           : (2)");
            string choice = Console.ReadLine();
            if (choice == "1")
                return;
            else if (choice == "2")
                Update(service);
        }
        Console.WriteLine($"{contact.FirstName} {contact.LastName}  kişinin yeni Telefon Numarasını giriniz:");
        contact.PhoneNumber = Console.ReadLine();
        Console.WriteLine($"{contact.FirstName} {contact.LastName} isimli kişinin telefon numarası güncellendi.");
    }
}
