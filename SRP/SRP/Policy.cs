using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class Policy
    {
        public string Make { get; set; }
        public int Deductible { get; set; }
        public PolicyType Type { get; set; }
        public int BondAmount { get; set; }
        public int Valuation { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Amount { get; set; }
        public bool IsSmoker { get; set; }
    }
}
