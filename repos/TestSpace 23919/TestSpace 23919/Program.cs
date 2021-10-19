using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSpace_23919
{
    class Program
    {
        static void Main(string[] args)
        {
            MyRectangle r = new MyRectangle(56,23);
            Console.WriteLine(r.x+" "+r.y);
          



            Console.ReadLine();
        }

       












    }
    class MyRectangle
    {
        public int x, y;
        public MyRectangle() : this(10, 5) { }
        public MyRectangle(int a) : this(a, a) { }
        public MyRectangle(int a, int b) { x = a; y = b; }
    }
}
