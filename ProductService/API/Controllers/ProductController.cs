using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using ProductService.Domain;
using ProductService.Infrastructure;

namespace ProductService.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ProductDbContext _context;

        public ProductController(ProductDbContext context)
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

            _context.Set<Product>().Add(product);
            _context.SaveChanges();

            return Ok(product);
        }

        // read by id
        [HttpGet("{id}")]
        public ActionResult<Product> GetProduct(int id)
        {
            var product = _context.Set<Product>().Find(id);
            if (product == null)
                return NotFound();
            else
                return Ok(product);
        }

        // read all products
        [HttpGet]
        public ActionResult<List<Product>> GetAllProducts()
        {
            var AllProducts = _context.Set<Product>().ToList();
            return Ok(AllProducts);
        }

        // update
        [HttpPut("{id}")]
        public IActionResult UpdateProduct(int id, [FromBody] Product newProduct)
        {
            var product = _context.Set<Product>().Find(id);

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
            var product = _context.Set<Product>().Find(id);

            if (product == null)
                return NotFound();

            else
            {
                _context.Set<Product>().Remove(product);
                _context.SaveChanges();
                return NoContent();
            }
        }
    }
}
