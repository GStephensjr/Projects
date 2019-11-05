using HierarchyGUI.Models.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HierarchyGUI.Models.EFRepositories
{
    public class EFCredentialsRepository: ICredentialsRepository
    {
        private ApplicationDbContext context;
        public EFCredentialsRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Credential> Credentials => context.Credentials;
        
        public void deleteUser(Credential User)
        {
            Credential dbEntry = context.Credentials.FirstOrDefault(p => p == User);
            context.Credentials.Remove(dbEntry);
            context.SaveChanges();
        }

        public void saveUser(Credential User)
        {
            if (context.Credentials.Any(c=>c.UserName == User.UserName))
            {
                Credential dbEntry = context.Credentials
                .FirstOrDefault(p => p.UserName == User.UserName);
                if (dbEntry != null)
                {

                    dbEntry.UserName = User.UserName;
                    dbEntry.Password = User.Password;
                    dbEntry.Admin = User.Admin;
                }
            }
            else
            {
                context.Credentials.Add(User);
            }
            context.SaveChanges();
        }

    }
}
