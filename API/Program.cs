using API.Repositories;
using API.Services;
using DataAccess.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Adding the DbContext to the service container
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    // install Microsoft.EntityFrameworkCore.Proxies
    //means that the related data is transparently loaded from the database when the navigation property is accessed
    options.UseLazyLoadingProxies();
    options.UseSqlServer(builder.Configuration.GetConnectionString("CoffeeShopConnection"));
});

builder.Services.AddScoped<ICoffeeShopRepository,CoffeeShopRepository>();
builder.Services.AddScoped<ICoffeeShopService, CoffeeShopService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
