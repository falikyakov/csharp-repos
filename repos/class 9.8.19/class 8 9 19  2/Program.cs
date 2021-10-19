using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_8_9_19__2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 90;
            Console.WriteLine(x);
            Stam1(ref x);
            Console.WriteLine(x);
        }

        static void Stam1(ref int y)
        {
            y = 1111;
        }
    }
}
