using System.ComponentModel.DataAnnotations;


namespace HierarchyGUI.Models
{
    public class Group
    {
        [Key]
        public string Name { get; set; }
        public string Commander { get; set; }
        public string Location { get; set; }
        public string Motto { get; set; }
        public string Mission { get; set; }
        public int Size { get; set; }
    }
}


