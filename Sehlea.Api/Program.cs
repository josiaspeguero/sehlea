using Microsoft.EntityFrameworkCore;
using Sehlea.Api.Infrastructure.Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//dbContext
builder.Services.AddDbContext<AppDbContext>(
req => req.UseSqlServer(
    builder.Configuration.GetConnectionString("DefaultSqlServerConnection"))); //al momento de mandar a producción se debe
                                                                               //cambiar esto por una variable de ambiente
                                                                               

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
