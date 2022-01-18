using Microsoft.EntityFrameworkCore;
using AsyncTrainingDotnet6.Samples.AsyncWebAPI.Data;
using AsyncTrainingDotnet6.Samples.AsyncWebAPI.Services;

var builder = WebApplication.CreateBuilder(args);
var configuration = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json")
    .Build();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),ef => ef.MigrationsAssembly(typeof(DataContext).Assembly.FullName));
});
builder.Services.AddTransient<IEmployeeService, EmployeeService>();
builder.Services.AddScoped<IDataContext, DataContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
