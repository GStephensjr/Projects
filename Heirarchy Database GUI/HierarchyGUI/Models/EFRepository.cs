using System.Linq;

namespace HierarchyGUI.Models
{
    public class EFRepository : IRepository
    {
        private ApplicationDbContext context;
        public EFRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Authentication> getAuthentication => context.getAuthentication;
        public IQueryable<Group> getGroup => context.getGroup;
        public IQueryable<HeadquartersAF> getHeadquartersAF => context.getHeadquartersAF;
        public IQueryable<Majcom> getMajcom => context.getMajcom;
        public IQueryable<NumberedAF> getNumberedAF => context.getNumberedAF;
        public IQueryable<Squadron> getSquadron => context.getSquadron;
        public IQueryable<Wing> getWing => context.getWing;

    }
}