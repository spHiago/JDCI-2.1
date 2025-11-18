using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Loader;
using System.Text;
using System.Threading.Tasks;

namespace ClassStructure2.Model
{
    public class Person
    {
        public int? Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public Address Address { get; set; }

        public Person()
        {
            Address = new Address();
        }
        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
        public void GetContacts()
        {
            Console.WriteLine($"Numero de telefone: {PhoneNumber}");
            Console.WriteLine($"Endereço de email: {Email}");
        }
        public void GetAddress()
        {
            Address.GetAddress();
        }
        public void SetNewPerson()
        {
            Console.Write("Digite o Id da pessoa:");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o primeiro nome:");
            FirstName = Console.ReadLine();
            Console.Write("Digite o ultimo nome:");
            LastName = Console.ReadLine();
            Console.Write("Digite o numero de telefone:");
            PhoneNumber = Console.ReadLine();
            Console.Write("Digite o email:");
            Email = Console.ReadLine();
        }
    }
}
