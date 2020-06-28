using System;
using System.Collections.Generic;
using Coding_SKU.Models;

namespace Coding_SKU
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ProductDetails> products = new List<ProductDetails>();

            Console.WriteLine("total number of order");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("enter the type of product:A,B,C or D");
                string type = Console.ReadLine();
                Product p = new Product(type);
                products.Add(p);
            }

            int totalPrice = GetTotalPrice(products);
            Console.WriteLine(totalPrice);
            Console.ReadLine();
        }
    }
}
