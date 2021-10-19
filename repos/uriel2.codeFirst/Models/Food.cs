using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace uriel2.codeFirst.Models
{
    public class Food
    {
        public Food()
        {

        }

        [Key]
        public int Id { get; set; }
        public string Item { get; set; }
        public int Calories { get; set; }
    }
}
