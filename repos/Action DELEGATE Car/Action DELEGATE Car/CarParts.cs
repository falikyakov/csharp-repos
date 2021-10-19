using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Action_DELEGATE_Car
{
    enum Trend
    {
        Up,Down,TooLow, TooHigh
    }
    class CarParts
    {
        public string Name;
        public void NotifyMe(int val,string nam,Trend tr)
        {
            Console.WriteLine($"DSD {val} khj{nam }nljbljb {tr}");
        }

    }
}
