﻿using Pizzeria_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzeria_API.Data.Factory
{
    public class SodaFactory : ItemFactory<Soda>
    {
        protected override Soda CreateItem(string name)
        {
            switch (name)
            {
                case (nameof(Fanta)):
                    {
                        return new Fanta();
                    }
                case (nameof(CocaCola)):
                    {
                        return new CocaCola();
                    }
                case (nameof(Sprite)):
                    {
                        return new Sprite();
                    }
                default:
                    {
                        return null;
                    }
            }
        }
    }

    public class Fanta : Soda
    {
        public Fanta()
        {
            Id = new Guid();
            Name = "Fanta";
            Price = 20;
        }
    }
    public class CocaCola : Soda
    {
        public CocaCola()
        {
            Id = new Guid();
            Name = "Coca Cola";
            Price = 20;
        }
    }
    public class Sprite : Soda
    {
        public Sprite()
        {
            Id = new Guid();
            Name = "Sprite";
            Price = 25;
        }
    }

}
