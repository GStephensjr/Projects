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
        public IQueryable<Group> Groups => context.Groups;
        public IQueryable<HeadquartersAF> HeadquartersAF => context.HeadquartersAF;
        public IQueryable<Majcom> Majcoms => context.Majcoms;
        public IQueryable<NumberedAF> NumberedAFs => context.NumberedAFs;
        public IQueryable<Squadron> Squadrons => context.Squadrons;
        public IQueryable<Wing> Wings => context.Wings;

    }
}