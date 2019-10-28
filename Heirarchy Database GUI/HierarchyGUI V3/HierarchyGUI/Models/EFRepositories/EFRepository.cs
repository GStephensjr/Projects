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

        public void saveEntry(HeadquartersAF entry)
        {
            if (context.HeadquartersAF.Any(c => c.StaffName == entry.StaffName))
            {
                HeadquartersAF dbEntry = context.HeadquartersAF
                .FirstOrDefault(p => p.StaffName == entry.StaffName);
                if (dbEntry != null)
                {
                    dbEntry.StaffName = entry.StaffName;
                    dbEntry.Location = entry.Location;
                    dbEntry.Commander = entry.Commander;
                    dbEntry.Mission = entry.Mission;
                    dbEntry.CommanderTitle = entry.CommanderTitle;
                }
            }
            else
            {
                context.HeadquartersAF.Add(entry);
            }
            context.SaveChanges();
        }
        public void saveEntry(Majcom entry)
        {
            if (context.Majcoms.Any(c => c.Name == entry.Name))
            {
                Majcom dbEntry = context.Majcoms
                .FirstOrDefault(p => p.Name == entry.Name);
                if (dbEntry != null)
                {
                    dbEntry.Name = entry.Name;
                    dbEntry.Location = entry.Location;
                    dbEntry.Commander = entry.Commander;
                    dbEntry.Mission = entry.Mission;
                    dbEntry.Size = entry.Size;
                    dbEntry.Motto = entry.Motto;
                }
            }
            else
            {
                context.Majcoms.Add(entry);
            }
            context.SaveChanges();
        }
        public void saveEntry(NumberedAF entry)
        {
            if (context.NumberedAFs.Any(c => c.Name == entry.Name))
            {
                NumberedAF dbEntry = context.NumberedAFs
                .FirstOrDefault(p => p.Name == entry.Name);
                if (dbEntry != null)
                {
                    dbEntry.Name = entry.Name;
                    dbEntry.Location = entry.Location;
                    dbEntry.Commander = entry.Commander;
                    dbEntry.Mission = entry.Mission;
                    dbEntry.Size = entry.Size;
                    dbEntry.Majcom = entry.Majcom;
                    dbEntry.Motto = entry.Motto;

                }
            }
            else
            {
                context.NumberedAFs.Add(entry);
            }
            context.SaveChanges();
        }
        public void saveEntry(Wing entry)
        {
            if (context.Wings.Any(c => c.Name == entry.Name))
            {
                Wing dbEntry = context.Wings
                .FirstOrDefault(p => p.Name == entry.Name);
                if (dbEntry != null)
                {
                    dbEntry.Name = entry.Name;
                    dbEntry.Location = entry.Location;
                    dbEntry.Commander = entry.Commander;
                    dbEntry.Mission = entry.Mission;
                    dbEntry.Size = entry.Size;
                    dbEntry.Motto = entry.Motto;

                }
            }
            else
            {
                context.Wings.Add(entry);
            }
            context.SaveChanges();
        }
        public void saveEntry(Group entry)
        {
            if (context.Groups.Any(c => c.Name == entry.Name))
            {
                Group dbEntry = context.Groups
                .FirstOrDefault(p => p.Name == entry.Name);
                if (dbEntry != null)
                {
                    dbEntry.Name = entry.Name;
                    dbEntry.Location = entry.Location;
                    dbEntry.Commander = entry.Commander;
                    dbEntry.Mission = entry.Mission;
                    dbEntry.Size = entry.Size;
                    dbEntry.Motto = entry.Motto;
                    dbEntry = entry;
                }
            }
            else
            {
                context.Groups.Add(entry);
            }
            context.SaveChanges();
        }
        public void saveEntry(Squadron entry)
        {
            if (context.Squadrons.Any(c => c.Name == entry.Name))
            {
                Squadron dbEntry = context.Squadrons
                .FirstOrDefault(p => p.Name == entry.Name);
                if (dbEntry != null)
                {
                    dbEntry.Name = entry.Name;
                    dbEntry.Location = entry.Location;
                    dbEntry.Commander = entry.Commander;
                    dbEntry.Mission = entry.Mission;
                    dbEntry.Size = entry.Size;
                    dbEntry.Motto = entry.Motto;
                    
                }
            }
            else
            {
                context.Squadrons.Add(entry);
            }
            context.SaveChanges();
        }

        public void deleteEntry(HeadquartersAF entry)
        {
            HeadquartersAF dbEntry = context.HeadquartersAF.FirstOrDefault(p => p == entry);
            context.HeadquartersAF.Remove(dbEntry);
            context.SaveChanges();
        }
        public void deleteEntry(Majcom entry)
        {
            Majcom dbEntry = context.Majcoms.FirstOrDefault(p => p == entry);
            context.Majcoms.Remove(dbEntry);
            context.SaveChanges();
        }
        public void deleteEntry(NumberedAF entry)
        {
            NumberedAF dbEntry = context.NumberedAFs.FirstOrDefault(p => p == entry);
            context.NumberedAFs.Remove(dbEntry);
            context.SaveChanges();
        }
        public void deleteEntry(Wing entry)
        {
            Wing dbEntry = context.Wings.FirstOrDefault(p => p == entry);
            context.Wings.Remove(dbEntry);
            context.SaveChanges();
        }
        public void deleteEntry(Group entry)
        {
            Group dbEntry = context.Groups.FirstOrDefault(p => p == entry);
            context.Groups.Remove(dbEntry);
            context.SaveChanges();
        }
        public void deleteEntry(Squadron entry)
        {
            Squadron dbEntry = context.Squadrons.FirstOrDefault(p => p == entry);
            context.Squadrons.Remove(dbEntry);
            context.SaveChanges();
        }

    }
}