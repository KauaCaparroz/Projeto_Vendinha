using Microsoft.EntityFrameworkCore;
using Projeto_Vendinha.Data;

var builder = WebApplication.CreateBuilder(args);

// vai permitir que o sistema utilize os Controllers, que são responsáveis por receber pedidos como cadastrar um cliente ou consultar uma dívida

builder.Services.AddControllers();

builder.Services.AddDbContext<VendinhaContext>(options =>
    options.UseSqlite("Data Source=vendinha.db"));
    
builder.Services.AddOpenApi();

var app = builder.Build();

// Cria as tabelas do banco de dados, caso ainda não existam
using (var scope = app.Services.CreateScope())
{
    var banco = scope.ServiceProvider.GetRequiredService<VendinhaContext>();
    banco.Database.EnsureCreated();
}

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();