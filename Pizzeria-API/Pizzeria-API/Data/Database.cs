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
        public List<Product> Menu {get;set;}
               
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

            //ProductFactory sodaFactory = new SodaFactory();
            //ProductFactory ingredientsFactory = new IngredientFactory();

            //Pizza calzone = pizzaFactory.GetProduct("calzone");
            //Soda fanta = sodaFactory.GetProduct("fanta");
            ////Pizza hawaii = pizzaFactory.GetProduct("hawaii");



            //TODO. Skapa array med Ingredienser, ex new [new Ingredient{Id=1, Name="Skinka", Price=1}]

            //TODO. Skapa array med Pizzor, ex new [new Pizza{Id=1, Name="Hawaii", Price=10, Ingredients=new List<string>{"Skinka"}}]
            //TODO. Skapa array med Orders new [new Order { Pizza = Pizzas.Find(1), ExtraIngredients=Ingredienser.Find(1) }]




            //ProductFactory ham = new IngredientFactory("ham", 10);
            //ProductFactory pineapple = new IngredientFactory("pineapple", 10);
            //ProductFactory mushrooms = new IngredientFactory("mushrooms", 10);
            //ProductFactory onion = new IngredientFactory("onion", 10);
            //ProductFactory kebabSauce = new IngredientFactory("kebab sauce", 10);
            //ProductFactory shrimps = new IngredientFactory("shrimps", 15);
            //ProductFactory mussels = new IngredientFactory("mussels", 15);
            //ProductFactory artichoke = new IngredientFactory("artichoke", 15);
            //ProductFactory kebab = new IngredientFactory("kebab", 20);
            //ProductFactory coriander = new IngredientFactory("corainder", 20);

            //ProductFactory margerita = new PizzaFactory
            //    ("Margerita",
            //      85,
            //     new List<Ingredient>()
            //         {
            //             new Ingredient("cheese"), 
            //             new Ingredient("tomatoSauce")
            //         }
            //    );
            //ProductFactory hawaii = new PizzaFactory
            //    ("Hawaii",
            //    95,
            //    new List<Ingredient>(){
            //             new Ingredient("cheese"),
            //             new Ingredient("tomatoSauce"),
            //             new Ingredient("ham"),
            //             new Ingredient("pineapple")
            //         }
            //    );
            //ProductFactory kebabPizza = new PizzaFactory
            //    ("Kebabpizza",
            //    105,
            //    new List<Ingredient>() 
            //        {
            //         new Ingredient("cheese"),
            //         new Ingredient("tomatoSauce"),
            //         new Ingredient("kebab"),
            //         new Ingredient("mushrooms"),
            //         new Ingredient("onion"),
            //         new Ingredient("feferoni"),
            //         new Ingredient("icebergSalad"),
            //         new Ingredient("tomatoKebabSauce")
            //    }
            //    );
            //ProductFactory quatroStagioni = new PizzaFactory
            //    ("Quatro Stagioni",
            //    105,
            //    new List<Ingredient>() 
            //        {
            //        new Ingredient("cheese"),
            //        new Ingredient("tomatoSauce"),
            //        new Ingredient("ham"),
            //        new Ingredient("shrimps"),
            //        new Ingredient("mussels"),
            //        new Ingredient("mushrooms"),
            //        new Ingredient("artichoke")
            //        }
            //    );

            //ProductFactory cocaCola = new SodaFactory("Coca cola", 20);
            //ProductFactory fanta = new SodaFactory("Fanta", 20);
            //ProductFactory sprite = new SodaFactory("Sprite", 20);
            //Menu.Add(ham);
            //Menu.Add(pineapple);
            //Menu.Add(mushrooms);
            //Menu.Add(onion);
            //Menu.Add(kebab);
            //Menu.Add(shrimps);
            //Menu.Add(mussels);
            //Menu.Add(artichoke);
            //Menu.Add(kebabSauce);
            //Menu.Add(coriander);

            //Menu.Add(margerita);
            //Menu.Add(hawaii);
            //Menu.Add(quatroStagioni);
            //Menu.Add(kebabPizza);
            //Menu.Add(cocaCola);
            //Menu.Add(fanta);
            //Menu.Add(sprite);


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
