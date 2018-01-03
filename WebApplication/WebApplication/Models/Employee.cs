using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class Employee
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "First Name")]
        public string EmpFirstName { get; set; }

        [Display(Name = "Last Name")]
        public string EmpLastName { get; set; }

        [Display(Name = "Phone Number")]
        public string EmpPhone { get; set; }

        [Display(Name = "Email")]
        public string EmpEmail { get; set; }
    }
}