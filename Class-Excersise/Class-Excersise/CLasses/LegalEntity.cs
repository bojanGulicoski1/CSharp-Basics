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
        public string Name { get; set; }
        private int TaxNumber { get; set; }
        public EnumActivityCompany ActivityCompany { get; set; }
        public int NumOfEmployee { get; set; }
        public List<string> Owner { get; set; } = new List<string>();
        private int Profit { get; set; }

        public int generateTax()
        {
            return new Random().Next(100, 999);
        }
    }
}
