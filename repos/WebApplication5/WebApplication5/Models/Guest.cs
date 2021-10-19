using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShabbatGuests.Models
{
    public class Guest
    {
        public Guest()
        {
            foods = new List<FoodToGuest>();
        }

        [Key]
        public int Id { get; set; }

        [Display(Name ="First Name")]
        public string firstName { get; set; }

        [Display(Name = "Last Name")]
        public string lastName { get; set; }

        public string fullName
        {
            get
            {
                return firstName + " " + lastName;
            }
        }

        [Display(Name = "Tel")]
        public string Tel { get; set; }

        [Display(Name = "Image")]
        public byte[] image { get; set; }

        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage ="Please enter valid email address")]
        public string email { get; set; }

        public List<FoodToGuest> foods { get; set; }


        public IFormFile SetImage
        {
            set
            {
                image = new ImageConverter().GetImage(value);
            }
        }

        public void AddFood(Food food)
        {
            foods.Add(new FoodToGuest { food = food, guest = this });
        }
    }
}
