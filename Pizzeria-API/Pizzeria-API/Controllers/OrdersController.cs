using Microsoft.AspNetCore.Mvc;
using Pizzeria_API.Data;
using Pizzeria_API.Data.Factory;
using Pizzeria_API.Models;
using System.Collections.Generic;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Pizzeria_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        public Orders Orders { get; set; }
        public Menu Menu { get; set; }

        public OrdersController()
        {
            Orders = Orders.GetOrders();
            Menu = Menu.GetMenu();
        }

        // GET: api/orders
        [HttpGet]
        public IActionResult Get()
        {
            if (Orders == null)
            {
                return NotFound();
            }
            return Ok(Orders.Queue);
        }

        // GET api/orders/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var order = Orders.Queue.Find(o => o.Id == id);
            if (order == null)
            {
                return NotFound();
            }
            return Ok(order);
        }

        // POST api/orders
        [HttpPost]
        public IActionResult Post([FromBody]string productName)
        {
            var order = new Order(); //{ Pizzas= new List<Product>(){ new Margherita()} };
            var pizza = Menu.Pizzas.Where(p => p.Name.ToLower() == productName.ToLower()).FirstOrDefault();
            var soda = Menu.Sodas.Where(s => s.Name.ToLower() == productName.ToLower()).FirstOrDefault();
            var ingredient = Menu.Ingredients.Where(i => i.Name.ToLower() == productName.ToLower()).FirstOrDefault();

            if (pizza == null && soda == null && ingredient == null)
            {
                return BadRequest("The product you are trying to order is not on the menu");
            }
            else
            {
                if (pizza!=null)
                {
                    order.Pizzas.Add(pizza);
                }
                if (soda != null)
                {
                    order.Sodas.Add(soda);
                }
               
                if(ingredient != null && order.Pizzas.Count==0)
                {
                    return BadRequest("You can not add the ingredient because you do not have a pizza on your order");
                }
                else
                {
                    order.Ingredients.Add(ingredient);
                }
                return Ok(order);
            }
                        
        }

        //// POST api/orders
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        // PUT api/orders/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }
    }
}
