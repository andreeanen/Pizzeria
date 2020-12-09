using Microsoft.AspNetCore.Mvc;
using Pizzeria_API.Data;
using Pizzeria_API.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Pizzeria_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public Menu Menu { get; set; }

        public ProductController()
        {
            Menu = Menu.GetMenu();
        }

        //// GET: api/<ProductController>
        [HttpGet]
        public IActionResult Get()
        {
            var products = Menu;
            if (products == null)
            {
                return NotFound();
            }
          
            return Ok(products);
        }
    }
}
