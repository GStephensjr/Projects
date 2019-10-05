using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClassManagerRazor.Pages.Models
{
    public class Student
    {
        [Required]
        public string ID { get; set; }

        public string fName { get; set; }
        public string mName { get; set; }
        public string lName { get; set; }
        public string eMail { get; set; }
        public string gitHub { get; set; }
        public string linkedIn { get; set; }
    }
}