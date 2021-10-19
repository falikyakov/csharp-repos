using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace November_10_2019
{
    public enum Trend
    {
        Up,Down
    }
    class Broker
    {
        public string  Description { get; set; }
        public void GetNewValue(float value,string StockName, Trend trend)
        {
            Console.WriteLine($"At {Description} we know that {StockName} value is: {value.ToString()}, and it is going {trend}");
        }

    }
}
