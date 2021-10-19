using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace friend_method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value: ");
            string test = Console.ReadLine(); ;
            if (test.IsNumeric())
            {
                Console.WriteLine(test);
            }
            else
            {
                Console.WriteLine("no");


            }

             
            Console.ReadLine();
        }
    }

    public static class ExtensionMethod
    {
        public static bool IsNumeric(this string s)
        {
            float output;
            return float.TryParse(s,out output);
        }
    }


    class Car
    {
        public void Start()
        {

        }

        public void Stop()
        {

        }
    }
}
