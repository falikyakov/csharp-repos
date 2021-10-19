using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delete
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseAndNot(85412));
            

            Console.ReadLine();
        }

        public static string ReverseAndNot(int i)
        {
            string str = i.ToString();
            return $"{str.Reverse()}+{str}";
            
        }
    }
}
