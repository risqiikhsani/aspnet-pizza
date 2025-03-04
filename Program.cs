using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

using ContosoPizza.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.



// Add other services
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add services to the container.
// builder.Services.AddControllersWithViews();

var app = builder.Build();



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// app.UseStaticFiles();

// app.UseRouting();

app.UseAuthorization();
app.MapControllers();

app.Run();
