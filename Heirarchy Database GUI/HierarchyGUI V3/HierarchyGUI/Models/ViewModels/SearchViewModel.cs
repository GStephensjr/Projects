using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HierarchyGUI.Models.ViewModels
{
    public class SearchViewModel
    {

        public SearchViewModel(string? query, IRepository context)
        {
            //Results.Add("HeadquartersAF",
            ////Name = context.HeadquartersAF.Where(p => p.StaffName.Contains(query) || p.Commander.Contains(query) || p.CommanderTitle.Contains(query) || p.Location.Contains(query) || p.Mission.Contains(query)).Select(p => p.StaffName)
            //context.HeadquartersAF.FirstOrDefault(p => p.StaffName.Contains(query)).ToString()

            //);
        Dictionary<string?, string?> Results = new Dictionary<string?, string?>();

        //Results.Add(
        //        "Majcom",
        //        context.Majcoms.FirstOrDefault(p => p.Name.Contains(query)).Name

            //Name = context.Majcoms.Where(p => p.Name.Contains(query) || p.Commander.Contains(query) || p.Location.Contains(query) || p.Motto.Contains(query) || p.Mission.Contains(query) || p.Size.ToString().Contains(query)).Select(p=>p.Name)
        //    );
            
        }
    }
}
