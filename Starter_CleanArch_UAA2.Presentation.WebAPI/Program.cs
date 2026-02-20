using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;
using Starter_CleanArch_UAA2.ApplicationCore.Interfaces.Services;
using Starter_CleanArch_UAA2.ApplicationCore.Services;
using Starter_CleanArch_UAA2.Domain.Models;
using Starter_CleanArch_UAA2.Infrastructure.Database;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSingleton<Random>();
builder.Services.AddScoped<IExampleMessageService, ExampleMessageService>();

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
});
builder.Services.AddControllers();

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
