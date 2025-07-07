using Market.Data;
using Market.Models;
using Market.Services;
using Microsoft.AspNetCore.Mvc;

namespace Market.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class OrderController : ControllerBase
    {

        private readonly MarketDbContext _context;
        private readonly IProducer _producer;

        public OrderController(MarketDbContext context, IProducer producer)
        {
            _context = context;
            _producer = producer;
        }

        // crud operations


        // create
        [HttpPost]
        public async Task<IActionResult> CreateOrder([FromBody] Order order)
        {
            if (order == null)
            {
                return BadRequest("No Data Provided");
            }

            if (order.Price <= 0)
            {
                return BadRequest("Invalid Order Data");
            }

            if (order.Products == null)
            {
                return BadRequest("Invalid Order Data");
            }

            _context.Orders.Add(order);
            await _context.SaveChangesAsync();

            await _producer.ProduceOrderMessage(order);

            return Ok(order);
        }

        // read all orders
        [HttpGet]
        public ActionResult<List<Order>> GetAllOrders()
        {
            var allOrders = _context.Orders.ToList();
            return Ok(allOrders);

        }

        // read by id
        [HttpGet("{id}")]
        public ActionResult<Order> GetOrder(int id)
        {
            var order = _context.Orders.Find(id);

            if (order == null)
                return NotFound();

            return Ok(order);
        }

        // read by client id (read all orders by this client)

        // update
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateOrder(int id, [FromBody] Order newOrder)
        {
            var order = _context.Orders.Find(id);

            if (order == null)
                return NotFound();

            order.CustomerId = order.CustomerId;
            order.Price = newOrder.Price;
            order.Direction = newOrder.Direction;
            order.Quantity = newOrder.Quantity;
            order.Products = newOrder.Products;

            await _context.SaveChangesAsync();

            await _producer.ProduceOrderMessage(order);

            return Ok(order);

        }

        // delete
        [HttpDelete("{id}")]
        public async Task <IActionResult> DeleteOrder(int id)
        {
            var order = _context.Orders.Find(id);

            if (order == null)
                return NotFound();

            else
            {
                _context.Orders.Remove(order);
                _context.SaveChanges();

                await _producer.ProduceOrderMessage(order);

                return NoContent();

            }
        }
    }
}
