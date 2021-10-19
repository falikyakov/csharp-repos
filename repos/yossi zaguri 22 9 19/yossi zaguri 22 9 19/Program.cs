using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yossi_zaguri_22_9_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car(767);
            c.Owner = "Yanky";
            Console.WriteLine(c.ToString());
            c.Accelerate();
            Console.WriteLine(c.ToString());
        }
      

    }


   
}
