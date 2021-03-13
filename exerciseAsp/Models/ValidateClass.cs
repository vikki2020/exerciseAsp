using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace exerciseAsp.Models
{
    public class ValidateClass
    {
        [Required]
        [Display(Name ="Enter User Name")]
        [StringLength(maximumLength:7,MinimumLength =3,ErrorMessage ="User name must have max length 7 and min length 3")]
        public string Username { get; set; }

        [Required]
        [Display(Name ="Enter Age")]
        [Range(18,100,ErrorMessage ="Age must be Between 18 and 100")]
        public int Age { get; set; }

        [Required]
        [Display(Name ="Enter Email")]
        [EmailAddress(ErrorMessage ="Enter The Proper Email Address!")]
        public string Email { get; set; }

        [Required]
        [Display(Name ="Enter Password")]
        [DataType(DataType.Password)]
        [RegularExpression("^(?=.*[A-Za-z])(?=.*\\d)[A-Za-z\\d]{8,}$", ErrorMessage ="Password Must Contain atleast 8 characters and must have 1 alphabet and 1 number")]
        public string Password { get; set; }

        [Required]
        [Display(Name ="Ente password again")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string RePassword { get; set; }

        //[Required]
        //[Display(Name ="Agree with Terms & Conditions")]
        //[Range(typeof(bool),"true","true",ErrorMessage = "Please confirm the Terms & Conditions before registration.")]
        public bool TermsNConditions { get; set; }
    }
}