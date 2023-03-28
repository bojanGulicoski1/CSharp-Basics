using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5_Task2.Classes
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set;}
        public string Password { get; set;}
        public List<string> Messages { get; set; } = new List<string>();
  
    public User()
    {
        Id  = GenerateSSN();
    }


    private int GenerateSSN()
    {
        return new Random().Next(100000, 999999);
    }
    }
}
