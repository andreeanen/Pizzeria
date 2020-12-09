using Pizzeria_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzeria_API.Data.Factory
{
    public abstract class ProductFactory
    {
        public Product GetProduct(string name)
		{
			var product = CreateProduct(name);
			return product;
		}

		protected abstract Product CreateProduct(string name);
	}
}
