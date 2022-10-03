using System;
using System.Collections.Generic;
using exercicioHerançaPolimorfismo.Entities;

namespace exercicioHerançaPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<product> list = new List<product>();
            
            Console.WriteLine("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n ; i++)
            {
                Console.WriteLine("common, used or imported? (c/u/i)");
                char type = char.Parse(Console.ReadLine());
                Console.WriteLine("Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Price: ");
                double price = double.Parse(Console.ReadLine());
                if (type == 'i' || type == 'I')
                {
                    Console.WriteLine("Custom Feed: ");
                    double customFeed = double.Parse(Console.ReadLine());

                    list.Add(new ImportedProduct(name, price, customFeed));
                }
                else if (type == 'u' || type == 'U')
                {
                    Console.WriteLine("Manufature Date: ");
                    DateTime manufatureDate = DateTime.Parse(Console.ReadLine());

                    list.Add(new UsedProduct(name, price, manufatureDate));
                }
                else
                    list.Add(new product(name, price));
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS: ");
            foreach (product item in list)
            {
                Console.WriteLine(item.PriceTag());
            }
        }
    }
}
