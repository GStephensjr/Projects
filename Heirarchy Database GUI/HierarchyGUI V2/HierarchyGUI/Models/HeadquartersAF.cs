using System.ComponentModel.DataAnnotations;

namespace HierarchyGUI.Models
{
    public class HeadquartersAF
    {
        [Key]
        public string Name { get; set; }
        public string SecAF { get; set; }
        public string ChiefOfStaff { get; set; }
    }
}
