using System;
using PhoneBook.Models;

namespace PhoneBook.Services;
public static class AddContact
{
    public static void Add(PhoneBookService service)
    {
        Console.WriteLine("Lütfen isim giriniz             :");
        string? firstName = Console.ReadLine();
        Console.WriteLine("Lütfen soyisim giriniz          :");
        string? lastName = Console.ReadLine();
        Console.WriteLine("Lütfen telefon numarası giriniz :");
        string? phoneNumber = Console.ReadLine();
        service.Contacts.Add(new Contact
        {
            FirstName = firstName,
            LastName = lastName,
            PhoneNumber = phoneNumber
        });
        Console.WriteLine($"{firstName} {lastName} başarıyla eklendi.");
    }
}
