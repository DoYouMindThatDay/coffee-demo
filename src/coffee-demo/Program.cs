global using coffee_demo.apis;
global using coffee_demo.Interfaces;
global using coffee_demo.Data.Models;
using coffee_demo;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services
    .AddEndpointsApiExplorer()
    .AddSwaggerGen()
    .AddStartupServices();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

var apis = app.MapGroup("").WithOpenApi();

apis.MapGroup("coffees").MapCoffee();

app.Run();
