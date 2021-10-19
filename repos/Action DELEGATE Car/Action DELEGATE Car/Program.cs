using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Action_DELEGATE_Car
{
    //Car computer
        //    Brakes
        //    Motor
        //    Gears
        //    Tires
    //Sensors
    //    Temp
    //    Speed
    //    Tire pressure
    //    Brake activation

    //Motor needs notification when temp more than 70
    //Gears need notif. When change in speed
    //Motor needs notif. When ghange in speed
    //Tires need notif. When tire pressure change
    //Brakes need notif. When brakes activated

    class Program
    {
        static void Main(string[] args)
        {
            CarComputer cc = new CarComputer();
            cc.Name = "yabagaba";
            CarParts cp = new CarParts();
            cc.Notify = cp.NotifyMe;
            cc.Temperature = 95;
         
           

            int NewTemp = 0;
            while (cc.Temperature > 0)
            {
                Console.WriteLine("Please enter new value");
                try
                {
                    NewTemp = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Please make sure to enter a number");
                }


                cc.Temperature = NewTemp;
            }







            Console.Read();
        }
    }
}
