using Pizzeria_API.Data.Factory;
using Pizzeria_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzeria_API.Data
{
    public class Database
    {
        public Queue<Order> Orders { get; set; }
                      
        public Menu InitializeMenu()
        {
            ProductFactory pizzaFactory = new PizzaFactory();
            ItemFactory<Soda> sodaFactory = new SodaFactory();
            ItemFactory<Ingredient> ingredientFactory = new IngredientFactory();

            Menu menu = new Menu()
            {
                Pizzas = new List<Product>
                {
                    pizzaFactory.GetProduct(nameof(Margherita)),
                    pizzaFactory.GetProduct(nameof(Hawaii)),
                    pizzaFactory.GetProduct(nameof(Kebabpizza)),
                    pizzaFactory.GetProduct(nameof(QuatroStagioni))
                },
                Sodas = new List<Soda>
                {
                    sodaFactory.GetItem(nameof(Fanta)),
                    sodaFactory.GetItem(nameof(CocaCola)),
                    sodaFactory.GetItem(nameof(Sprite))
                },
                Ingredients = new List<Ingredient>
                {
                    ingredientFactory.GetItem(nameof(Ham)),
                    ingredientFactory.GetItem(nameof(Pineapple)),
                    ingredientFactory.GetItem(nameof(Mushrooms)),
                    ingredientFactory.GetItem(nameof(Onion)),
                    ingredientFactory.GetItem(nameof(KebabSauce)),
                    ingredientFactory.GetItem(nameof(Shrimps)),
                    ingredientFactory.GetItem(nameof(Mussels)),
                    ingredientFactory.GetItem(nameof(Artichoke)),
                    ingredientFactory.GetItem(nameof(Kebab)),
                    ingredientFactory.GetItem(nameof(Coriander)),
                }
            };
            return menu;
        }
    }
}
