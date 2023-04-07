using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Excersise.CLasses
{
    public class Client
    {
        public string Adress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }

        public bool EmailCheek()
        {
            if (!Email.Contains("@") && !Email.Contains(".com"))
            {
                Console.WriteLine("Email must Contain $ and .com");
                return false;
            }
            return true;
        }
        public bool PhoneCheek()
        {
            if (!Mobile.StartsWith("07"))
            {
                Console.WriteLine("Phone number must starts with 07");
                 return true;
            }
            return false;
        }
    }
}
