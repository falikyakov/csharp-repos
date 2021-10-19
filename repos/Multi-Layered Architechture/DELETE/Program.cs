using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DELETE
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack myStack = new Stack();

            myStack.Push(10+" (FIRST IN LINE)");
            myStack.Push(11);
            myStack.Push(22);
            myStack.Push(33);
            myStack.Push(44);
            myStack.Push(11);
            myStack.Push(22);
            myStack.Push(33);
            myStack.Push(44);
            myStack.Push(4.6589);
            myStack.Push(66+" (LAST IN LINE)");

            foreach (var item in myStack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("peek function shows the LAST one in: "+myStack.Peek());
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Pop method. Item being popped: " + myStack.Pop());

            Console.WriteLine("-----------------------------------------------");

            foreach (var item in myStack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----------------------------------------------");

            Console.WriteLine("Contain function... Stack contains 33 == "+myStack.Contains(33));
            Console.WriteLine("Contain function... Stack contains 55 == " + myStack.Contains(55));

            Console.WriteLine("-----------------------------------------------");

            Console.WriteLine("Clear method: clears entire stack.");
            myStack.Clear();
            Console.WriteLine("Attempting to retrieve stack items...");
            foreach (var item in myStack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Thread.Sleep(2500);

            Console.WriteLine("Stack contains no items.");











            Console.Read();
        }
    }
}
