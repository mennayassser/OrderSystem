using MarketService.Infrastructure;
using MarketService.Application;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Serilog;
using Serilog.Configuration;
using Serilog.Events;
using System;
using System.Text;
using MarketService.Infrastructure.Middleware;


var builder = WebApplication.CreateBuilder(args);
//builder.WebHost.UseUrls("http://localhost:7091");


builder.Configuration
    .AddJsonFile("appsettings.child.json", optional: true, reloadOnChange: true);

// Add services to the container.
builder.Host.UseSerilog((ctx, lc) => lc
    .ReadFrom.Configuration(ctx.Configuration));

builder.Services.AddDbContext<MarketDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        sqlOptions =>
        {
            sqlOptions.EnableRetryOnFailure(
                maxRetryCount: 5,
                maxRetryDelay: TimeSpan.FromSeconds(10),
                errorNumbersToAdd: null);
            sqlOptions.CommandTimeout(60);
        }
    ));
builder.Services.AddScoped<IProducer, Producer>();

builder.Services.AddSignalR();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = builder.Configuration["Jwt:Issuer"],
            ValidAudience = builder.Configuration["Jwt:Audience"],
            IssuerSigningKey = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
        };
    });

builder.Services.AddAuthorization();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFrontend", policy => 
        policy.WithOrigins("http://localhost:5000", "http://localhost:7092", "http://localhost:7167") 
              .AllowAnyHeader()
              .AllowAnyMethod()
              .AllowCredentials());
});



var app = builder.Build();



app.UseSwagger();
app.UseSwaggerUI();


app.UseMiddleware<UsernameLoggingMiddleware>();

if (!Environment.GetEnvironmentVariable("DOTNET_RUNNING_IN_CONTAINER")?.ToLower().Equals("true") == true)
{
    app.UseHttpsRedirection();
}

app.UseRouting();

app.UseCors("AllowFrontend");

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

//try
//{
//    using var scope = app.Services.CreateScope();
//    var db = scope.ServiceProvider.GetRequiredService<MarketDbContext>();
//    db.Database.Migrate();
//}
//catch (Exception ex)
//{
//    Console.WriteLine($"Startup migration failed: {ex.Message}");
//}

app.Run();
