using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace uriel2.codeFirst.Models
{
    public class dailyActual
    {
        public dailyActual()
        {

        }

        [Key]
        public int Id { get; set; }
        public User user { get; set; }

        public Goals goal { get; set; }
        public dailyPlan dailyPlanned { get; set; } 

        public Meal Breakfast { get; set; }
        public Meal Lunch { get; set; }
        public Meal Dinner { get; set; }
        public Meal Snacks { get; set; }

        public int totalCalories { get; set; }

        public int excersizeMinutes { get; set; }
    }
}
