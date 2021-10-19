using ShabbatGuests.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShabbatGuests.ViewModel
{
    public class VMHostMain
    {
        public VMHostMain()
        {

        }

        public List<FoodCategory> foodCategories;

        public List<Guest> guests;

        public List<FoodToGuest> foodsToGuest;
    }
}
