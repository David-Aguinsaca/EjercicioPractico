using PruebaPractica.Application;
using PruebaPractica.Application.controller;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Inyeccion dependencia

builder.Services.AddTransient<RootAppServiceController>();

//services.AddTransient<IMarcaRepository, MarcaRepository>();
//builder.Services.AddTransient<IRoot RootAppServiceController>();



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
