using Microsoft.AspNetCore.Http;
using Serilog.Context;
using System.Threading.Tasks;

public class UsernameLoggingMiddleware
{
    private readonly RequestDelegate _next;

    public UsernameLoggingMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        var username = context.Request.Headers["X-Username"].ToString();

        using (LogContext.PushProperty("User", string.IsNullOrEmpty(username) ? "Anonymous" : username))
        {
            try
            {
                await _next(context); 
            }
            catch (Exception ex)
            {
                Console.WriteLine("Middleware error: " + ex.Message);
                throw;
            }
        }
    }
}
