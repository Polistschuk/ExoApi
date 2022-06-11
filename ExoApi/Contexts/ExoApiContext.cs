using ExoApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ExoApi.Contexts
{
    public class ExoApiContext : DbContext
    {
        public ExoApiContext()
        {

        }
        public ExoApiContext(DbContextOptions<ExoApiContext> options) : base(options)
        {

        }
        // vamos utilizar esse método para configurar o banco de dados
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=PGL-PC;Initial Catalog=ExoApiDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }
        // dbset representa as entidades que serão utilizadas nas operações de leitura, criação, atualização e deleção
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Projeto> Projetos { get; set; }
    }
}
