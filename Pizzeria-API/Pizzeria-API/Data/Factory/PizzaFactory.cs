using Pizzeria_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzeria_API.Data.Factory
{
     class PizzaFactory : ProductFactory
    {
        private string _name;
        private double _price;
        private List<Ingredient> _ingredients;

        public PizzaFactory(string name, double price, List<Ingredient> ingredients)
        {
            _name = name;
            _price = price;
            _ingredients = ingredients;
        }

        public override Product GetProduct()
        {
            return new Pizza(_name, _price, _ingredients);
        }
    }
}
