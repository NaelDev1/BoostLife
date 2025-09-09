using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace BoostLife.DAL;

public class BoostLifeContextFactory : IDesignTimeDbContextFactory<BoostLifeContext>
{
    public BoostLifeContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<BoostLifeContext>();
        optionsBuilder.UseNpgsql("Host=localhost;Database=boostlife;User Id=postgres; Port=5432; Password=root;");
        return new BoostLifeContext(optionsBuilder.Options);
    }
}
