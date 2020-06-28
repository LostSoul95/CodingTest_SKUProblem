using System;
using System.Collections.Generic;
using Coding_SKU.Models;

namespace Coding_SKU
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of Interface
            InterfaceSKU SKU = new SKU();

            List<ProductDetails> products = new List<ProductDetails>();

            Console.WriteLine("total number of items in the order");
            int a = Convert.ToInt32(Console.ReadLine());
            while (a > 0)
            {

                Console.WriteLine("enter the type of product:A,B,C or D");
                string type = Console.ReadLine();
                Console.WriteLine("enter the quantity of the product type");
                int count = Convert.ToInt32(Console.ReadLine());
                ProductDetails product =  new ProductDetails();
                product.ProductType = type;
                product.ProductQuantity = count;
                product.ProductPrice = SKU.GetPriceByType(product); 
                products.Add(product);
                a = a - count;
            }
            
            int totalPrice = SKU.GetTotal(products);
            Console.WriteLine(totalPrice);
            Console.ReadLine();
        }
    }
}
