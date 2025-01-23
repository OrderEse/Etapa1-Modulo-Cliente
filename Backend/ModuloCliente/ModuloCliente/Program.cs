using Microsoft.EntityFrameworkCore;
using ModuloCliente.BW.CU;
using ModuloCliente.BW.Interfaces.BW;
using ModuloCliente.BW.Interfaces.DA;
using ModuloCliente.DA.Acciones;
using ModuloCliente.DA.Contexto;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<IGestionarSolicitudBW, GestionarSolicitudBW>();
builder.Services.AddTransient<IGestionarSolicitudDA, GestionarSolicitudDA>();

builder.Services.AddDbContext<ModuloClienteContexto>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConexionSqlServer")));


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
