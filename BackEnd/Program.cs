using Microsoft.EntityFrameworkCore;
using QueroServicos.Data;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
var connectionStringMysql = builder.Configuration.GetConnectionString("ConnectionMysql");
builder.Services.AddDbContext<ApplicationDbContext>(x => x.UseMySql(
    connectionStringMysql, ServerVersion.Parse("10.4.25-MariaDB")));



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