﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Coding_SKU.Models
{
    public interface InterfaceSKU
    {
        int GetPriceByType(ProductDetails product);
        int GetTotal(List<ProductDetails> products);
    }
}
