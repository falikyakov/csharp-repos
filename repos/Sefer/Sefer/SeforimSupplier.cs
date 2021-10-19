using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sefer
{
    class SeforimSupplier
    {
        public string Name { get; set; }
        public SeforimSupplier(string name)
        {
            this.Name = name;
        }
        public void Update(string seferName, float price)
        {
            Console.WriteLine($"Attention {this.Name}, a new edition of {seferName} has come out");
        }
    }
}
