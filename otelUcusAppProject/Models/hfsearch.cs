using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace otelUcusAppProject.Models
{
    public class hfsearch
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Service type is Required")]
        [Display(Name = "Service Tpye")]
        public ServicesType services_type { get; set; }

        [Display(Name = "Begin Date")]
        [DisplayFormat(DataFormatString ="{0:dd-MMM-yyyy}",ApplyFormatInEditMode = true)]
        public DateTime begin_date { get; set; }

        [Display(Name ="End Date")]
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime end_date { get; set;}

        [Display(Name ="Location")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Location is required")]
        public int code { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "Arrival Location is Required")]
        [Display(Name = "Arrivail Location")]
        public int codearrival { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Count Adult is Required")]
        [Display(Name = "Count Adult")]
        public int countAdult { get; set; }

        
        [Display(Name = "Count Child")]
        public decimal countChild { get; set; }



    }
}