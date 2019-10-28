using System.ComponentModel.DataAnnotations;

namespace HierarchyGUI.Models
{
    public class NumberedAF
    {
        [Key]
        public string Name { get; set; }
        public string Commander { get; set; }
        public string Location { get; set; }
        public string Majcom { get; set; }
        public string Motto { get; set; }
        public string Mission { get; set; }
        public int Size { get; set; }
    }
}
