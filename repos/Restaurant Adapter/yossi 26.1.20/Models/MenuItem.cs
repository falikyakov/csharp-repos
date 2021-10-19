using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace yossi_26._1._20.Models
{
    public class MenuItem
    {
        public int Id { get; set; }
        public int RestaurantId { get; set; }
        public string ImageUrl { get; set; }
    }
}