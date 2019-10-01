using System.ComponentModel.DataAnnotations;


namespace HierarchyGUI.Models
{
    public class Authentication
    {
        [Key]
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool Admin { get; set; } = false;
        //public string hashPassword = HashDirectory.Hash(Password);


    }
}
