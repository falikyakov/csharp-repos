using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication4.Models.Business_Entities;

namespace WebApplication4.Models
{
    public class DisplayPizzas
    {
        public List<Pizza> PizzaList = new List<Pizza> {
        new Pizza{ID=1, Description="Mushroom",Image=@"C:\Users\Yanky\source\repos\WebApplication4\WebApplication4\Images\IMG_1179.JPG",Calories=545,TotalFats=150},
        new Pizza{ID=2, Description="Regular",Image=@"C:\Users\Yanky\source\repos\WebApplication4\WebApplication4\Images\IMG_1180.JPG",Calories=525,TotalFats=140},
        new Pizza{ID=3, Description="Olive",Image=@"C:\Users\Yanky\source\repos\WebApplication4\WebApplication4\Images\IMG_1181.JPG",Calories=575,TotalFats=177},
        new Pizza{ID=4, Description="Vegetable",Image=@"C:\Users\Yanky\source\repos\WebApplication4\WebApplication4\Images\IMG_1183.JPG",Calories=495,TotalFats=95},
        new Pizza{ID=5, Description="Extra Cheese",Image=@"C:\Users\Yanky\source\repos\WebApplication4\WebApplication4\Images\IMG_1184.JPG",Calories=645,TotalFats=250},
        new Pizza{ID=6, Description="Double",Image=@"C:\Users\Yanky\source\repos\WebApplication4\WebApplication4\Images\IMG_1185.JPG",Calories=795,TotalFats=290},
        };

        public void blah()
        {
            string.Format("blah");
        }

       
    }
}