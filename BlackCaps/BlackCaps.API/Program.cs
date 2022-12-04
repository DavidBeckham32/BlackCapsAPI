using BlackCaps.API.Data;
using BlackCaps.API.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//add dbcontext here
builder.Services.AddDbContext<BlackCapsDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("BlackCapsConnectionString"));
});

//adding DI for IRepository
builder.Services.AddScoped<IRegionRepository , RegionRepository>();
//after above line is written
//we can use RegionRepository in our Controller

//add Automapper here
builder.Services.AddAutoMapper(typeof(Program).Assembly);

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
