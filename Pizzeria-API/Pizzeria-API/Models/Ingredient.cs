using System;

namespace Pizzeria_API.Models
{
    public class Ingredient : IProduct
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}