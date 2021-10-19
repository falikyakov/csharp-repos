using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace read.א.מ
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dir = File.ReadAllLines(@"C:\Users\Yanky\Desktop\yisroTest.txt");

            List<string> newList = new List<string>();
            foreach (var item in dir)
            {
                newList.Add(item);
            }

           

            //for (int i = 0; i < dir.Length; i++)
            //{
            //    Console.OutputEncoding = Encoding.GetEncoding("Windows-1255");

            //    Console.WriteLine(i + " " + dir[i]);
            //}

            Console.ReadLine();
        }
    }
}
