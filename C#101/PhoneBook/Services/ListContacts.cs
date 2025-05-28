using System;
using PhoneBook.Models;

namespace PhoneBook.Services;

public static class ListContacts
{
    public static void List(PhoneBookService service)
    {
        Console.WriteLine("A-Z için (1), Z-A için (2) seçiniz:");
        string choice = Console.ReadLine();
        if (choice == "1")
        {
            Console.WriteLine("Telefon Rehberi (A-Z Sıralı)");
            Console.WriteLine("*******************************************");
            service.Contacts.Sort((x, y) => x.FirstName.CompareTo(y.FirstName));

            foreach (var c in service.Contacts)
            {
                Console.WriteLine($"{c.FirstName} {c.LastName} - {c.PhoneNumber}");
            }


        }
        else if (choice == "2")
        {
            Console.WriteLine("Telefon Rehberi (Z-A Sıralı)");
            Console.WriteLine("*******************************************");
            service.Contacts.Sort((x, y) => y.FirstName.CompareTo(x.FirstName));
            foreach (var c in service.Contacts)
            {
                Console.WriteLine($"{c.FirstName} {c.LastName} - {c.PhoneNumber}");
            }
        }

    }
}
