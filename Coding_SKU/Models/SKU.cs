﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Coding_SKU.Models
{
    public class SKU:InterfaceSKU
    {
        public int GetPriceByType(ProductDetails product)
        {
            switch (product.ProductType)
            {
                case "A":
                    product.ProductPrice = 50;
                    

                    break;
                case "B":
                    product.ProductPrice = 30;
                 

                    break;
                case "C":
                    product.ProductPrice = 20;
                   

                    break;
                case "D":
                    product.ProductPrice = 15;
                   
                    break;
            }

            return product.ProductPrice;
        }

        private int GetTotalPriceForEachType(ProductDetails product)
        {
            int totalPriceForEachType=0;

            if (product.ProductType == "A")
            {
                totalPriceForEachType = (product.ProductQuantity / 3) * 130 +
                                        (product.ProductQuantity % 3 * product.ProductPrice);
            }
            if (product.ProductType == "B")
            {
                totalPriceForEachType = (product.ProductQuantity / 2) * 45 +
                                        (product.ProductQuantity % 2 * product.ProductPrice);
            }
            if (product.ProductType == "C")
            {
                totalPriceForEachType =  (product.ProductQuantity  * product.ProductPrice);
            }
            if (product.ProductType == "D")
            {
                totalPriceForEachType = (product.ProductQuantity * product.ProductPrice);
            }

          
            return totalPriceForEachType;
        }

        public int GetTotal(List<ProductDetails> products)
        {
            int total = 0;
            int totalC = 0;
            int totalD = 0;
            int totalE = 0; // We intentionally create E which is a combination of C & D
            int priceE = 30;
            
            // A and B rules are normal 
            // C and D we decipher the number of pairs and if one variable exceeds the other we compute the 
            // value for that
           
            foreach (var product in products)
            {
                if (product.ProductType == "A")
                {
                    total += GetTotalPriceForEachType(product);
                }
                if (product.ProductType == "B")
                {
                    total += GetTotalPriceForEachType(product);
                }

                if (product.ProductType == "C")
                {
                    totalC = product.ProductQuantity;
                }

                if (product.ProductType == "D")
                {
                    totalD = product.ProductQuantity;
                }

            }

            // If C and D are equal

            if (totalC > 0 &&  (totalC - totalD == 0 ))
            {
                totalE = totalC;
                total += totalE * priceE;
            }

            // If C exceeds D

            if (totalC - totalD > 0 )
            {
                totalE = totalD;
                total += totalE * priceE;
                totalC = totalC - totalD;
                
                // Define new element for C

                var Product = new ProductDetails();
                Product.ProductType = "C";
                Product.ProductQuantity = totalC;
                Product.ProductPrice = GetPriceByType(Product);
                total += GetTotalPriceForEachType(Product);

            }

            //IF D exceeds C

            if (totalD - totalC >0)
            {
                totalE = totalC;
                total += totalE * priceE;
                totalD = totalD - totalC;

                //Define new element for D

                var Product = new ProductDetails();
                Product.ProductType = "D";
                Product.ProductQuantity = totalD;
                Product.ProductPrice = GetPriceByType(Product);
                total += GetTotalPriceForEachType(Product);
            }

            return total;
        }
    }
}
