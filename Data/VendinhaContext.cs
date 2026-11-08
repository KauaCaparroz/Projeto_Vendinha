using Microsoft.EntityFrameworkCore;
using Projeto_Vendinha.Models;

namespace Projeto_Vendinha.Data
{
    public class VendinhaContext : DbContext
    {
        public VendinhaContext(
            DbContextOptions<VendinhaContext> options)
            : base(options)
        {
        }

        // Representa a tabela de clientes
        public DbSet<Cliente> Clientes => Set<Cliente>();

        // Representa a tabela de dívidas
        public DbSet<Divida> Dividas => Set<Divida>();
    }
}