using Business.Classes;
using Business.Interfaces;
using Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Configuracion de acceso a datos
var connectionString =
    builder.Configuration.GetConnectionString("Connection");//Crea la variable con la cadena de conexion
        /*?? throw new InvalidOperationException("Connection string"
        + "'DefaultConnection' not found.");*/

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(connectionString));//Construye el contexto

//Contruye acceso a la interfase cliente
builder.Services.AddScoped<ICliente, LogicaCliente>();

var app = builder.Build();

app.UseCors(c=>c.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod());


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
