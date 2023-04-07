using Class_Excersise.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Excersise.CLasses
{
    public class LegalEntity : Client
    {
        private int _taxNumber { get; set; }
        private int _profit { get; set; }
        public string Name { get; set; }
        public EnumActivityCompany ActivityCompany { get; set; }
        public int NumOfEmployee { get; set; }
        public List<Person> Owners { get; set; } = new List<Person>();

        public int generateTax()
        {
            return new Random().Next(100, 999);
        }
        public bool CheckOwnerInBank(List<Person> personsInBank)
        {
            if (Owners.Count == 0)
            {
                Console.WriteLine("Company doesnt have any owner");
                return false;
            }

            var owner = Owners[0];
            var isPartOfBank = false;
            foreach (var person in personsInBank)
            {
                if (person.FirstName == owner.FirstName && person.LastName == owner.LastName)
                {
                    isPartOfBank = true;
                    break;
                }
            }

            if (isPartOfBank)
            {
                Console.WriteLine("Owner is part of the bank");
                return true;
            }
            else
            {
                Console.WriteLine("Owner is NOT part of the bank");
                return false;
            }
        }
    }
}

