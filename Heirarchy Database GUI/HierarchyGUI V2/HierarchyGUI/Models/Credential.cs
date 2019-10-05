using System.ComponentModel.DataAnnotations;

namespace HierarchyGUI.Models
{
    public class Credential
    {
        [Key]
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool Admin { get; set; } = false;

        //[Table("tblUser")]
        //public class tblUser
        //{
        //    [Key]
        //    [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        //    public int UserID { get; set; }
        //    public string UserName { get; set; }
        //    public string Password { get; set; }
        //}


    }
}
