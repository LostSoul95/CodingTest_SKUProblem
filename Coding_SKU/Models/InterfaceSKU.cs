using System;
using System.Collections.Generic;
using System.Text;

namespace Coding_SKU.Models
{
    public interface InterfaceSKU
    {
        void GetPriceByType(ProductDetails product);
        int GetTotalPrice(List<ProductDetails> products);
    }
}
