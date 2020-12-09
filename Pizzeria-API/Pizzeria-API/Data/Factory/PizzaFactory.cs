using Pizzeria_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzeria_API.Data.Factory
{
     class PizzaFactory : ProductFactory
     {
       
        protected override Product CreateProduct(string name)
        {
			switch (name)
			{
				case (nameof(Margherita)):
					{
                        return new Margherita();
					}
				case (nameof(Hawaii)):
					{
                        return new Hawaii();
					}
                case (nameof(Kebabpizza)):
                    {
                        return new Kebabpizza();
                    }
                case (nameof(QuatroStagioni)):
                    {
                        return new QuatroStagioni();
                    }
                default:
                    {
						return null;
                    }
			}
		}
     }

    public class Margherita : Product
    {        
        public Margherita()
        {
            Id = new Guid();
            Name = "Margherita";
            Price = 85;
            Ingredients = new List<Ingredient>() 
            { 
                new Ingredient{Id= new Guid(),Name ="cheese", Price=0},
                new Ingredient{Id= new Guid(),Name ="tomato sauce", Price=0}
            };
        }
    }
    public class Hawaii : Product
    {
        public Hawaii()
        {
            Id = new Guid();
            Name = "Hawaii";
            Price = 95;
            Ingredients = new List<Ingredient>()
            {
                new Ingredient{Id= new Guid(),Name ="cheese"},
                new Ingredient{Id= new Guid(),Name ="tomato sauce"},
                new Ingredient{Id= new Guid(),Name ="ham"},
                new Ingredient{Id= new Guid(),Name ="pineapple"}
            };
        }
    }
    public class Kebabpizza : Product
    {
        public Kebabpizza()
        {
            Id = new Guid();
            Name = "Kebabpizza";
            Price = 105;
            Ingredients = new List<Ingredient>()
            {
                new Ingredient{Id= new Guid(),Name ="cheese"},
                new Ingredient{Id= new Guid(),Name ="tomato sauce"},
                new Ingredient{Id= new Guid(),Name ="kebab"},
                new Ingredient{Id= new Guid(),Name ="mushrooms"},
                new Ingredient{Id= new Guid(),Name ="onion"},
                new Ingredient{Id= new Guid(),Name ="iceberg salad"},
                new Ingredient{Id= new Guid(),Name ="tomato kebab sauce"}
            };
        }
    }
    public class QuatroStagioni : Product
    {
        public QuatroStagioni()
        {
            Id = new Guid();
            Name = "Quatro Stagioni";
            Price = 115;
            Ingredients = new List<Ingredient>()
            {
                new Ingredient{Id= new Guid(),Name ="cheese"},
                new Ingredient{Id= new Guid(),Name ="tomato sauce"},
                new Ingredient{Id= new Guid(),Name ="ham"},
                new Ingredient{Id= new Guid(),Name ="shrimps"},
                new Ingredient{Id= new Guid(),Name ="mussels"},
                new Ingredient{Id= new Guid(),Name ="mushrooms"},
                new Ingredient{Id= new Guid(),Name ="artichoke"}
            };
        }
    }
}
