using Api.Extensions;
using Application.Extensions;
using Infrastructure.Extensions;
using Infrastructure.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

// Add services to the container.
var Cors = "Cors";

builder.Services.AddInjectionInfrastructure(configuration);
builder.Services.AddInjectionApplication(configuration);
builder.Services.AddAuthentication(configuration);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwagger();

builder.Services.AddDbContext<PersistenceContext>(option =>
{
    option.UseInMemoryDatabase(databaseName: "TestLogin");
});

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: Cors,
        builder =>
        {
            builder.WithOrigins("*");
            builder.AllowAnyMethod();
            builder.AllowAnyHeader();
        });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(Cors);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
