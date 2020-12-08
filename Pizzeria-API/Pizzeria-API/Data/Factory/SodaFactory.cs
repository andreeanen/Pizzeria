using Pizzeria_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzeria_API.Data.Factory
{
     class SodaFactory: ProductFactory
    {
        private string _name;
        private double _price;

        public SodaFactory(string name, double price)
        {
            _name = name;
            _price = price;
        }

        public override Product GetProduct()
        {
            return new Soda(_name, _price);
        }
    }
}
