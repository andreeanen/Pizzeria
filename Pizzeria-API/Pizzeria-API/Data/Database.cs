using Pizzeria_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzeria_API.Data
{
    public class Database
    {
        Queue<Order> Orders = new Queue<Order>();
        List<Product> Products = new List<Product>();
    }
}
