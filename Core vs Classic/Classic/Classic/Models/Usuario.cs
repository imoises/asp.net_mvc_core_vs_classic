using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Classic.Models
{
    public class Usuario
    {
        [Required]
        [Display(Name = "Ingrese Email")]
        [EmailAddress(ErrorMessage = "Ingrese un Email valido")]
        public String Email { get; set; }
        [Required]
        [Display(Name = "Ingrese Password")]
        public String Password { get; set; }
    }
}