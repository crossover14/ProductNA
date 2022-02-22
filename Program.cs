using System;
using System.Collections.Generic;
using ProductNA.Entities;
using System.Globalization;

namespace ProductNA
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            Console.Write("Enter the number of product: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i}  data: ");
                
                Console.Write("Common, used or imported (c/u/i)?");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                if (ch == 'c')
                {
                    list.Add(new Product(name, price));
                }
                else if (ch == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime data = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, data));

                }
                else
                {
                    Console.Write("Customs fee: ");
                    double custom = double.Parse(Console.ReadLine());

                    list.Add(new ImportedProduct(name, price, custom));
                }

            }
            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");

            foreach (Product pro in list)
            {
                Console.WriteLine(pro.PriceTag());
            }


        }
    }
}
