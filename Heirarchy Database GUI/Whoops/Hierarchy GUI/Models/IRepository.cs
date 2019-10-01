using System.Linq;

namespace Hierarchy_GUI.Models
{
    public interface IRepository
    {
        IQueryable<Authentication> getAuthentication { get; }
        IQueryable<Group> getGroup { get; }
        IQueryable<HeadquartersAF> getHeadquartersAF { get; }
        IQueryable<Majcom> getMajcom { get; }
        IQueryable<NumberedAF> getNumberedAF { get; }
        IQueryable<Squadron> getSquadron { get; }
        IQueryable<Wing> getWing { get; }
    }
}
