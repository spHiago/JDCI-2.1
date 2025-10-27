using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStructure
{
    public class Employee : Person
    {
        public string JobDescription { get; set; }
        public double Salary { get; set; }
        public string Departament { get; set; }
        public string NIF { get; set; }
        public string NIB { get; set; }
        public string Age { get; set; }
        public DateTime Birthday { get; set; }
        public string EmergencyContactName { get; set; }
        public string EmergencyContactPhone { get; set; }

        public void AddEmployee()
        {
            SetNewPerson();
            Console.WriteLine("Enter Job Description:");
            JobDescription = Console.ReadLine();

            Console.WriteLine("Enter Salary:");
            Salary = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Departament:");
            Departament = Console.ReadLine();
        }

        public void UptadeSalary(double newSalary) => Salary = newSalary;
        public void UpdateDepartament(string newDepartament) => Departament = newDepartament;
        public void UpdateJobRole(string newJob) => JobDescription = newJob;
        public void UpdateEmployeeDetails()
        {
            Console.WriteLine("Updating employee details...");
            SetNewPerson();
        }
    }
}