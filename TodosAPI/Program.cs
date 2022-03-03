using MediatR;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;

services.AddControllers();
services.AddMediatR(Assembly.GetExecutingAssembly());

var app = builder.Build();
app.MapControllers();

app.Run();
