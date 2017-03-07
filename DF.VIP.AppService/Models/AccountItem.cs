using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DF.VIP.AppService.Models
{
  
    public class LoginItem
    {
        [Required(ErrorMessage = "*")]
        public string LoginPhone { get; set; }
        [Required(ErrorMessage = "*")]
        public string Password { get; set; }
       
    }
    public class RegisterItem
    {
        [Required(ErrorMessage ="*")]
        public string RegisterPhone { get; set; }
        [Required(ErrorMessage = "*")]
        public string Password1 { get; set; }
        [Required(ErrorMessage = "*")]
        public string Password2 { get; set; }
    }
    public class ForgetPasswordItem
    {
        [Required(ErrorMessage = "*")]
        public string ForgetPasswordPhone { get; set; }

    }
}