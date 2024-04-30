using Microsoft.EntityFrameworkCore;
using TaskManager;
using TaskManager.Data;
using TaskManager.Endpoint;
using TaskManager.Repository;
using TaskManager.Repository.IRepository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IMyTaskRepository, MyTaskRepository>();
builder.Services.AddDbContext<ApplicationDbContext>(option =>
	option.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddAutoMapper(typeof(MappingConfig));
builder.Services.AddMemoryCache();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.ConfigureMyTaskEndpoints();
app.UseHttpsRedirection();

app.Run();
