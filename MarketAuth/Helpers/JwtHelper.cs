using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.Text;

public static class JwtHelper
{
    public static string GenerateToken(string username, IConfiguration config)
    {
        var key = config["Jwt:Key"];
        Console.WriteLine($"JWT key length = {key?.Length} | Value = {key}");
        var issuer = config["Jwt:Issuer"];
        var audience = config["Jwt:Audience"];
        var expire = config["Jwt:ExpireMinutes"];

        Console.WriteLine($"JWT Config - Issuer: {issuer}, Audience: {audience}, Expire: {expire}");


        if (string.IsNullOrWhiteSpace(key) || string.IsNullOrWhiteSpace(issuer) || string.IsNullOrWhiteSpace(audience) || string.IsNullOrWhiteSpace(expire))
            throw new Exception("One or more JWT config values are missing or empty.");

        if (Encoding.UTF8.GetBytes(key).Length < 16)
        {
            throw new ArgumentException($"JWT Key must be at least 16 characters (128 bits) long. Current length: {Encoding.UTF8.GetBytes(key).Length}");
        }

        var claims = new[]
        {
            new Claim(ClaimTypes.Name, username)
        };

        var symmetricKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
        var creds = new SigningCredentials(symmetricKey, SecurityAlgorithms.HmacSha256);

        try
        {
            var token = new JwtSecurityToken(
                issuer: issuer,
                audience: audience,
                claims: claims,
                expires: DateTime.Now.AddMinutes(Convert.ToDouble(expire)),
                signingCredentials: creds
            );

            var tokenString = new JwtSecurityTokenHandler().WriteToken(token);
            Console.WriteLine($"JWT token generated successfully. Length: {tokenString?.Length ?? 0}");
            return tokenString;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error generating JWT token: {ex.Message}");
            throw;
        }
    }
}
