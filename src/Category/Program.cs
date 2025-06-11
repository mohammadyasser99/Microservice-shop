

using Category.Infrastructure.Data.Models;
using Category.BL.serviceextension;
using Microsoft.EntityFrameworkCore;
using Category.Infrastructure.infraserviceextension;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<CategoryContext>(opts =>
{
    opts.UseSqlServer(builder.Configuration.GetConnectionString("MicroSericeShop"));
});
builder.Services.AddBLServices();
builder.Services.AddInfraServices();
builder.Services.AddControllers();
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
