using System;
using PhoneBook.Models;

namespace PhoneBook.Services;

public static class DeleteContact
{
    public static void Delete(PhoneBookService service)
    {
        Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
        String input = Console.ReadLine();

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
            Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
            Console.WriteLine("*Silmeyi sonlandırmak için : (1)");
            Console.WriteLine("*Yeniden denemek için      : (2)");

            string? choice = Console.ReadLine();

            if (choice == "1")
                return;
            else if (choice == "2")
                Delete(service);
            else
            {
                Console.WriteLine("Geçersiz seçim. İşlem sonlandırılıyor.");
                return;
            }
        }
        else
        {
            Console.WriteLine($"{contact.FirstName},{contact.LastName} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)");
            if (Console.ReadLine().ToLower() == "y")
            {
                service.Contacts.Remove(contact);
                Console.WriteLine($"{contact.FirstName} {contact.LastName} rehberden silindi.");
            }
        }

    }
}
