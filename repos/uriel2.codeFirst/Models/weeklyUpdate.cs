using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace uriel2.codeFirst.Models
{
    public class WeeklyUpdate
    {
        public WeeklyUpdate()
        {

        }

        [Key]
        public int Id { get; set; }

        public User user { get; set; }


        public List<WeightList> weightList { get; set; }

        public double newWeightKg { get; set; }

        public DateTime insertDate { get; set; }
    }
}
  