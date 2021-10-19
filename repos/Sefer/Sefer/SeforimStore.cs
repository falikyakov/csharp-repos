using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sefer
{
    class SeforimStore
    {
        public string  Name { get; set; }

        public void Update(string name,float value)
        {
            Console.WriteLine($"Attention: At {this.Name}, the price of {name}" +
                $" has been set to {value}");
        }
    }
}
