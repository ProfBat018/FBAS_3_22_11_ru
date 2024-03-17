using Data.DbContexts;
using Data.Models;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(); // добавляю поддерджку сваггера, он нужен для графического тестирования нашего API

// Создаю объект DbContext и добавляю его в кон тейнер
builder.Services.AddDbContext<BikeStoreContext>(ops =>
{
    ops.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// MapGet - это функция для HTTP GET запроса. 
app.MapGet("getallproducts", async (BikeStoreContext context) => { return await context.Products.ToListAsync(); })
    .WithName("GetAllProducts") // название для сваггера
    .WithOpenApi(); // Добавляю в метаданные API, что я использую стандарты OpenApi


app.MapPost("addnewbrand", async (BikeStoreContext context, HttpRequest request) =>
    {
        try
        {
            var header = request.Headers.First(x => x.Key.ToLower() == "brand");
            var brand = new Brand()
            {
                BrandName = header.Value
            };

            context.Brands.Add(brand);
            context.SaveChanges();

            return new
            {
                Result = "Brand added",
                Code = 200
            };
        }
        catch (Exception e)
        {
            return new
            {
                Result = e.Message,
                Code = e.HResult
            };
        }
    }).WithName("AddNewBrand")
    .WithOpenApi();

app.UseHttpsRedirection();

app.Run();