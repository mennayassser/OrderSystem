using BackgroundWorker.API.Controllers;
using BackgroundWorker.Infrastructure;
using BackgroundWorker.Application;
using Microsoft.Extensions.Configuration;
using Serilog;
using Serilog.Configuration;
using Serilog.Events;
using System;
using System.Threading;
using BackgroundWorker.Infrastructure.Hubs;

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseSerilog((ctx, lc) => lc.ReadFrom.Configuration(ctx.Configuration));

builder.Services.AddSignalR();
builder.Services.AddSingleton<IConsumer, Consumer>();
builder.Services.AddSwaggerGen();


;
builder.Services.AddControllers()
    .ConfigureApplicationPartManager(apm =>
    {
        apm.ApplicationParts.Clear();
        apm.ApplicationParts.Add(new Microsoft.AspNetCore.Mvc.ApplicationParts.AssemblyPart(typeof(LatestMsgController).Assembly));
    });

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFrontend", policy =>
        policy.WithOrigins("http://localhost:5000", "http://localhost:7092", "http://localhost:7167")
              .AllowAnyHeader()
              .AllowAnyMethod()
              .AllowCredentials());
});


builder.WebHost.UseUrls("http://0.0.0.0:8080");

builder.Logging.ClearProviders();
builder.Logging.AddConsole();
builder.Logging.AddDebug();

var app = builder.Build();


app.UseSwagger();
app.UseSwaggerUI();

var consumer = app.Services.GetRequiredService<IConsumer>();
_ = Task.Run(() => consumer.StartConsumingAsync(CancellationToken.None));


app.UseRouting();

app.UseCors("AllowFrontend");

app.UseAuthentication();
app.UseAuthorization();


app.MapControllers();
app.MapHub<OrderHub>("/orderhub");

app.Run();







