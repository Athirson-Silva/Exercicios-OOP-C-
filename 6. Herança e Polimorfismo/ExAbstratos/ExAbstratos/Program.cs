using System;
using System.Globalization;
using System.Collections.Generic;
using ExAbstratos.Entities;

namespace ExAbstratos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayers> list = new List<TaxPayers>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or company (i/c)?");
                string typeOfTaxPayer = Console.ReadLine();
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(typeOfTaxPayer == "i")
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new IndividualTaxPayer(name, anualIncome, healthExpenditures));
                }
                else if (typeOfTaxPayer == "c")
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    list.Add(new CompanyTaxPayer(name, anualIncome, numberOfEmployees));
                }
            }

            double sum = 0;
            Console.WriteLine("TAXES PAID: ");
            foreach(TaxPayers taxPayers in list)
            {
                Console.WriteLine($"{taxPayers.Name} $ {taxPayers.TaxCalc().ToString("F2", CultureInfo.InvariantCulture)}");
                sum += taxPayers.TaxCalc();
            }

            Console.WriteLine($"TOTAL TAXES: $ {sum.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
