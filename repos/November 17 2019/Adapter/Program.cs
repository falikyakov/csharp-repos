using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone p = new PhoneCharger();
            p.Charge5v();


            Console.Read();
        }
    }
}
