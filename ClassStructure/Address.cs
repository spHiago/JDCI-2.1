namespace ClassStructure
{
    internal class Address
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

        public void SetAddress(int id, string street, string street2, string doorNumber, string floor,
                               string postalCode, string locale, string city, string country)
        {
            Id = id;
            Street = street;
            Street2 = street2;
            DoorNumber = doorNumber;
            Floor = floor;
            PostalCode = postalCode;
            Locale = locale;
            City = city;
            Country = country;
        }
    }
}
