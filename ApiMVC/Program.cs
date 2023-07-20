using API.Repositories;
using ApiMVC.Repositories;
using ApiMVC.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("ArquivoConnection");

builder.Services.AddDbContext<AppDBContext>(opts =>
    opts.UseSqlServer(connectionString));

builder.Services.AddTransient<IArquivoService, ArquivoService>();
builder.Services.AddTransient<IArquivoRepository, ArquivoRepository>();
builder.Services.AddTransient<IAzureStorage, AzureStorage>();
// Add services to the container.

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

#region [Cors]
app.UseCors(c =>
{
    c.AllowAnyHeader();
    c.AllowAnyMethod();
    c.AllowAnyOrigin();
});
#endregion

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
