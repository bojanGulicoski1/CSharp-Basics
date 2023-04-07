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
        public int MontlyVague { get; set; }
        private double _ssn { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public EnumOcupation EnumOcupation { get; set; }
        public EnumEducation EnumEducation { get; set; }
        public EnumBankProducts enumBankProducts { get; set; }
        public List<string> ProductsInBank { get; set; } = new List<string>();
       
     
        public bool hasDeposit { get; set; }
        public Person()
        {
            _ssn = GenerateSsn();
        }

        public Person(int montlyVague , int age)
        {
            _ssn = GenerateSsn();
            Age = age;

            if (Age <= 18)
                EnumOcupation = EnumOcupation.Student;
            else if (Age > 64)
                EnumOcupation = EnumOcupation.Retired;
        }

        public Person(string firstName, string lastName, int age, string mobile, string adress)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            _ssn = GenerateSsn();
            Mobile = mobile;
            Adress = adress;


        }
        public bool CheekAge()
        {
            if (Age < 16)
            {
                Console.WriteLine("Not alowed.Your under 16");
                return false;
            }
            Console.WriteLine(EnumOcupation);
            return true;
        }

        public bool IsLoanCandidate()
        {
            if (MontlyVague > 18000 && Age > 25 && Age < 60 && hasDeposit == false)
            {

                Console.WriteLine("You are alowed to take deposit");
                return true;
            }
            Console.WriteLine("You are not alowed to take deposit");
            return false;
        }



        public double GenerateSsn()
        {
            return new Random().Next(1000, 9999);
        }


    }

}
