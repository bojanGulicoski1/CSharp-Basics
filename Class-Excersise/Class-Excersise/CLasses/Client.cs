using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Excersise.CLasses
{
    public class Client
    {
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }

        public string EmailCheek(string email)
        {
            if (!email.Contains("@") && !email.Contains(".com"))
            {
                Console.WriteLine("Email must Contain $ and .com");
            }return email;
        }
        public string PhoneCheek(string number)
        {
            if (!number.StartsWith("07")){
                Console.WriteLine("Phone number must starts with 07");
            }
            return number;
        }
    }
}
