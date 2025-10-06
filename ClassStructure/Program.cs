using System;
using System.Net;

namespace ClassStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address();
            address.SetAddress(
                1, "Rua das Goiabas", "Apto 2B", "123", "2º", "1234-567", "Bairro Legal", "Lisboa", "Portugal"
            );

            Person person = new Person
            {
                Id = 1,
                FirstName = "Hiago",
                LastName = "Franco",
                PhoneNumber = "923456111",
                Email = "hiagofranco2604@gmail.com",
                Address = address
            };

            Console.WriteLine("===== Person Info =====");
            Console.WriteLine("Full Name: " + person.GetFullName());
            Console.WriteLine("Contacts: " + person.GetContacts());
            Console.WriteLine("Address: " + person.GetAddress());
            person.Present();
        }
    }
}
