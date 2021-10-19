using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_9._8._19
{
    class Program
    {
        static void Main(string[] args)
        {
            MyApp("Yanky", "Falik");
            //MyPrint("hello", "yello", "wello");
        }

        ///// <summary>
        /////  allows for array to be created (and ended) within function   
        ///// </summary>
        ///// <param name="s">allows for multiple parameters, instead of necessitating array</param>
        //static void MyPrint(params string[] s)
        //{
        //    foreach (string x in s) 
        //        System.Console.WriteLine(x);
        //}

        static void MyApp(string first, string last, string title = "Mr.")//makes the title with default, don't need to put in the param.
        {
            Console.WriteLine(title +" " +first +" "+ last);
        }
    }


}
