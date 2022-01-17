using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace otelUcusAppProject.Models
{
    public class userModel
    {

        public int id { get; set; }

        [Required(AllowEmptyStrings =false, ErrorMessage ="User name is required")]
        [Display(Name ="User Name")]
        public string username { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string u_password { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Confirm-Password is required")]
        [DataType(DataType.Password)]
        [Compare("u_password",ErrorMessage ="Password and Confirm-password should be same")]
        [Display(Name = "ConfirmPassword")]
        public string confirmPassword { get; set; }
        public int role_id { get; set; }

        public string successMessage { get; set; }
    }
}