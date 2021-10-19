using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShabbatGuests.Models
{
    public class FoodCategory
    {
        [Key]
        public int Id { get; set; }


        [Display(Name="Name")]
        public string name { get; set; }


        [Display(Name = "Image")]
        public byte[] image { get; set; }


        public List<Food> foods { get; set; }


        public IFormFile SetImage
        {
            set
            {
                image = new ImageConverter().GetImage(value);
            }
        }


        public void AddFood(string name, IFormFile file)
        {
            AddFood(new Food { name=name,SetImage=file});
        }


        public void AddFood(Food food)
        {
            foods.Add(food);
            food.category = this;
        }


    }
}
