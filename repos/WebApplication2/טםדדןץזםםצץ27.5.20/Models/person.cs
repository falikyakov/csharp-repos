using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace טםדדןץזםםצץ27._5._20.Models
{
    public class person
    {
        public int ID { get; set; }
        [Required(ErrorMessage ="Walla, you gotta write something!")]
        public string Name { get; set; }
        [Range(5,55)]
        public int Age { get; set; }
    }
}