using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class Location
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "Location")]
        public string LocationName { get; set; }

        [Display(Name = "Street Address")]
        public string LocationStreetAddress { get; set; }

        [Display(Name = "City")]
        public string LocationCity { get; set; }

        [Display(Name = "State")]
        public string LocationState { get; set; }

        [Display(Name = "Zip Code")]
        [DataType(DataType.PostalCode, ErrorMessage = "Must be 5 characters.")]
        public string LocationZipCode { get; set; }
    }
}