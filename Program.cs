using EventManager.Context;
using EventManager.Interfaces.Repositories;
using EventManager.Interfaces.Services;
using EventManager.Repository;
using EventManager.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<EventManagerContext>();

builder.Services.AddScoped<IOrganizerRepository, OrganizerRepository>();

builder.Services.AddScoped<IEventRepository, EventRepository>();
builder.Services.AddScoped<IEventServices, EventServices>();

builder.Services.AddScoped<IAddressRepository, AddressRepository>();


builder.Services.AddControllers();

var connectionString = builder.Configuration.GetConnectionString("EventManager");
builder.Services.AddDbContext<EventManagerContext>(options =>
{
    options.UseSqlServer(connectionString).LogTo(Console.WriteLine, LogLevel.Information);
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
