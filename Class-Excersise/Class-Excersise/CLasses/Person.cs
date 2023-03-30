using Class_Excersise.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Excersise.CLasses
{
    public class Person : Client
    {
        private double _ssn { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public EnumOcupation EnumOcupation { get; set; }
        public EnumEducation EnumEducation { get; set; }
        public EnumBankProducts enumBankProducts { get; set; }
        public int MontlyVague { get; set; }
        public List<string> ProductsInBank { get; set; } = new List<string>();
        public bool HasDepositProduct { get; set; }
        public bool aprovedCandidateForDeposit { get; set; }
        public bool hasDeposit { get; set; }
        public Person()
        {
            _ssn = GenerateSsn();
        }
        public Person(string firstName, string lastName, int age, int ssn)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            _ssn = GenerateSsn();
            Mobile = Mobile;
            Address = Address;
            State = State;
            Phone = Phone;
            Email = Email;
            EnumOcupation = EnumOcupation;
            enumBankProducts = enumBankProducts;
            MontlyVague = MontlyVague;

        }
        public void CheekAge(int age)
        {
            if (age < 16)
            {
                Console.WriteLine("Not alowed.Your under 18");
            }
            else if (age >= 16 && age <= 18)
            {
                Console.WriteLine($"{EnumOcupation.Student}");
            }
            else if (age > 64)
            {
                Console.WriteLine($"{EnumOcupation.Retired}");
            }

        }
        public void LoanCandidates(int mVage, int age, bool hasDeposit)
        {
            if (mVage > 18000 && age > 25 && age < 60 && hasDeposit == false)
            {
                aprovedCandidateForDeposit = true;
                Console.WriteLine("You are alowed to take deposit");
            }
            else
            {
                Console.WriteLine("You are not alowed to take deposit");
            }
        }

        //public EnumBankProducts GetEnumBankProducts()
        //{
        //    return enumBankProducts;
        //}

        public double GenerateSsn()
        {
            return new Random().Next(1000, 9999);
        }


    }

}
