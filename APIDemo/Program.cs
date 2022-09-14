using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using APIDemo.Data;
using APIDemo.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData;
using APIDemo.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<APIDemoContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("APIDemoContext") ?? throw new InvalidOperationException("Connection string 'APIDemoContext' not found.")));

// Add services to the container.

builder.Services.AddControllers().AddOData(options => options.Select().Filter());
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddDbContext<APIDemoContext>(opt =>
    opt.UseInMemoryDatabase("TodoList"));
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new() { Title = "TodoApi", Version = "v1" });
});
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "TodoApi v1"));
     app.UseSwaggerUI();
}
app.UseDefaultFiles();
app.UseStaticFiles();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();



app.Run();
