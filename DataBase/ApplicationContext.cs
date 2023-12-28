using Microsoft.EntityFrameworkCore;
using TopRankAPI.Entities;
using Npgsql.EntityFrameworkCore.PostgreSQL;



namespace TopRankAPI.DataBaseInstructions
{
    public class ApplicationContext : DbContext
    {
        public DbSet<RankItem> RankItems { get; set; } = null!;
        public ApplicationContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=db;Port=5432;Database=postgres;Username=postgres;Password=verter");
        }
        
    }

}

