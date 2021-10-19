using ShabbatGuests.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShabbatGuests.ViewModel
{
    public class VMAddFood
    {
        public VMAddFood()
        {

        }

        public FoodCategory foodCategory { get; set; }
        public int CategoryId { get; set; }
        public List<FoodCategory>foodCategories  { get; set; }
        public Food food  { get; set; }
    } 
}
