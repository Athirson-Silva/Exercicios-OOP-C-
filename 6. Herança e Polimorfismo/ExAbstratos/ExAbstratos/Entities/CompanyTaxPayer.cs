using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExAbstratos.Entities
{
    internal class CompanyTaxPayer : TaxPayers
    {
        public int QuantityEmployees { get; set; }

        public CompanyTaxPayer(string name, double anualIncome, int quantityEmployees)
            : base (name, anualIncome)
        {
            QuantityEmployees = quantityEmployees;
        }

        public override double TaxCalc()
        {
            double taxPercentage = 0.16;
            if (QuantityEmployees > 10)
            {
                taxPercentage = 0.14;
            }
            return AnualIncome * taxPercentage;
        }
    }
}
