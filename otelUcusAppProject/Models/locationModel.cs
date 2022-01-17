using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace otelUcusAppProject.Models
{
    public class locationModel
    {

        public int code { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Name is required")]
        [Display(Name ="Location Name")]
        public string name { get; set; }


        public string successMessage { get; set; }

    }
}