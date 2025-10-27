using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassStructure
{
    public class Provider
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
        public string ContactPersonName { get; set; }
        public string ContactPersonJobTitle { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Sector { get; set; }

        public string GetProviderDetails()
        {
            return $"Provider: {Name}\nSector: {Sector}\nPhone: {PhoneNumber}\nContact: {ContactPersonName} ({ContactPersonJobTitle})";
        }
        public void AddProviderAddress()
        {
            Address = new Address();
            Address.SetAddress();
        }
    }
}
