using BoostLife.DAL;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using System.Diagnostics;

namespace BoostLife.Repositorys;

public abstract class RepositoryBase
{

    public static BoostLifeContext GetContext()
    {
        try
        {
            string connectionString = ConfigurationManager.ConnectionStrings["dbConn"].ConnectionString;
            var optionsBuilder = new DbContextOptionsBuilder<BoostLifeContext>();
            optionsBuilder.UseNpgsql(connectionString);
            return new(optionsBuilder.Options);
        }
        catch(Exception ex)
        {
            Debug.WriteLine($"Ocorreu um erro ao criar a conexão {ex}");
            return null!;
        }
       

    }


}
