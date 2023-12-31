using Microsoft.EntityFrameworkCore;
using src.Data;
using src.Domain;
using src.Interfaces;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<IPessoa, PessoaDomain>();
builder.Services.AddScoped<IEndereco, EnderecoDomain>();
// AddDbContext -> postgres  
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseLazyLoadingProxies().UseNpgsql(builder.Configuration.GetConnectionString("Default"),
    assembly => assembly.MigrationsAssembly(typeof(AppDbContext).Assembly.FullName)
    );
});
// AddAutoMapper 
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseCors(x => x
    .AllowAnyOrigin() // Permite todas as origens
    .AllowAnyMethod() // Permite todos os métodos
    .AllowAnyHeader()) // Permite todos os cabeçalhos
    .UseAuthentication();
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
