using System;
using System.Globalization;
using System.Collections.Generic;

namespace Exercício_Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> id = new List<int>();
            List<string> name = new List<string>();
            List<double>  salary = new List<double>();


            Console.Write("How many employes will be registred? ");
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine("Employee #" + i + ":");
                Console.Write("Id: ");
                id.Add(int.Parse(Console.ReadLine()));
                Console.Write("Name: ");
                name.Add(Console.ReadLine());
                Console.Write("Salary: ");
                salary.Add(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have a rise: ");
            int idRise = int.Parse(Console.ReadLine());
            Console.Write("Enter the percentage: ");
            double percentageRise = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            int pos1 = id.FindIndex(x => x == idRise);
            double newSalary = salary[pos1] * (1 + percentageRise/100);
            salary.RemoveAt(pos1);
            salary.Insert(pos1, newSalary);

            Console.WriteLine("Updated list of employees: ");

            for (int i =0; i<N; i++)
            {
                Console.WriteLine(id[i] + ", " + name[i] + ", " + salary[i].ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
