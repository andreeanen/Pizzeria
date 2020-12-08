using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzeria_API.Models
{
    public abstract class Product
    {
        public abstract Guid Id { get; }
        public abstract string Name { get; }
        public abstract double Price { get;  }
    }
}
