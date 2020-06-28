using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Coding_SKU.Models;
using Xunit;

namespace SKU_UnitTest
{
    public class UnitTest1
    {
        [Fact]
        public async Task TestSKU1()
        {
            //Arrange

            InterfaceSKU sku = new SKU();

           // We will basically test the service layer by mocking objects from out test class
           var products = new List<ProductDetails>();

           ProductDetails productA =  new ProductDetails();
           productA.ProductType = "A";
           productA.ProductPrice = 50;
           productA.ProductQuantity = 1;
           products.Add(productA);

            ProductDetails productB = new ProductDetails();
           productB.ProductType = "B";
           productB.ProductPrice = 30;
           productB.ProductQuantity = 1;
           products.Add(productB);

            ProductDetails productC = new ProductDetails();
           productC.ProductType = "B";
           productC.ProductPrice = 20;
           productC.ProductQuantity = 1;
           products.Add(productC);

           int total = 100;

           // ACT

           var response = sku.GetTotal(products);

           // ASSERT 

           Assert.True(response == total);
            

        }
    }
}
