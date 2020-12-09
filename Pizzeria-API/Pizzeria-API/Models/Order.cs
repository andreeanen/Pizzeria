using Pizzeria_API.Data.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzeria_API.Models
{
    public enum Status {Submitted, Delivered, Cancelled};

    public class Order
    {
        public Guid Id { get; set; }
        public Status Status { get; set; }
        public List<Product> Pizzas { get; set; }
        public List<Soda> Sodas { get; set; }
        public List<Ingredient> Ingredients { get; set; }

        public double GetTotalSum()
        {
            double pizzasSum = Pizzas.Select(p => p.Price).Sum();
            double sodasSum = Sodas.Select(s => s.Price).Sum();
            double ingredientsSum = Ingredients.Select(i => i.Price).Sum();

            return pizzasSum + sodasSum + ingredientsSum;
        }
    }
}

