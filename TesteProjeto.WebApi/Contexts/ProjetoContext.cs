
using Microsoft.EntityFrameworkCore;
using ProjetoTeste.Models;
using TesteProjeto.WebApi.Contexts;

namespace ProjetoTeste.Contexts
{
    public class ProjetoContext : DbContext
    {
        public ProjetoContext()
        {
        }

        public ProjetoContext(DbContextOptions<ProjetoContext> options) : base(options)
        {

        }

        // vamos utilizar esse método para configurar o banco de dados
        protected override void
            OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // cada provedor tem sua sintaxe para especificação
                optionsBuilder.UseSqlServer("Data Source = DESKTOP-MM3CABC\\SQLEXPRESS; initial catalog = Projeto; Integrated Security = true");
            }
        }
        // dbset representa as entidades que serão utilizadas nas operações de leitura, criação, atualização e deleção
        public DbSet<Projeto> Projeto { get; set; }

        public DbSet<Usuario> Usuario { get; set; }

    }
}