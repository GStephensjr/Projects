using System.Linq;

namespace HierarchyGUI.Models
{
    public interface IRepository
    {
        IQueryable<Credential> Credentials { get; }
        IQueryable<Group> Groups { get; }
        IQueryable<HeadquartersAF> HeadquartersAF { get; }
        IQueryable<Majcom> Majcoms { get; }
        IQueryable<NumberedAF> NumberedAFs { get; }
        IQueryable<Squadron> Squadrons { get; }
        IQueryable<Wing> Wings { get; }
    }
}
