using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flower
{
    class Flower : IComparable
    {
        public int StemLength { get; set; }
        public int AmntOfSeeds { get; set; }
        public int AmntOfPetals { get; set; }

     
        public int CompareTo(object obj)
        {
            Flower a=obj as Flower;
            int result = 0;
            if (this.AmntOfPetals > a.AmntOfPetals)
                result = 1;
            if (this.AmntOfPetals < a.AmntOfPetals)
                result = -1;



            return result;
        }
    }
}
