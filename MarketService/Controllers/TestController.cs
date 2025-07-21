using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

[ApiController]
[Route("api/[controller]")]
public class ConfigController : ControllerBase
{
    private readonly IConfiguration _config;

    public ConfigController(IConfiguration config)
    {
        _config = config;
    }

    [HttpGet("LastPrice")]
    public IActionResult GetThreshold()
    {
        int lastPrice = _config.GetValue<int>("MySettings:LastPrice");
        return Ok(new { lastPrice });
    }
}