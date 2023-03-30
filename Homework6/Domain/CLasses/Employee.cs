using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.CLasses
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        protected double Salary { get; set; }
        public  RoleEnum Role { get; set; }

        public string PrintInfo()
        {
            return $"{FirstName} {LastName} {Salary}";
        }

        public virtual double GetSalary()
        {
            return Salary;
        }
     }
}
