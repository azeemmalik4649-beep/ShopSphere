using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopSphere.Models;

namespace ShopSphere.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetProducts()
        {
            var products = new List<Product>
        {
            new Product
            {
                Id = 1,
                Name = "Laptop",
                Price = 150000,
                StockQuantity = 10
            },
            new Product
            {
                Id = 2,
                Name = "Keyboard",
                Price = 5000,
                StockQuantity = 25
            },
            new Product
            {
                Id = 3,
                Name = "Mouse",
                Price = 2500,
                StockQuantity = 40
            }
        };

            return Ok(products);
        }

        [HttpGet("{id}")]
        public IActionResult GetProductById(int id)
        {
            var products = new List<Product>
        {
            new Product
            {
                Id = 1,
                Name = "Laptop",
                Price = 150000,
                StockQuantity = 10
            },
            new Product
            {
                Id = 2,
                Name = "Keyboard",
                Price = 5000,
                StockQuantity = 25
            },
            new Product
            {
                Id = 3,
                Name = "Mouse",
                Price = 2500,
                StockQuantity = 40
            }
        };
            var product = products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(products);
        }

    }
      

}
