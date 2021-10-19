using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarEngineStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            //Car c = new Car(new Turbo());
            //c.On();
            //c.Idle();

            Car d = new Car(new Regular());
            d.On();
            d.Idle();


            Console.Read();
        }
    }
}
