using Pizzeria_API.Data.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzeria_API.Models
{
    class Pizza : Product
    {
        private Guid _id;
        private string _name;
        private double _price;
        private List<ProductFactory> _ingredients = new List<ProductFactory>();

        public Pizza(string name, double price, List<ProductFactory> ingredients)
        {

            _id = new Guid();
            _name = name;
            _price = price;
            _ingredients = ingredients; // instantiate maybe 
        }

        public override string Name
        {
            get { return _name; }
        }
        public override Guid Id
        {
            get { return _id; }
        }

        public override double Price
        {
            get { return _price; }
        }
        public List<ProductFactory> Ingredients
        {
            get { return _ingredients; }
        }

    }
}
