using System;

namespace Pizzeria_API.Models
{
     class Ingredient : Product
    {
        private Guid _id;
        private string _name;
        private double _price;

        public Ingredient(string name, double price)
        {
            _id = new Guid();
            _name = name;
            _price = price;
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
    }
}