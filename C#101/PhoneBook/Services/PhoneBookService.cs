using System;

namespace PhoneBook.Services;
using PhoneBook.Models;

public class PhoneBookService
{
    public List<Contact> Contacts { get; private set; }

    public PhoneBookService()
    {
        Contacts = new List<Contact>
        {
            new Contact {FirstName="Ali", LastName="Yılmaz", PhoneNumber="1234567890"},
            new Contact {FirstName="Ayşe", LastName="Demir", PhoneNumber="0987654321"},
            new Contact {FirstName="Mehmet", LastName="Kara", PhoneNumber="1122334455"},
            new Contact {FirstName="Fatma", LastName="Çelik", PhoneNumber="5566778899"},
            new Contact {FirstName="Ahmet", LastName="Öztürk", PhoneNumber="9988776655"}
        };
    }


}
