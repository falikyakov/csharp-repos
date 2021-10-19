using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_and_computer
{
    class Program
    {
        static void Main(string[] args)
        {
            IWork myNewComputer = new Computer();
            Operate(myNewComputer);

            IWork object1 = GetObject("i need a computer");
            Operate(object1);

            IWork object2 = GetObject("i need to drive to yerushalayim");
            Operate(object2);

            Console.ReadLine();
        }

        private static void Operate(IWork anything)
        {
            anything.Start();
            anything.Stop();
        }


        public static IWork GetObject(string x)
        {
            IWork result = null;

            if (x.Contains("drive"))
            {
                result = new Car();
            }
            if (x.Contains("compute"))
            {
                result = new Computer();
            }
            return result;


        }




    }

    class Car : IWork
    {
        public void Start()
        {
            Console.WriteLine("I am a car. I am starting");
        }


        public void Stop()
        {
            Console.WriteLine("Stop!!");
        }

        public void Parking()
        {
            Console.WriteLine("I am a car parking.");
        }
    }

    class Computer : IWork
    {
        public void Start()
        {
            Console.WriteLine("I am a computer. I am starting");
        }

        public void Stop()
        {
            Console.WriteLine("Stop!!");
        }

        public void Working()
        {
            Console.WriteLine("I am a computer working.");
        }
    }
}
