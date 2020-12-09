using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzeria_API.Models
{
    public class Menu
    {
        public List<Product> Pizzas { get; set; }
        public List<Soda> Sodas { get; set; }
        public List<Ingredient> Ingredients { get; set; }
    }
}
