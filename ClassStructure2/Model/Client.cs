using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStructure2.Model
{
    public class Client : Person
    {
        public  string? Id { get; set; }
        public string? Name { get; set; }
        public  Address? Address { get; set; }
        public string? Sector { get; set; }
        public string? NIF { get; set; }
        public string? DeliveryAddress { get; set; }
        public  string? PhoneNumber { get; set; }
        public  string? Email { get; set; }

        public Client() { Address = new Address(); }
        public void AddNewClient()
        {
            Console.WriteLine("Vamos adicionar um novo cliente:");
            SetNewPerson();
            Console.Write("Digite o NIF:");
            NIF = Console.ReadLine();
            Console.WriteLine("Digite o endereço de entrega:");
            DeliveryAddress = Console.ReadLine();
        }
        
        public void AddClientAddress()
        {
           Address.SetAddress();
        }
        public void UpdateClientAddress() => Address.SetAddress();

    }
}
