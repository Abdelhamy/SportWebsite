using DAL.Entities;
using Microsoft.EntityFrameworkCore;
namespace DAL
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions dbContextOptions):base(dbContextOptions)
        {
        }

        public DbSet<Tournament> Tournaments { get; set; }
        public DbSet<Team> Teams { get; set; }

        public DbSet<Player> Players { get; set; }


    }
}
