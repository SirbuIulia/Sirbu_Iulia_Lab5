using Microsoft.EntityFrameworkCore;
using Sirbu_Iulia_Lab5.Models;
using Microsoft.Extensions.DependencyInjection;
using Sirbu_Iulia_Lab5.Data;
using System.Globalization;
using Microsoft.AspNetCore.Builder;


var builder = WebApplication.CreateBuilder(args);

CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.InvariantCulture;

builder.Services.AddDbContext<Sirbu_Iulia_Lab5Context>(options =>
   options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddControllersWithViews();
//builder.Services.AddDbContext<Sirbu_Iulia_Lab5Context>(options =>
  //  options.UseInMemoryDatabase("ExpenseList"));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
