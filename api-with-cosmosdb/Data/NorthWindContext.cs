using api_with_cosmosdb.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Cosmos;
using DotNetEnv;

namespace api_with_cosmosdb.Data
{
    public class NorthWindContext : DbContext
    {
        public DbSet<Employer>? Employers { get; set; }
        public DbSet<Custumer>? Costumers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            DotNetEnv.Env.Load();

            string accountKey = Environment.GetEnvironmentVariable("ACCOUNTKEY");
            string databaseName = Environment.GetEnvironmentVariable("DATABASENAME");
            string accountEndpoint = Environment.GetEnvironmentVariable("ACCOUNTENDPOINT");

            optionsBuilder.UseCosmos(
                accountEndpoint,
                accountKey,
                databaseName
            );
        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // configuration employees
            modelBuilder.Entity<Employer>()
            .ToContainer("Employers")
            .HasPartitionKey(e => e.Id);

            modelBuilder.Entity<Custumer>()
            .ToContainer("Custumers")
            .HasPartitionKey(c => c.Id);

            modelBuilder.Entity<Custumer>().OwnsMany(c => c.Orders);
        }
    }
}