using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShabbatGuests.Models
{
    public class FoodToGuest
    {
        [Key]
        public int Id { get; set; }

        public Food food { get; set; }

        public Guest guest { get; set; }


    }
}
