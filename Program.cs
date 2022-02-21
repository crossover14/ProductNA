using System;
using ProductNA.Entities;

namespace ProductNA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of product: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i}  data: ");

            }
           
        }
    }
}
