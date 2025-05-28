using System;
using System.Collections.Generic;
using PhoneBook.Models;

namespace PhoneBook.Services;


public static class SearchContacts
{
    public static void Search(PhoneBookService service)
    {
        Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
        Console.WriteLine("**********************************************");
        Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
        Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
        string choice = Console.ReadLine();
        List<Contact> results = new List<Contact>(); //arama sonuçlarını tutacak liste
        if (choice == "1")
        {
            Console.WriteLine("İsim veya soyisim giriniz:");
            string searchTerm = Console.ReadLine();
            foreach (var c in service.Contacts)
            {
                if (c.FirstName.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) || c.LastName.Contains(searchTerm, StringComparison.OrdinalIgnoreCase))
                {
                    results.Add(c);
                }
            }
        }else if (choice == "2")
        {
            Console.WriteLine("Telefon numarası giriniz:");
            string searchTerm = Console.ReadLine();
            foreach (var c in service.Contacts)
            {
                if (c.PhoneNumber.Contains(searchTerm))
                {
                    results.Add(c);
                }
            }
        }else
        {
            Console.WriteLine("Geçersiz seçim yaptınız. Lütfen tekrar deneyiniz.");
            Search(service);
        }

        if (results.Count == 0)
            Console.WriteLine("Arama kriterlerinize uygun sonuç bulunamadı.");
        Console.WriteLine("Arama sonuçlarınız:");
        Console.WriteLine("**********************************************");
        foreach (var c in results)
        {
            Console.WriteLine($"İsim: {c.FirstName} Soyisim: {c.LastName}, Telefon Numarası: {c.PhoneNumber}");
        }

    }
}
