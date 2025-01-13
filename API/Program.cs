using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddDbContext<CartContext>(options=>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("CartConnection"));
});


var app = builder.Build();

app.MapControllers();

app.Run();
