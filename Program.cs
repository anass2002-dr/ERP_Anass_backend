using ERP_Anass_backend;
using ERP_Anass_backend.Repository.ArticleRepo;
using ERP_Anass_backend.Repository.FamilyRepo;
using ERP_Anass_backend.Services.ArticleService;
using ERP_Anass_backend.Services.FamillyServices;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

ConfigurationManager configuration = builder.Configuration;

// Retrieve the connection string from configuration
var connectionString = configuration.GetConnectionString("defaultConnection");

// Add Database service and specify the migrations assembly
builder.Services.AddDbContext<DbContextERP>(options =>
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString),
    b => b.MigrationsAssembly("ERP_Anass_backend")));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IArticleService, ArticleService>();
builder.Services.AddScoped<IRepoArticle, RepoArticle>();

builder.Services.AddScoped<IFamillyRepo, FamillyRepo>();
builder.Services.AddScoped<IFamillyService, FamillyService>();


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
