using Microsoft.EntityFrameworkCore;

namespace HierarchyGUI.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }
        public DbSet<Credential> Credentials { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<HeadquartersAF> HeadquartersAF { get; set; }
        public DbSet<Majcom> Majcoms { get; set; }
        public DbSet<NumberedAF> NumberedAFs { get; set; }
        public DbSet<Squadron> Squadrons { get; set; }
        public DbSet<Wing> Wings { get; set; }

    }
}