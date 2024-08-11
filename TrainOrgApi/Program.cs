using Microsoft.EntityFrameworkCore;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using TrainOrgApi.Data;
using Autofac.Core;
using TrainOrgApi.Abstraction;
using TrainOrgApi.Repository;
using Microsoft.AspNetCore.Hosting;
using TrainOrgApi.Mapper;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<SessionContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("SessionContext") ?? throw new InvalidOperationException("Connection string 'SessionContext' not found.")));
//builder.Services.AddDbContext<UserContext>(options =>
//    options.UseNpgsql(builder.Configuration.GetConnectionString("UserContext") ?? throw new InvalidOperationException("Connection string 'UserContext' not found.")));
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<ISessionRepository, SessionRepository>();
builder.Services.AddAutoMapper(typeof(MapperProfile));
// Add services to the container.

//var config = new ConfigurationBuilder();
//config.AddJsonFile("appsettings.json");
//var cfg = config.Build();

//builder.Host.ConfigureContainer<ContainerBuilder>(container =>
//{
//    //container.RegisterType<ProductRepository>().As<IProductRepository>();
//    //container.RegisterType<ProductGroupRepository>().As<IProductGroupRepository>();
//    container.Register(_ => new UserContext(cfg.GetConnectionString("UserContext"))).InstancePerDependency();
//    container.Register(_ => new SessionContext(cfg.GetConnectionString("SessionContext"))).InstancePerDependency();
//});

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
