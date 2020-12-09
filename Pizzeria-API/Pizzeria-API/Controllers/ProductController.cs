using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Pizzeria_API.Data;
using Pizzeria_API.Data.Factory;
using Pizzeria_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Pizzeria_API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private Database _database;
        private Menu _menu;

        public ProductController()
        {
            _database = new Database();
            _menu = _database.InitializeMenu();
        }

        //// GET: api/<ProductController>
        [HttpGet]
        public IActionResult Get()
        {
            var products = _menu;
            if (products == null)
            {
                return NotFound();
            }
          
            return Ok(products);

        }
       
        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProductController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
