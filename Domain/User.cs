using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MySite_MVC.Domain
{
    public class User
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "User Name")]
        [Required(ErrorMessage = "Please enter user name!")]
        public string Name { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Please enter password!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
