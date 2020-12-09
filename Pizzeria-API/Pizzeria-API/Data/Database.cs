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
    }
}
