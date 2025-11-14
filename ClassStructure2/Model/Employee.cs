using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStructure2.Model
{
    public class Employee : Person
    {
        public string? JobDescription { get; set; }
        public double? Salary { get; set; }
        public string? Department { get; set; }
        public string? NIF { get; set; }
        public string? NIB { get; set; }
        public int Age { get; set; }
        public DateTime BirthDate { get; set; }
        public string? EmergencyContactName { get; set; }
        public string? EmergencyContactPhoneNumber { get; set; }

       public void AddEmployee()
        {
            Console.WriteLine("\n--- Adicionar Novo Funcionário ---");
            Console.Write("Digite o Id da pessoa:");
            Id = int.Parse(Console.ReadLine());
            Console.Write("Digite o primeiro nome:");
            FirstName = Console.ReadLine();
            Console.Write("Digite o ultimo nome:");
            LastName = Console.ReadLine();
            Console.Write("Digite o numero de telefone:");
            PhoneNumber = Console.ReadLine();
            Console.Write("Digite o email:");
            Email = Console.ReadLine();
            Console.Write("Digite a descrição do cargo:");
            JobDescription = Console.ReadLine();
            Console.Write("Digite o salário:");
            Salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o departamento:");
            Department = Console.ReadLine();
            Console.Write("Digite o NIF:");
            NIF = Console.ReadLine();
            Console.Write("Digite o NIB:");
            NIB = Console.ReadLine();
            Console.Write("Digite a idade:");
            Age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite a data de nascimento:");
            BirthDate = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Digite o nome de contato de emergencia:");
            EmergencyContactName = Console.ReadLine();
            Console.Write("Digite o numero de telefone do contato de em emergencia:");
            EmergencyContactPhoneNumber = Console.ReadLine();
            Console.Write("Pronto, funcionario criado.");
            Console.WriteLine("----------------------------");
        }

        public void GetEmployeeDetails()
        {
            Console.WriteLine("\n--- Detalhes do Funcionário ---");
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Nome Completo: {GetFullName()}");
            Console.WriteLine($"Telefone: {PhoneNumber}");
            Console.WriteLine($"E-mail: {Email}");
            Console.WriteLine($"Cargo: {JobDescription}");
            Console.WriteLine($"Salário: {Salary}");
            Console.WriteLine($"Departamento: {Department}");
            Console.WriteLine($"NIF: {NIF}");
            Console.WriteLine($"NIB: {NIB}");
            Console.WriteLine($"Idade: {Age}");
            Console.WriteLine($"Data de Nascimento: {BirthDate:dd/MM/yyyy}");
            Console.WriteLine($"Contato de Emergência: {EmergencyContactName}");
            Console.WriteLine($"Telefone do Contato de Emergência: {EmergencyContactPhoneNumber}");
            Console.WriteLine("-------------------------------\n");
        }

        public void UpdateSalary()
        {
            Console.WriteLine($"Salário atual: {Salary}.");
            Console.WriteLine("Adicione novo salário:");
            Salary = Convert.ToDouble(Console.ReadLine());
        }
        public void UpdateDepartament()
        {
            Console.WriteLine($"Departamento atual: {Department}");
            Console.WriteLine("Digite o novo departamento:");
            Department = Console.ReadLine();
        }
        public void UpdateJobRole()
        {
            Console.WriteLine($"Descrição de trabalho atual: {JobDescription}.");
            Console.WriteLine("Digite a nova descrição de trabalho:");
            JobDescription = Console.ReadLine();
        }
        public void UpdateEmployeeDetails()
        {
            Console.Write("\n--- Alterar dados do funcionário ---\"");
            Console.Write("Digite o Id da pessoa:");
            Id = int.Parse(Console.ReadLine());
            Console.Write("Digite o primeiro nome:");
            FirstName = Console.ReadLine();
            Console.Write("Digite o ultimo nome:");
            LastName = Console.ReadLine();
            Console.Write("Digite o numero de telefone:");
            PhoneNumber = Console.ReadLine();
            Console.Write("Digite o email:");
            Email = Console.ReadLine();
            Console.Write("Digite a descrição do cargo:");
            JobDescription = Console.ReadLine();
            Console.Write("Digite o salário:");
            Salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o departamento:");
            Department = Console.ReadLine();
            Console.Write("Digite o NIF:");
            NIF = Console.ReadLine();
            Console.Write("Digite o NIB:");
            NIB = Console.ReadLine();
            Console.Write("Digite a idade:");
            Age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite a data de nascimento:");
            BirthDate = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Digite o nome de contato de emergencia:");
            EmergencyContactName = Console.ReadLine();
            Console.Write("Digite o numero de telefone do contato de em emergencia:");
            EmergencyContactPhoneNumber = Console.ReadLine();
            Console.Write("Pronto, dados alterados.");
            Console.Write("----------------------------");
        }
    }
}
