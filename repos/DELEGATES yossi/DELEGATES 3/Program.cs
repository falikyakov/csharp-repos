using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DELEGATES_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Car Car1 = new Car(75);
           
            Console.WriteLine(Car1.Speed);
            StepOnIt(Car1);
            StepOnIt(Car1);
            StepOnIt(Car1);
            StepOnIt(Car1);
            StepOnIt(Car1);
            StepOnIt(Car1);
            StepOnIt(Car1);
            StepOnIt(Car1);

            Console.ReadLine();
        }

        private static void StepOnIt(Car Car1)
        {
            Car1.Accelerate();
            Console.WriteLine(Car1.Speed);
            if (Car1.Speed < 100)
                Car1.Warning = CallParents;
            else Car1.Warning = CallPolice;
        }

        static void CallParents()
        {
            Console.WriteLine("Driving too fast. Calling your parents!");
        }

        static void CallPolice()
        {
            Console.WriteLine("Calling Police. You're way too fast");
        }
    }

    class Car
    {
        public Action Warning;
        public int Speed { get; set; }

        public void Accelerate()
        {
            Speed += 5;
            if ((Speed <= 100) && (Speed>79)&&(Warning != null))
            {
                Warning();
            }
            if ((Speed>100)&&(Warning!=null))
            {
                Warning();
            }
        }

        public Car(int speed)
        {
            this.Speed = speed;
        }
    }
}

/*
       CLASS   'HOUSE'
    sensor - break-in
    sensor-smoke
    function shows temp.
    function ups the temp.
    if over 80c there's smoke,need to call fire dept. and owner

    function shows noise.function ups noise . if over 80db - need to call police + owner

    **********FUNCTIONS SHOULD BE IN MAIN*********




    */