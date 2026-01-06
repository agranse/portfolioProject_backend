using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace PortfolioApi.Data;

public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
{
    public AppDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();

        // Use the SAME connection string you use in Program.cs
        optionsBuilder.UseMySql(
            "server=localhost;port=3306;database=portfolio;user=root;password=ApolloCat1",
            new MySqlServerVersion(new Version(8, 0, 36))
        );

        return new AppDbContext(optionsBuilder.Options);
    }
}
