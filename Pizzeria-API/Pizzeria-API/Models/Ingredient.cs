using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzeria_API.Models
{
    public class Ingredient
    {
        public Guid Id { get ; set ; }
        public string Name { get ; set ; }
        public double Price { get ; set ; }
    }
}
