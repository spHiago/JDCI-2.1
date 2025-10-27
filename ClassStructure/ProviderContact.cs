using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStructure
{
    public class ProviderContact : Person
    {
        public string JobTitle { get; set; }

        public void AddProviderContactPerson()
        {
            SetNewPerson();
            Console.WriteLine("Enter Job Title:");
            JobTitle = Console.ReadLine();
        }

        public void UpdateProviderContactPerson()
        {
            Console.WriteLine("Updating provider contact person...");
            SetNewPerson();
        }
    }
}
