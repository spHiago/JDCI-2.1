using System;

namespace ClassStructure
{
    internal class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public Address Address { get; set; }

        public string GetAddress()
        {
            return Address?.GetAddress() ?? "No address set.";
        }

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public string GetContacts()
        {
            return $"Email: {Email}, Phone: {PhoneNumber}";
        }

        public void SetNewPerson(int id, string firstName, string lastName, string phoneNumber, string email, Address address)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = email;
            Address = address;
        }

        public void Present()
        {
            Console.WriteLine($"Hello, my name is {GetFullName()}, and my number is {PhoneNumber}");
        }
    }
}
