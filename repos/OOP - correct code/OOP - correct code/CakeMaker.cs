using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___correct_code
{
    abstract class CakeMaker
    {
        public string Name;
        public abstract void GetProduct();
        public abstract void MixProduct();
        public abstract void PutInOven();
        public abstract void Decorate();
         
        public void Make(string CakeName)
        {
            Console.WriteLine("To bake a {0}:",CakeName);
            GetProduct();
            MixProduct();
            PutInOven();
            Decorate();
        }


    }
}
