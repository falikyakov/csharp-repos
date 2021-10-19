using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication4.Models.Business_Entities
{
    public class Pizza
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int Calories { get; set; }
        public int TotalFats { get; set; }

        public Pizza()
        {

        }
    }
}