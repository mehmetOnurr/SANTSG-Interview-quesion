using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace otelUcusAppProject.Models
{
    public class loginModel
    {
        [Required(ErrorMessage ="User Name is Required")]
        [Display(Name ="User Name")]
        public string user_name { get; set; }

        [Required(ErrorMessage = "Password is Required")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string password { get; set; }
    }
}