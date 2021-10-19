using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now.AddDays(-1);
        //    Console.WriteLine("{0}", dt);
        //    Console.Write("Year: ");
        //    Console.WriteLine("{0:yyyy}", dt);
        //    Console.Write("Month: ");
        //    Console.WriteLine("{0:M MM MMM MMMM}", dt);
        //    Console.Write("Day: ");
        //    Console.WriteLine("{0:d dd ddd dddd}", dt);
        //    Console.Write("Hour: ");
        //    Console.WriteLine("{0:h hh H HH}", dt);
        //    Console.Write("Seconds: ");
        //    Console.WriteLine("{0:s ss}", dt);
        //    Console.Write("AM PM: ");
        //    Console.WriteLine("{0:t tt ttt}", dt);
        //    Console.Write("Timezone: ");
        //    Console.WriteLine("{0:z zz zzz zzzz}", dt);
            Console.WriteLine(dt.Month.ToString());

            Console.ReadLine();
        }
    }

    class family
    {
        string Name;
        int Age;

    }
}
