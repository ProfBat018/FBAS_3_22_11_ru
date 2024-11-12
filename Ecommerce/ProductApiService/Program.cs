using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.EntityFrameworkCore;
using ProductData.Contexts;
using ProductRepository.Classes;
using ProductRepository.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

builder.Services.AddCors(ops => ops.AddPolicy("Default", builder =>
{
    builder.AllowAnyHeader();
    builder.AllowAnyOrigin();
    builder.AllowAnyMethod();
}));

builder.Services.AddDbContext<ProductContext>(ops =>
    ops.UseSqlServer(builder.Configuration.GetConnectionString("DefaultMacEcommerce")));

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

var app = builder.Build();


app.UseCors("Default");

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();
app.UseHttpsRedirection();

app.Run();