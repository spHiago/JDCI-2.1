using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStructure
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
        public string Sector { get; set; }
        public string Nif { get; set; }
        public Address DeliveryAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public void AddNewClient()
        {
            Console.WriteLine("Enter Client Name:");
            Name = Console.ReadLine();

            Console.WriteLine("Enter Sector:");
            Sector = Console.ReadLine();

            Console.WriteLine("Enter NIF:");
            Nif = Console.ReadLine();

            Console.WriteLine("Enter Phone Number:");
            PhoneNumber = Console.ReadLine();

            Console.WriteLine("Enter Email:");
            Email = Console.ReadLine();

            Address = new Address();
            Console.WriteLine("Enter Main Address:");
            Address.SetAddress();

            DeliveryAddress = new Address();
            Console.WriteLine("Enter Delivery Address:");
            DeliveryAddress.SetAddress();
        }

        public void AddClientAddress()
        {
            Address = new Address();
            Address.SetAddress();
        }

        public void UpdateClientAddress()
        {
            Console.WriteLine("Updating client address...");
            Address.SetAddress();
        }
    }

}
