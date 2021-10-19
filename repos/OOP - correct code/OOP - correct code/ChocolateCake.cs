using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___correct_code
{
    class ChocolateCake : CakeMaker
    {
        public ChocolateCake(string name)
        {
            base.Name = name;
        }
        public override void Decorate()
        {
            Console.WriteLine("Decorate with icing and sprinkles.");
        }

        public override void GetProduct()
        {
            Console.WriteLine("Get chocolate, butter, eggs and flour.");
        }

        public override void MixProduct()
        {
            Console.WriteLine("Melt chocolate.\nAdd butter and eggs.\nMix with flour.");
        }

        public override void PutInOven()
        {
            Console.WriteLine("Bake in oven at 175c for 25 min.");
        }
    }
}
