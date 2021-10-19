using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DELEGATES_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Stam newDel = Calc;
            Console.WriteLine(newDel("5","4"));

            Stam1 new2 = What;
            new2("asdfgh");
            new2 += What;
            new2 += What;
            new2("qwerky");
           

            Console.ReadLine();
        }

        static int Calc(string x, string z)
        {
            return Convert.ToInt32(x)+Convert.ToInt32(z);
        }

        static void What(string x)
        {
            Console.WriteLine(x);
        }


    }

    public delegate int Stam(string x, string y);
    public delegate void Stam1(string s);
}
