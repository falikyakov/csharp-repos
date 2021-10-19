using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShabbatGuests.Models
{
    public class Food
    {
        public Food()
        {

        }

        [Key]
        public int Id { get; set; }


        [Display(Name = "Name")]
        public string name { get; set; }


        [Display(Name = "Category")]
        public FoodCategory category { get; set; }

        [Display(Name = "Image")]
        public byte[] image { get; set; }


        public IFormFile SetImage
        {
            set
            {
                image = new ImageConverter().GetImage(value);
            }
        }
    }
}
