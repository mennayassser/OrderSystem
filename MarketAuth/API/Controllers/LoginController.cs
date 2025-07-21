using MarketAuth.Infrastructure.Data;
using MarketAuth.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
// using static MarketAuth.Controllers.SignUpController;
using MarketAuth.DTOs;
using static MarketAuth.API.Controllers.SignUpController;

namespace MarketAuth.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly MarketAuthDbContext _context;
        private readonly ILogger<LoginController> _logger;
        private readonly IConfiguration _config;

        public LoginController(MarketAuthDbContext context, ILogger<LoginController> logger, IConfiguration config)
        {
            _context = context;
            _logger = logger;
            _config = config;
        }

        [HttpPost("login")]
        public async Task<IActionResult> LoginUser([FromBody] LoginRequest loginUser)
        {
            if (loginUser == null || string.IsNullOrWhiteSpace(loginUser.UserName) || string.IsNullOrWhiteSpace(loginUser.Password))
            {
                return BadRequest(new { Message = "Username and password are required." });
            }

            try
            {
                _logger.LogInformation("Attempting login for {UserName}", loginUser.UserName);

                // Check if database is accessible
                var userCount = await _context.Users.CountAsync();
                _logger.LogInformation("Database accessible. Total users: {UserCount}", userCount);

                var user = await _context.Users.FirstOrDefaultAsync(u => u.UserName == loginUser.UserName);
                if (user == null)
                {
                    _logger.LogWarning("User not found: {UserName}", loginUser.UserName);
                    return Unauthorized(new { Message = "Invalid credentials." });
                }

                _logger.LogInformation("User found: {UserName}, PasswordHash length: {HashLength}", loginUser.UserName, user.PasswordHash?.Length ?? 0);

                bool isValid = PasswordHasher.Verify(loginUser.Password, user.PasswordHash);
                if (!isValid)
                {
                    _logger.LogWarning("Password mismatch for user {UserName}", loginUser.UserName);
                    return Unauthorized(new { Message = "Invalid credentials." });
                }

                _logger.LogInformation("Password verified successfully for user {UserName}", loginUser.UserName);
                
                try
                {
                    var token = JwtHelper.GenerateToken(user.UserName, _config);
                    _logger.LogInformation("JWT token generated successfully for user {UserName}", loginUser.UserName);
                                    return Ok(new
                    {
                        Token = token,
                        UserName = user.UserName,
                        ExpiresIn = DateTime.UtcNow.AddMinutes(Convert.ToDouble(_config["Jwt:ExpireMinutes"]))
                    });
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Error generating JWT token for user {UserName}", loginUser.UserName);
                    return StatusCode(500, new { Message = "An error occurred during login." });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error during login for user {UserName}", loginUser.UserName);
                return StatusCode(500, new { Message = "An error occurred during login." });
            }
        }
    }
}
