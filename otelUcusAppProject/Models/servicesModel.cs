using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace otelUcusAppProject.Models
{
    public enum ServicesType
    {
        Hotel,
        Flight
    }
    public class servicesModel
    {


        [Required(AllowEmptyStrings = false,ErrorMessage ="Service type is Required")]
        [Display(Name ="Service Tpye")]
        public ServicesType services_type { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Service name is Required")]
        [Display(Name = "Service Name")]
        public string services_name { get; set;}

        [Required(AllowEmptyStrings = false, ErrorMessage = "location is Required")]
        [Display(Name = "Location(Hotel or Departure flight)")]
        public int location { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "location is Required")]
        [Display(Name = "Location(Hotel or Departure flight)")]
        public int code { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Arrivail Location is Required")]
        [Display(Name = "Arrivail Location")]
        public int locationarrivail { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Arrival Location is Required")]
        [Display(Name = "Arrivail Location")]
        public int codearrival { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Capacity is Required")]
        [Display(Name = "Capacity")]
        public int capacity { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Price per adult is Required")]
        [Display(Name = "Price Per Adult")]
        public double pricePerAdult { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Price per child is Required")]
        [Display(Name = "Price Per Child")]
        public double pricePerChild { get; set; }

        public string successMessage { get; set; }

       


    }
}