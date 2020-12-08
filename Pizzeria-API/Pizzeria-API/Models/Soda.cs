using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzeria_API.Models
{
    class Soda : Product
    {
        private Guid _id;
        private string _name;
        private double _price;

        public Soda(string name, double price)
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
