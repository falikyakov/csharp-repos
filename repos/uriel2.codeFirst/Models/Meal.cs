using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace uriel2.codeFirst.Models
{
    public class Meal
    {
        public Meal()
        {
           
        }

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Food> Foods { get; set; }

        public int TotalCalories { get; set; }
    } 
}
