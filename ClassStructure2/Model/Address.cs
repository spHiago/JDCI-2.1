using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassStructure2
{
    public class Address
    {
        public string? Id { get; set; }
        public string? Street { get; set; }
        public string? Street2 { get; set; }
        public string? DoorNumber { get; set; }
        public string? Floor { get; set; }
        public string? PostalCode { get; set; }
        public string? Locale { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public void SetAddress()
        {
            Console.Write("Digite o Id do endereço: ");
            Id = Console.ReadLine();


            Console.Write("Digite a Rua: ");
                  Street = Console.ReadLine();

            Console.Write("Digite a Rua2 (se houver): ");
                Street2 = Console.ReadLine();

            Console.Write("Digite o número da porta: ");
                 DoorNumber = Console.ReadLine();

            Console.Write("Digite o Andar:");
                Floor = Console.ReadLine();

            Console.Write("Digite o Código Postal: ");
                PostalCode = Console.ReadLine();

            Console.Write("Digite o Local: ");
                Locale = Console.ReadLine();

            Console.Write("Digite a Cidade: ");
                City = Console.ReadLine();

            Console.Write("Digite o País: ");
               Country = Console.ReadLine();

          
        }

        public void GetAddress()
        {
            Console.WriteLine("\n--- Endereço ---");
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Rua: {Street}");
            Console.WriteLine($"Rua2: {Street2}");
            Console.WriteLine($"Número da porta: {DoorNumber}");
            Console.WriteLine($"Andar: {Floor}");
            Console.WriteLine($"Código Postal: {PostalCode}");
            Console.WriteLine($"Local: {Locale}");
            Console.WriteLine($"Cidade: {City}");
            Console.WriteLine($"País: {Country}");
            Console.WriteLine("-------------------");
        }
    }
}
