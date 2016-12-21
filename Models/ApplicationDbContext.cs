using Microsoft.EntityFrameworkCore;

namespace ConferenceBarrel.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Conference> Conferences {get; set;}
        public DbSet<Session> Sessions {get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=./conberral2.db");
        }        
    }
}