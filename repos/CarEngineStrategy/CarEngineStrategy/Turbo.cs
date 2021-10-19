using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarEngineStrategy
{
    class Turbo : ICarEngine
    {
        public void Idle()
        {
            Console.WriteLine("Turbo engine is idle.");
        }

        public void On()
        {
            Console.WriteLine("Turbo engine is running.");
        }
    }
}
