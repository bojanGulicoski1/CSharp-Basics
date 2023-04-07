using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.CLasses
{
    public class Manager : Employee
    {
        private double _Bonus { get; set; } 
        public Manager(string firstName, string lastName, double salary)  
        {
            FirstName = firstName;  
            LastName = lastName;
            Salary = salary;
            Role = RoleEnum.Manager;
        }
        public void AddBonus(double bonus)
        {
            _Bonus = bonus;
        }

        public override double GetSalary()
        {
            return Salary + _Bonus;
        }

    }
}
