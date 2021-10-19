using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;
#if false
           
            Console.WriteLine("{0}", dt);
            Console.Write("Year: ");
            Console.WriteLine("{0:yyyy}",dt);
            Console.Write("Month: ");
            Console.WriteLine("{0:M MM MMM MMMM}",dt);
            Console.Write("Day: ");
            Console.WriteLine("{0:d dd ddd dddd}",dt);
            Console.Write("Hour: ");
            Console.WriteLine("{0:h hh H HH}",dt);
            Console.Write("Seconds: ");
            Console.WriteLine("{0:s ss}",dt);
            Console.Write("AM PM: ");
            Console.WriteLine("{0:t tt ttt}",dt);
            Console.Write("Timezone: ");
            Console.WriteLine("{0:z zz zzz zzzz}", dt);

#endif
#if true 
            Console.Write("Short time: ");
            Console.WriteLine("{0:t}",dt);
            Console.Write("Long time: ");
            Console.WriteLine("{0:T}",dt);
            Console.Write("Short date: ");
            Console.WriteLine("{0:d}", dt);
            Console.Write("Long Date: ");
            Console.WriteLine("{0:D}", dt);
            Console.Write("Long date + Short time: ");
            Console.WriteLine("{0:f}", dt);
            Console.Write("Long date + Short time: ");
            Console.WriteLine("{0:F}", dt);
            Console.Write("Short date + Short time: ");
            Console.WriteLine("{0:g}", dt);
            Console.Write("Short date + Long time: ");
            Console.WriteLine("{0:G}", dt);



#endif
            Console.ReadLine();
        }


    }
}
