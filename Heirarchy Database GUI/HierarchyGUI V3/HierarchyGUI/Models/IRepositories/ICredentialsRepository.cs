using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HierarchyGUI.Models.IRepositories;


namespace HierarchyGUI.Models.IRepositories
{
    public interface ICredentialsRepository
    {
        IQueryable<Credential> Credentials { get; }
        void saveUser(Credential User);

    }
}
