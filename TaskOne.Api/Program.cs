using Microsoft.EntityFrameworkCore;
using TaskOne.application.Features.Schools.Command.Create;
using TaskOne.Domain.Interfaces;
using TaskOne.Infrastructure.Data;
using TaskOne.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<SchoolContext>(options =>
	options.UseInMemoryDatabase("InMemoryDb"));
builder.Services.AddMediatR(cfg =>
	cfg.RegisterServicesFromAssembly(typeof(CreateSchoolCommand).Assembly));
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
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
