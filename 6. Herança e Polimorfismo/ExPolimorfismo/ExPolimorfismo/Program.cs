using System;
using System.Globalization;
using System.Collections.Generic;
using ExPolimorfismo.Entities;

namespace ExPolimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int N = int.Parse(Console.ReadLine());

            for(int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Product #{i} data: ");
                Console.Write("Common, used or imported (c/u/i)? ");
                string productType = (Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                switch (productType)
                {
                    case "i":
                        Console.Write("Customs fee: ");
                        double customsFee = double.Parse((Console.ReadLine()), CultureInfo.InvariantCulture);
                        list.Add(new ImportedProduct(name, price, customsFee));

                        break;
                    case "u":
                        Console.Write("Manufacture date (DD/MM/YYYY): ");
                        DateTime date = DateTime.Parse(Console.ReadLine());
                        list.Add(new UsedProduct(name, price, date));

                        break;

                    default:
                        list.Add(new Product(name, price));
                        break;
                }
            }

            Console.WriteLine("\nPRICE TAGS: ");
            foreach(Product product in list)
            {
                Console.WriteLine(product.priceTag());
            }
        }
    }
}
