using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//singleton = letting a class be instantiated only once.

namespace Nov_3_2019_Yossi_Zaguri
{
    class Program
    {
        static void Main(string[] args)
        {
            NuclearCore nc = NuclearCore.GetObject();
            NuclearCore nc1 = NuclearCore.GetObject();
            //NuclearCore nc2 = new NuclearCore();
            //NuclearCore nc1 =new NuclearCore();

            Console.WriteLine(nc.GetHashCode());
            Console.WriteLine(nc1.GetHashCode());


            Console.ReadKey();
        }
    }


    class NuclearCore
    {
        private static NuclearCore CurrentCore = null;
        private NuclearCore()
        {

        }

        public static NuclearCore GetObject()
        {
            if (CurrentCore==null)
            {
                CurrentCore = new NuclearCore();
            }
            return CurrentCore;
        }
    }
}
