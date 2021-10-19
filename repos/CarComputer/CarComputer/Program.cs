using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarComputer
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer MyCar = new Computer { Name = "Lexus SE" };
            Motor rv7x = new Motor { Name="rv7x"};
            Gears MyGear = new Gears {Name="My Gear" };

            //SetAlert();

            //MyCar.Alert = rv7x.OverheatAlert;
            //MyCar.Alert += rv7x.SpeedChange;
            //MyCar.Alert += MyGear.SpeedChange;
            MyCar.Temp = 72;
           
            MyCar.Speed = 57;
            SetAlertSpeed(MyCar);
            SetAlertSpeed(MyCar);
            SetAlertSpeed(MyCar);


            void SetAlertSpeed(Computer computer1)
            {
               
                if ((MyCar.Temp < 71))
                {
                    MyCar.Alert = rv7x.SpeedChange;
                    MyCar.Alert += MyGear.SpeedChange;
                }
                else
                {
                    MyCar.Alert = rv7x.SpeedChange;
                    MyCar.Alert += MyGear.SpeedChange;
                    MyCar.Alert += rv7x.OverheatAlert;
                }
                computer1.Accelerate();
            }
            

            Console.ReadLine();
        }


    }
}
