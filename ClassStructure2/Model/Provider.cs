using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStructure2.Model
{
    public class Provider : Person
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public Address? Address { get; set; }
        public string? ContactPersonName { get; set; }
        public string? ContactPersonJobTitle { get; set; }
        public string? PhoneNumber { get; set; }
        public string? ContactPersonPhoneNumber { get; set; }
        public string? ContactPersonEmail { get; set; }
        public string? Sector {  get; set; }

        public void AddProviderContactPerson()
        {
            Console.WriteLine("\n--- Adicionar Contacto do Fornecedor ---");
            SetNewPerson();
            Console.Write("Digite o cargo (job title): ");
            ContactPersonJobTitle = Console.ReadLine();
            Console.WriteLine("Contacto do fornecedor adicionado.");
            Console.WriteLine("-----------------------------------");
        }
        public void GetProviderDetails()
        {
            Console.WriteLine("\n--- Detalhes do Fornecedor ---");
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Nome: {Name}");
            Console.WriteLine($"Endereço: {Address}");
            Console.WriteLine($"Nome de Contato da Pessoa: {ContactPersonName}");
            Console.WriteLine($"Contato do Titulo de Trabalho da Pessoa: {ContactPersonJobTitle}");
            Console.WriteLine($"Numero de Telefone: {PhoneNumber}");
            Console.WriteLine($"Numero de Contato Telefonico da Pessoa: {ContactPersonPhoneNumber}");
            Console.WriteLine($"Email de Contato da Pessoa: {ContactPersonEmail}");
            Console.WriteLine($"Setor: {Sector}");
            Console.WriteLine("-------------------------------\n");
        }

        public void UptadeProviderContactPerson()
        {
            Console.WriteLine("\n--- Atualizar Contacto do Fornecedor ---");
            SetNewPerson();
            Console.WriteLine("Digite o novo cargo:");
            ContactPersonJobTitle = Console.ReadLine();
            Console.WriteLine("Contacto do fornecedor atualizado.");
            Console.WriteLine("-----------------------------------");
        }

    }
}
