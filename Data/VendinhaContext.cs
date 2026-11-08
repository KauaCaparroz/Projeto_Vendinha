using Microsoft.EntityFrameworkCore;
using Projeto_Vendinha.Models;

namespace Projeto_Vendinha.Data
{
    public class VendinhaContext : DbContext
    {
        public VendinhaContext(
            DbContextOptions<VendinhaContext> options)
            : base(options)//VendinhaContext herda de DbContext, uma classe do Entity Framework Core que permite trabalhar com o banco de dados usando C#
        {
        }

        // Representa a tabela de clientes
        public DbSet<Cliente> Clientes => Set<Cliente>();

        // Representa a tabela de dívidas
        public DbSet<Divida> Dividas => Set<Divida>();
    }
}