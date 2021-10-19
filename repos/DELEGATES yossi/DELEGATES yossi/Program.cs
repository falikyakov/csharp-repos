using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DELEGATES_yossi
{
    class Program
    {
        static void Main(string[] args)
        {
            Action x = SayHello;
            x();
            Work(x);

            Action y = SayHi;
            Work2(y, x);



            Console.ReadLine();
        }

        static void SayHello()
        {
            Console.WriteLine("Hi");
        }

        static void SayHi()
        {
            Console.WriteLine("Hi all");
        }

        static void Work(Action x)
        {
            x();
        }

        static void Work2(Action x, Action y)
        {
            x();
            y();
        }
    }

    //static delegate void 
}
