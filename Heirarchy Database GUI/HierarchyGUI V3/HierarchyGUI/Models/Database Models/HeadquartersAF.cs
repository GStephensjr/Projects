using System.ComponentModel.DataAnnotations;

namespace HierarchyGUI.Models
{
    public class HeadquartersAF
    {
        [Key]
        public string StaffName { get; set; }
        public string Location { get; set; }
        public string Commander { get; set; }
        public string Mission { get; set; }
        public string CommanderTitle { get; set; }
    }
}
