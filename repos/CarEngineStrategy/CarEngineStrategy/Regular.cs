using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarEngineStrategy
{
    class Regular : ICarEngine
    {
        public void Idle()
        {
            Console.WriteLine("Regular engine is idle.");
        }

        public void On()
        {
            Console.WriteLine("Regular engine is running.");
        }
    }
}
