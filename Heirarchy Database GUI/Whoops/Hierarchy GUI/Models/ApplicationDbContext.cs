using Microsoft.EntityFrameworkCore;


namespace Hierarchy_GUI.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }
        public DbSet<Authentication> getAuthentication { get; set; }
        public DbSet<Group> getGroup { get; set; }
        public DbSet<HeadquartersAF> getHeadquartersAF { get; set; }
        public DbSet<Majcom> getMajcom { get; set; }
        public DbSet<NumberedAF> getNumberedAF { get; set; }
        public DbSet<Squadron> getSquadron { get; set; }
        public DbSet<Wing> getWing { get; set; }

    }
}