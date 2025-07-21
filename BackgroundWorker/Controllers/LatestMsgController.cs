using Market.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackgroundWorker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LatestMsgController : ControllerBase
    {
        private readonly IConsumer _consumer;

        public LatestMsgController(IConsumer consumer)
        {
            _consumer = consumer;
        }

        [HttpGet("last-message")]
        public IActionResult GetLastMessage()
        {
            return Ok(new
            {
            });

        }
    }
}
