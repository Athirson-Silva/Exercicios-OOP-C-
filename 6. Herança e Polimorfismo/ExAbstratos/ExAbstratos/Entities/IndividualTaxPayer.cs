using System;
using System.Globalization;

namespace ExAbstratos.Entities
{
    internal class IndividualTaxPayer : TaxPayers
    {
        public double HealthExpenditures { get; set; }

        public IndividualTaxPayer(string name, double anualIncome, double healthExpenditures) 
            : base (name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double TaxCalc()
        {
            double taxPercentage = 0.15;
            if (AnualIncome >= 20000)
            {
                taxPercentage = 0.25;
            }
            if(HealthExpenditures > 0)
            {
                return AnualIncome * taxPercentage - (HealthExpenditures * 0.5);
            }
            return AnualIncome * taxPercentage;
        }
    }
}
