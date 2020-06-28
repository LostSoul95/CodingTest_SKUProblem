using System;
using System.Threading.Tasks;
using Coding_SKU.Models;
using Xunit;

namespace SKU_UnitTest
{
    public class UnitTest1
    {
        [Fact]
        public async Task TestSKU()
        {
           // We will basically test the service layer by mocking objects from out test class

           ProductDetails product =  new ProductDetails();
           product.ProductType = "A";
           product.ProductPrice = "50";

        }
    }
}
