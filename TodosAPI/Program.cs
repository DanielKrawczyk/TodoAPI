using MediatR;
using System.Reflection;
using TodosAPI.Infrastructure.Data;
using TodosAPI.Infrastructure.Data.Repositories;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;

services.AddControllers();
services.AddMediatR(Assembly.GetExecutingAssembly());
services.AddSingleton<DataContext>();
services.AddRepositories();

var app = builder.Build();
app.MapControllers();

app.Run();
