namespace ClassStructure
{
    public class Address
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string Street2 { get; set; }
        public string DoorNumber { get; set; }
        public string Floor { get; set; }
        public string PostalCode { get; set; }
        public string Locale { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public string GetAddress()
        {
            return $"{Street}, {Street2}, {DoorNumber}, {Floor}, {PostalCode}, {Locale}, {City}, {Country}";
        }

        public void SetAddress()
        {
            Console.WriteLine("Enter Street:");
            Street = Console.ReadLine();

            Console.WriteLine("Enter Door Number:");
            DoorNumber = Console.ReadLine();

            Console.WriteLine("Enter Postal Code:");
            PostalCode = Console.ReadLine();

            Console.WriteLine("Enter City:");
            City = Console.ReadLine();

            Console.WriteLine("Enter Country:");
            Country = Console.ReadLine();
        }
    }
}
