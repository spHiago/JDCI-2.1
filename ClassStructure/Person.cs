using System;

namespace ClassStructure
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public Address Address { get; set; } = new Address();

        public string GetFullName() => $"{FirstName} {LastName}";

        public string GetContacts() => $"Phone: {PhoneNumber}, Email: {Email}";

        public string GetAddress() => Address != null ? Address.GetAddress() : "No address defined.";

        public void SetNewPerson()
        {
            Console.WriteLine("Enter First Name:");
            FirstName = Console.ReadLine();

            Console.WriteLine("Enter Last Name:");
            LastName = Console.ReadLine();

            Console.WriteLine("Enter Phone Number:");
            PhoneNumber = Console.ReadLine();

            Console.WriteLine("Enter Email:");
            Email = Console.ReadLine();

            Address = new Address();
            Address.SetAddress();
        }
    }
}
