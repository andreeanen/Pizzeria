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
        public List<ProductFactory> Menu {get;set;}
               
        public List<ProductFactory> InitializeMenu()
        {
            ProductFactory ham = new IngredientFactory("ham", 10);
            ProductFactory pineapple = new IngredientFactory("pineapple", 10);
            ProductFactory mushrooms = new IngredientFactory("mushrooms", 10);
            ProductFactory onion = new IngredientFactory("onion", 10);
            ProductFactory kebabSauce = new IngredientFactory("kebab sauce", 10);
            ProductFactory shrimps = new IngredientFactory("shrimps", 15);
            ProductFactory mussels = new IngredientFactory("mussels", 15);
            ProductFactory artichoke = new IngredientFactory("artichoke", 15);
            ProductFactory kebab = new IngredientFactory("kebab", 20);
            ProductFactory coriander = new IngredientFactory("corainder", 20);
            ProductFactory cheese = new IngredientFactory("cheese", 0);
            ProductFactory tomatoSauce = new IngredientFactory("tomato sauce", 0);
            ProductFactory feferoni = new IngredientFactory("feferoni", 0);
            ProductFactory icebergSalad = new IngredientFactory("iceberd salad", 0);
            ProductFactory tomatoKebabSauce = new IngredientFactory("tomato kebab sauce", 0);

            ProductFactory margerita = new PizzaFactory
                ("Margerita",
                  85,
                 new List<ProductFactory>(){cheese, tomatoSauce}
                );
            ProductFactory hawaii = new PizzaFactory
                ("Hawaii",
                95,
                new List<ProductFactory>(){cheese, tomatoSauce, ham, pineapple}
                );
            ProductFactory kebabPizza = new PizzaFactory
                ("Kebabpizza",
                105,
                new List<ProductFactory>() {cheese,tomatoSauce,kebab,mushrooms,onion,feferoni,icebergSalad, tomatoKebabSauce}
                );
            ProductFactory quatroStagioni = new PizzaFactory
                ("Quatro Stagioni",
                105,
                new List<ProductFactory>() {cheese,tomatoSauce,ham,shrimps,mussels,mushrooms,artichoke}
                );

            ProductFactory cocaCola = new SodaFactory("Coca cola", 20);
            ProductFactory fanta = new SodaFactory("Fanta", 20);
            ProductFactory sprite = new SodaFactory("Sprite", 20);

            Menu = new List<ProductFactory>();
            Menu.Add(ham);
            Menu.Add(pineapple);
            Menu.Add(mushrooms);
            Menu.Add(onion);
            Menu.Add(kebab); 
            Menu.Add(shrimps);
            Menu.Add(mussels);
            Menu.Add(artichoke);
            Menu.Add(kebabSauce);
            Menu.Add(coriander);
            Menu.Add(cheese);
            Menu.Add(tomatoSauce);
            Menu.Add(feferoni);
            Menu.Add(icebergSalad);
            Menu.Add(tomatoKebabSauce);
            Menu.Add(margerita);
            Menu.Add(hawaii);
            Menu.Add(quatroStagioni);
            Menu.Add(kebabPizza);
            Menu.Add(cocaCola);
            Menu.Add(fanta);
            Menu.Add(sprite);

            return Menu;

            //Orders.Enqueue(new Order
            //{
            //    Id = new Guid(),
            //    TotalSum = 200,
            //    Status = Status.Submitted,
            //    Products = new List<ProductFactory>() {margerita,cocaCola,coriander }
            //}); 

        }
    }
}
