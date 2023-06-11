using api_with_cosmosdb.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Cosmos;
using dotenv;

namespace api_with_cosmosdb.Data
{
    public class NorthWindContext : DbContext
    {
        public DbSet<Employer> Employers { get; set; }
        public DbSet<Costumer> Costumers { get; set; }

    }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseCosmos(
            "",
            "",
            ""
        );
    }
}