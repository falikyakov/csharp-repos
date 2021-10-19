using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flower
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Flower> FlowerList = new List<Flower> {
                new Flower{ StemLength=30, AmntOfSeeds=250,AmntOfPetals=24},
                new Flower{ StemLength=28, AmntOfSeeds=250,AmntOfPetals=29},
                new Flower{ StemLength=33, AmntOfSeeds=250,AmntOfPetals=18},
            };

            FlowerList.Sort();//sort now uses the CompareTo function from IComparable
            foreach (Flower item in FlowerList)
            {
                Console.WriteLine(item.StemLength+" "+item.AmntOfSeeds+" "+item.AmntOfPetals);
            }




            Console.Read();
        }
    }
}
