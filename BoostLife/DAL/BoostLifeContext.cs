using BoostLife.Models;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace BoostLife.DAL;

public class BoostLifeContext(DbContextOptions options) : DbContext(options)
{

    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Conta>  Contas { get; set; }
    public DbSet<Projeto>  Projetos{ get; set; }
    public DbSet<Vicio>  Vicios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

        base.OnConfiguring(optionsBuilder);
        string connectionString = ConfigurationManager.ConnectionStrings["dbConn"].ConnectionString;
        optionsBuilder.UseNpgsql(connectionString);

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Categoria>(e =>
        {
            e.Property(x => x.Id).IsRequired();
            e.Property(x => x.Descricao).IsRequired().HasColumnType("TEXT");
        });
    }


}
