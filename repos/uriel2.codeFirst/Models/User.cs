using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace uriel2.codeFirst.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Display(Name="First Name")]
        public string firstName { get; set; }

        [Display(Name = "Last Name")]
        public string lastName { get; set; }

        [Display(Name = "Date of Birth")]
        public DateTime dob { get; set; }

        [Display(Name ="Gender")]
        public bool gender { get; set; }

        [Display(Name = "Height")]
        public int heightCm { get; set; }

        [Display(Name = "Current Weight")]
        public double startWeight { get; set; }

        public decimal BMI { get; set; }

        [Display(Name = "Tel")]
        public string tel { get; set; }

        [Display(Name = "Cell")]
        public string cell { get; set; }

        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }

        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string password { get; set; }

        [Display(Name = "Confirm Password")]
        [Compare("password",ErrorMessage ="Confirm password does not match Password")]
        public string confirmPassword { get; set; }

        public DateTime entryDate { get; set; }

        public List<Goals> goals { get; set; }
        public List<dailyPlan> dailyPlans { get; set; }
        public List<dailyActual> dailyActuals { get; set; }
        public List<WeeklyUpdate> weeklyUpdates { get; set; }
        public List<WeightList> weightList { get; set; }

    }
}
 