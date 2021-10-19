using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace uriel2.codeFirst.Models
{
    public class Goals
    {
        public Goals()
        {

        }

        [Key]
        public int Id { get; set; }
        public User user { get; set; }

        public DateTime weekStartDate { get; set; }
        public DateTime weekEndDate { get; set; } 
        public int kgToLose { get; set; }
        public int excersizeMinutes { get; set; }
    }
}
