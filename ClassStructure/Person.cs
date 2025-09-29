using System;

namespace ClassStructure
{
    internal class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; } 
        public string Adress { get; set; }

        public string GetAdress (string adress)
        {
            adress = Adress;
            return (adress);
        }
        public string GetFullName (string fullName)
        {
            fullName = FirstName + " " + LastName;
            return (fullName);
        }
        public string GetContact(string email, int phonenumber)
        {
            email = Email;
            phonenumber = PhoneNumber;
            return (email +  " " + phonenumber);
        }
        public void Apresent()
        {
            Console.WriteLine($"Hello, my name is {GetFullName}, and my number is {PhoneNumber}");
        }
    }
}
