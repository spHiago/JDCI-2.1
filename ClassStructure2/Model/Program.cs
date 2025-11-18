using System;
using System.Diagnostics;
using ClassStructure2.Model;

namespace ClassStructure2
{
    public class Program
    {
        public static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("\n=== Bem-Vindo! ===");
                Console.WriteLine("Selecione a opção desejada");
                Console.WriteLine("1 - Pessoa");
                Console.WriteLine("2 - Empregado");
                Console.WriteLine("3 - Fornecedor");
                Console.WriteLine("4 - Cliente");
                Console.WriteLine("0 - Sair");
                Console.Write("Opção: ");

                string? opc = Console.ReadLine();

                switch (opc)
                {
                    case "1":
                        MenuPessoa();
                        break;
                    case "2":
                        MenuFuncionario();
                        break;
                    case "3":
                        MenuFornecedor();
                        break;
                    case "4":
                        MenuCliente();
                        break;
                    case "0":
                        Console.WriteLine("Encerrando...");
                        return;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }

        static void MenuCliente()
        {
            Client client = new Client();

            while (true)
            {
                Console.WriteLine("\n=== MENU CLIENTE ===");
                Console.WriteLine("1 - Adicionar novo cliente.");
                Console.WriteLine("2 - Adicionar endereço.");
                Console.WriteLine("3 - Atualizar endereço.");
                Console.WriteLine("0 - Voltar");
                Console.Write("Opção:");
                string? op = Console.ReadLine();

                switch (op)
                {
                    case "1":
                        client.AddNewClient();
                        break;
                    case "2":
                        client.AddClientAddress();
                        break;
                    case "3":
                        client.UpdateClientAddress();
                        break;
                    case "0":
                        Console.WriteLine("Voltando...");
                        return;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;

                }

            }
        }

        static void MenuFuncionario()
        {
            Employee employee = new Employee();

            while (true)
            {
                Console.WriteLine("\n=== MENU FUNCIONÁRIO ===");
                Console.WriteLine("1 - Adicionar novo funcionário.");
                Console.WriteLine("2 - Ver detalhes do funcionário.");
                Console.WriteLine("3 - Alterar salário.");
                Console.WriteLine("4 - Alterar departamento.");
                Console.WriteLine("5 - Alterar descrição de trabalho.");
                Console.WriteLine("6 - Alterar detalhes do funcionário.");
                Console.WriteLine("0 - Voltar");
                Console.Write("Opção:");

                string? op = Console.ReadLine();

                switch (op)
                {
                    case "1":
                        employee.AddEmployee();
                        break;
                    case "2":
                        employee.GetEmployeeDetails();
                        break;
                    case "3":
                        employee.UpdateSalary();
                        break;
                    case "4":
                        employee.UpdateDepartament();
                        break;
                    case "5":
                        employee.UpdateJobRole();
                        break;
                    case "6":
                        employee.UpdateEmployeeDetails();
                        break;
                    case "0":
                        Console.WriteLine("Voltando...");
                        return;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;

                }
            }
        }

        static void MenuPessoa()
        {
            Person person = new Person();

            while (true)
            {
                Console.WriteLine("\n=== MENU PESSOA ===");
                Console.WriteLine("1 - Adicionar nova pessoa.");
                Console.WriteLine("2 - Ver nome completo");
                Console.WriteLine("3 - Ver meios de contacto.");
                Console.WriteLine("4 - Adicionar endereço.");
                Console.WriteLine("5 - Ver endereço.");
                Console.WriteLine("0 - Voltar");
                Console.Write("Opção:");

                string? op = Console.ReadLine();

                switch (op)
                {
                    case "1":
                        person.SetNewPerson();
                        break;
                    case "2":
                        Console.WriteLine($"{person.GetFullName()}");
                        break;
                    case "3":
                        person.GetContacts();
                        break;
                    case "4":
                        person.Address.SetAddress();
                        break;
                    case "5":
                        person.GetAddress();
                        break;
                    case "0":
                        Console.WriteLine("Voltando...");
                        return;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }
        static void MenuFornecedor()
        {
            Provider provider = new Provider();

            while (true)
            {
                Console.WriteLine("\n=== MENU FORNECEDOR ===");
                Console.WriteLine("1 - Adicionar Fornecedor.");
                Console.WriteLine("2 - Ver detalhes do fornecedor");
                Console.WriteLine("3 - Alterar contato do fornecedor");
                Console.WriteLine("0 - Voltar");
                Console.Write("Opção:");
                string? op = Console.ReadLine();

                switch (op)
                {
                    case "1":
                        provider.SetNewPerson();
                        provider.AddProviderContactPerson();

                        break;
                    case "2":
                        provider.GetProviderDetails();
                        break;
                    case "3":
                        provider.UptadeProviderContactPerson();
                        break;
                    case "0":
                        Console.WriteLine("Voltando...");
                        return;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;

                }
            }
        }

    }
}