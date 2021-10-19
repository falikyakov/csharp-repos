using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarComputer
{
    class Gears
    {
        public string Name { get; set; }
        public void SpeedChange(string carName, string spd, int speed)
        {
            Console.WriteLine($"Attention {carName}, the {spd} has changed to {speed}; neeed to switch gears.");
        }
    }
}
