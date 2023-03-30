using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.CLasses
{
    public class SalesPErson : Employee
    {
        private double SuccessSaleRevenue { get; set; }
        public SalesPErson(string firstName, string lastName)
        {
            Salary = 500;
            Role = RoleEnum.Sales;
            FirstName = firstName;
            LastName = lastName;
        }

        public void AddSuccessRevenue(double revenue)
        {
            revenue = SuccessSaleRevenue;
        }
        public override double GetSalary()
        {
            if (SuccessSaleRevenue <= 2000)
            {
                return Salary + 500;
            }
            else if (SuccessSaleRevenue > 2000 && SuccessSaleRevenue <= 5000)
            {
                return Salary + 1000;
            }
            else if (SuccessSaleRevenue > 5000)
            {
                return Salary + 1500;
            }
            else
            {
                return Salary;
            }
        }

    }
}
