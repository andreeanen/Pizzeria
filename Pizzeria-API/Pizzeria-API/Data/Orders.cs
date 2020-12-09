using Pizzeria_API.Models;
using System.Collections.Generic;

namespace Pizzeria_API.Data
{
    public class Orders
    {
        private static Orders _instance;

        public Queue<Order> Queue { get; set; }

        private Orders() 
        {
            Queue = new Queue<Order>();
        }

        public static Orders GetOrders()
        {
            if (_instance is null)
            {
                _instance = new Orders();
                // dummy
                _instance.Queue.Enqueue(new Order());
                _instance.Queue.Enqueue(new Order());
                _instance.Queue.Enqueue(new Order());
            }

            return _instance;
        }
    }
}
