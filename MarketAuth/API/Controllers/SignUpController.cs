using Azure.Core;
using BCrypt.Net;
using MarketAuth.Infrastructure.Data;
using MarketAuth.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MarketAuth.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SignUpController : ControllerBase
    {
        private readonly MarketAuthDbContext _context;
        private readonly ILogger<SignUpController> _logger;

        public SignUpController(MarketAuthDbContext context, ILogger<SignUpController> logger)
        {
            _context = context;
            _logger = logger;
        }

        public class SignUpRequest
        {
            public string UserName { get; set; }
            public string Password { get; set; }
        }


        public static class PasswordHasher
        {
            public static string Hash(string password) =>
                BCrypt.Net.BCrypt.HashPassword(password);

            public static bool Verify(string password, string hashedPassword)
            {
                try
                {
                    return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"BCrypt verification error: {ex.Message}");
                    return false;
                }
            }
        }

        [HttpPost("signup")]
        public async Task<IActionResult> CreateUser([FromBody] SignUpRequest request)
        {
            if (request == null || string.IsNullOrWhiteSpace(request.UserName) || string.IsNullOrWhiteSpace(request.Password))
                return BadRequest("Username and password are required.");

            var existingUser = await _context.Users.AnyAsync(u => u.UserName == request.UserName);
            if (existingUser)
                return Conflict("User already exists.");

            try
            {
                var user = new User
                {
                    UserName = request.UserName,
                    PasswordHash = PasswordHasher.Hash(request.Password)
                };
                _context.Users.Add(user);
                await _context.SaveChangesAsync();

                return CreatedAtAction(nameof(GetUserByUsername), new { username = user.UserName }, new { user.UserName });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error creating user {UserName}", request.UserName);
                return StatusCode(500, "Internal server error.");
            }
        }

        [HttpGet("user/{username}")]
        public async Task<IActionResult> GetUserByUsername(string username)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.UserName == username);
            if (user == null)
                return NotFound();

            return Ok(new { user.UserName });
        }
    }
}
