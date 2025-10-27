using System;
using System.Net;

namespace ClassStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            List<Client> clients = new List<Client>();
            List<Provider> providers = new List<Provider>();

            while (true)
            {
                Console.WriteLine("\n=== MENU ===");
                Console.WriteLine("1 - Add Employee");
                Console.WriteLine("2 - Add Client");
                Console.WriteLine("3 - Add Provider");
                Console.WriteLine("4 - Show Employees");
                Console.WriteLine("5 - Exit");

                Console.Write("Choose an option: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Employee emp = new Employee();
                        emp.AddEmployee();
                        employees.Add(emp);
                        break;

                    case "2":
                        Client cli = new Client();
                        cli.AddNewClient();
                        clients.Add(cli);
                        break;

                    case "3":
                        Provider prov = new Provider();
                        Console.WriteLine("Enter Provider Name:");
                        prov.Name = Console.ReadLine();
                        prov.AddProviderAddress();
                        providers.Add(prov);
                        break;

                    case "4":
                        foreach (var e in employees)
                            Console.WriteLine(e.GetFullName() + " - " + e.JobDescription);
                        break;

                    case "5":
                        return;

                    default:
                        Console.WriteLine("Invalid option!");
                        break;
                }
            }
        }
    }
}
