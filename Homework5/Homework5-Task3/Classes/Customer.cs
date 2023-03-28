using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5_Task3.Classes
{
    public class Customer
    {
        public string FullName { get; set; }
        public string Pin { get;set; }
        public string CardNumber { get; set; }  
        public int Balance { get; set; }
        public List<string> Customers { get; set; } = new List<string>();

        public void  CashWithdrawl(int cash)
        {
             Balance -= cash;
        }
        public void CashDeposition(int cash )
        {
             Balance += cash;
        }


    }
}
