using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HierarchyGUI.Models.Database_Models
{
    public class Aggregate
    {
        public HeadquartersAF HAF { get; set; }
        public Majcom MAJ { get; set; }
        public NumberedAF NAF { get; set; }
        public Wing WNG { get; set; }
        public Group GRP { get; set; }
        public Squadron SQD { get; set; }
    }
}
