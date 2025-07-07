using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Market.Models;
using Market.Data;

namespace Market.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {

        private readonly MarketDbContext _context;

        public ProductController(MarketDbContext context)
        {
            _context = context;
        }

        //crud operations

        // create
        [HttpPost]
        public IActionResult CreateProduct([FromBody] Product product)
        {
            if (product == null)
                return BadRequest("Product Data Empty!");

            if (product.Price <= 0)
                return BadRequest("Invalid Price Input!");

            _context.Products.Add(product);
            _context.SaveChanges();

            return Ok(product);
        }

        // read by id
        [HttpGet("{id}")]
        public ActionResult<Product> GetProduct(int id)
        {
            var product = _context.Products.Find(id);
            if (product == null)
                return NotFound();
            else
                return Ok(product);
        }

        // read all products
        [HttpGet]
        public ActionResult<List<Product>> GetAllProducts()
        {
            var AllProducts = _context.Products.ToList();
            return Ok(AllProducts);
        }

        // update
        [HttpPut("{id}")]
        public IActionResult UpdateProduct(int id, [FromBody] Product newProduct)
        {
            var product = _context.Products.Find(id);

            if (product == null)
                return NotFound();
            else
            {
                product.Name = newProduct.Name;
                product.Price = newProduct.Price;

                _context.SaveChanges();
                return Ok(product);
            }

        }


        // delete
        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var product = _context.Products.Find(id);

            if (product == null)
                return NotFound();

            else
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
                return NoContent();
            }
            
        }
    }
}
