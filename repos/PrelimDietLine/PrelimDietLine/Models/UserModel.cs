using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PrelimDietLine.Models
{
    public class UserModel
    {
        [Display(Name ="First Name")]
        [Required(ErrorMessage ="You must enter a first name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "You must enter a last name")]
        public string LastName { get; set; }

        [Display(Name ="Date of Birth")]
        [Required(ErrorMessage = "This information is necessary for your diet plan")]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Height (cm)")]
        [Required(ErrorMessage = "This information is necessary for your diet plan")]
        public double Height { get; set; }

        [Display(Name = "Weight (kg)")]
        [Required(ErrorMessage = "This information is necessary for your diet plan")]
        public double Weight { get; set; }

        [Display(Name ="Married")]
        public bool IsMarried { get; set; }
        public float BMI { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name ="Email Address")]
        [Required(ErrorMessage = "This is a required field")]
        public string EmailAddress { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "Confirm Email Address")]
        [Compare("EmailAddress",ErrorMessage ="The Email and Confirm Email must match")]
        public string ConfirmEmailAddress { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "This is a required field")]
        [StringLength(100,MinimumLength =8,ErrorMessage ="Minimum 8 charachters, Maximum 100")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password",ErrorMessage ="Confirm Password does not match the Password")]
        public string ConfirmPassword { get; set; }

    } 
}