using System;
using System.Linq;
using System.Collections.Generic;

namespace SalesReport
{
    class Program
    {
        static void Main(string[] args)
        {
            int numSales = int.Parse(Console.ReadLine());

            SortedDictionary <string,List<Sale>> sales = new SortedDictionary <string,List<Sale>>();

            for (int i = 0; i < numSales; i++)
            {
                var sale = ReadSale();

                if (!sales.ContainsKey(sale.Town))
                {
                    sales[sale.Town] = new List<Sale>();
                }

                sales[sale.Town].Add(sale);

            }

            foreach (var salesByTown in sales)
            {
                string town = salesByTown.Key;
                var sumOfSales = salesByTown.Value.Sum(s => s.Price*(decimal)s.Quantity);

                Console.WriteLine($"{town} -> {sumOfSales} ");
            }
        }

        private static Sale ReadSale()
        {
            var input = Console.ReadLine().Split(' ');

            return new Sale
            {
            Town = input[0],
            Product = input[1],
            Price = decimal.Parse(input[2]),
            Quantity = double.Parse(input[3])
            };
        }
    }
}
