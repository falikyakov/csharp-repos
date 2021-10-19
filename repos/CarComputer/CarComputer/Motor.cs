using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarComputer
{
    class Motor
    {
        public string Name { get; set; }
        public void OverheatAlert(string thisName,string str,int temp)
        {
            Console.WriteLine($"Attention {thisName}, the {str} has reached {temp}; need to lower temperature.");
        }

        public void SpeedChange(string carName, string spd, int speed)
        {
            Console.WriteLine($"Attention {carName}, the {spd} has changed to {speed}");
        }
    }
}
