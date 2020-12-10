using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Pizzeria_API.Controllers;
using Pizzeria_API.Data;
using Pizzeria_API.Data.Factory;
using Pizzeria_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzeria_API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //data only to calculate sum on order
            //Order order = new Order()
            //{
            //    Pizzas = new List<Product>() { new Margherita() },
            //    Sodas = new List<Soda>() { new CocaCola() },
            //    Ingredients = new List<Ingredient>() { new Shrimps() }
            //};
            //var sumCalculator = new OrderSumCalculator();
            //var total = sumCalculator.CalculateOrderSum(order);

            CreateHostBuilder(args).Build().Run();

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
