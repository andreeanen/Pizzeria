﻿using Pizzeria_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzeria_API.Data.Factory
{
    public abstract class ProductFactory
    {
        public abstract Product GetProduct();
    }
}