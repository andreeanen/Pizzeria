using Microsoft.AspNetCore.Mvc;
using Pizzeria_API.Data;
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

        public OrdersController()
        {
            Orders = Orders.GetOrders();
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
        public void Post([FromBody] string value)
        {
        }

        // PUT api/orders/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }
    }
}
