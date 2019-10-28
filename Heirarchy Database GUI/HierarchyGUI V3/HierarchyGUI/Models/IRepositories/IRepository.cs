using System.Linq;

namespace HierarchyGUI.Models
{
    public interface IRepository
    {
        IQueryable<Group> Groups { get; }
        IQueryable<HeadquartersAF> HeadquartersAF { get; }
        IQueryable<Majcom> Majcoms { get; }
        IQueryable<NumberedAF> NumberedAFs { get; }
        IQueryable<Squadron> Squadrons { get; }
        IQueryable<Wing> Wings { get; }

        public void saveEntry(Group entry);
        public void saveEntry(HeadquartersAF entry);
        public void saveEntry(Majcom entry);
        public void saveEntry(NumberedAF entry);
        public void saveEntry(Squadron entry);
        public void saveEntry(Wing entry);

        public void deleteEntry(HeadquartersAF entry);
        public void deleteEntry(Group entry);
        public void deleteEntry(Majcom entry);
        public void deleteEntry(NumberedAF entry);
        public void deleteEntry(Squadron entry);
        public void deleteEntry(Wing entry);

    }
}
