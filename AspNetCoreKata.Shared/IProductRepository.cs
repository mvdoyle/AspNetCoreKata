﻿using System;
using System.Collections.Generic;

namespace AspNetCoreKata.Shared
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
    }
}
