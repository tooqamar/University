using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.ViewModel
{
    public class LoginModel
    {
       

       
        [Display(Name = " UserName:")]
        [Required]
        public string email { set; get; }


        [Display(Name = "Password")]
        [Required]
        [DataType(DataType.Password)]
        public string Password { set; get; }
    }
}
