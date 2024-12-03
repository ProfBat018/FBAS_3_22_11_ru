using chatBot.Hubs;
using Microsoft.AspNetCore.SignalR;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddCors(options => options.AddDefaultPolicy(policy =>
{
    policy.WithOrigins("http://localhost:3000") 
        .AllowAnyMethod()
        .AllowAnyHeader()
        .AllowCredentials(); 
}));

builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

builder.Services.AddSignalR();

var app = builder.Build();

app.UseCors();
app.UseSwagger();
app.UseSwaggerUI();

app.MapHub<ManagerHub>("/chatHub");

app.UseHttpsRedirection();
app.Run();