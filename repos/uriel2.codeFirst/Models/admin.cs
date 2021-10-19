using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace uriel2.codeFirst.Models
{
    public class admin
    {
        [Key]
        public int Id { get; set; }
        public User user { get; set; }
        public string password { get; set; }
    }
}
