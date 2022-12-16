using ECommerce.Data;
using ECommerce.Models;
using ECommerce.Models.Domain;
using ECommerce.Models.Filters;
using ECommerce.Services;
using ECommerce.Services.FilterServices;
using ECommerce.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ECommerceContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddTransient<IFilter<PhoneFilters, Phone>, PhonesFilterService>();
builder.Services.AddTransient<IFilter<FridgeFilters, Fridge>, FridgesFilterService>();
builder.Services.AddTransient<IFilter<HeadphonesFilters, Headphones>, HeadphonesFilterService>();
builder.Services.AddTransient<IFilter<LaptopFilters, Laptop>, LaptopsFilterService>();
builder.Services.AddTransient<IFilter<TabletFilters, Tablet>, TabletsFilterService>();
builder.Services.AddTransient<IFilter<TelevisionFilters, Television>, TelevisionsFilterService>();
builder.Services.AddTransient<IRating, RatingService>();
builder.Services.AddTransient<IPostReview, PostReviewService>();
builder.Services.AddTransient(typeof(IValidate<>), typeof(Validator<>));
builder.Services.AddScoped(typeof(RetrieveProductsService<,,>));
builder.Services.AddAutoMapper(typeof(MappingProfiles));

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

//(new SeedData()).Seed();

app.Run();
