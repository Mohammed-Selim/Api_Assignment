using Application.contracts;
using Application.Features.Categories.Queries.GetAllCategories;
using DComtext;
using FluentValidation;
using infraStructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<Context>(option =>
option.UseSqlServer(builder.Configuration.GetConnectionString("EcommerceDBase")));

//builder.Services.AddControllers()
//            .AddJsonOptions(o => o.JsonSerializerOptions
//                .ReferenceHandler = ReferenceHandler.IgnoreCycles);


builder.Services.AddMediatR(config => config
.RegisterServicesFromAssembly(typeof(GetAllCategoriesquery).Assembly));

builder.Services.AddScoped<ICategoryRepository, CategoryRepo>();

builder.Services.AddValidatorsFromAssembly(typeof(GetAllCategoriesquery).Assembly);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();


var app = builder.Build();
//app.MapGet("/", () => "Hello World!");
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.MapControllers();

app.Run();
