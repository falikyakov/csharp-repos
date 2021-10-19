﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace uriel2.codeFirst.Models
{
    public class WeightList
    {
        public WeightList()
        {

        }

        [Key]
        public int Id { get; set; }

        public User user { get; set; }

        public double weight { get; set; } 
    }
}
