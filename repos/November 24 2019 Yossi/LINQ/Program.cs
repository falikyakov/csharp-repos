using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IceCream> IceCreams = new List<IceCream>
            {
                new IceCream{Description="Vanilla",Calories=200,Vitamins=20,Weight=99},
                new IceCream{Description="Choc",Calories=180,Vitamins=18,Weight=94},
                new IceCream{Description="Pistachio",Calories=240,Vitamins=52,Weight=93},
                new IceCream{Description="Strawberry",Calories=299,Vitamins=23,Weight=89},
                new IceCream{Description="Coffee",Calories=154,Vitamins=10,Weight=101},
            };

            var Healthy = from c in IceCreams
                          where c.Calories < 200
                          select c;

            var VeryHealthy = (from c in IceCreams
                          where c.Calories < 180
                          select c 
                          ).ToList<IceCream>();

            foreach (var item in Healthy)
            {
                Console.WriteLine(item.Description);
            }

            foreach (var item in VeryHealthy)
            {
                Console.WriteLine(item.Description);
            }








            Console.ReadLine();
        }
    }

    public class IceCream
    {
        public string Description { get; set; }
        public int Calories { get; set; }
        public int Vitamins { get; set; }
        public int Weight { get; set; }

    }
}
