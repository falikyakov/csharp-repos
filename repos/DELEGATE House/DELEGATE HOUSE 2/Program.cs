using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DELEGATE_HOUSE_2
{
    class Program
    {
        static void Main(string[] args)
        {
            House_Alarm YourHouse = new House_Alarm("Falik", "Nachal Uriah 7", 100, 40);
            NewTemp();
            NewTemp();
            NewTemp();
            NewTemp();
            Console.WriteLine("------------------------------------------------");
            NewNoiseLevel();
            NewNoiseLevel();
            NewNoiseLevel();
            NewNoiseLevel();

            void NewTemp()
            {
                YourHouse.IncreaseTemp();
                SetWarning();
                Console.WriteLine("Current temperature is: "+YourHouse.Temperature);
            }
            void NewNoiseLevel()
            {
                SetWarning();
                YourHouse.IncreaseDecibels();
                Console.WriteLine("Current noise level is: "+YourHouse.NoiseLevel);
            }

            void SetWarning()
            {
                if ((YourHouse.NoiseLevel>49)&&(YourHouse.Temperature<101))
                {
                    YourHouse.Warning = AlertOwnerBreakIn;
                    YourHouse.Warning += AlertPolice;
                }
                else if ((YourHouse.Temperature>100) && (YourHouse.NoiseLevel<50))
                {
                    YourHouse.Warning = AlertOwnerFire;
                    YourHouse.Warning += AlertFireDept;
                }
                else if ((YourHouse.NoiseLevel>49)&&(YourHouse.Temperature>100))
                {
                    YourHouse.Warning = AlertOwnerBreakIn;
                    YourHouse.Warning += AlertPolice;
                    YourHouse.Warning += AlertOwnerFire;
                    YourHouse.Warning += AlertFireDept;
                }
            }
           
            void AlertOwnerBreakIn()
            {
                Console.WriteLine("Mr. {0}, there's been a break-in at your apt. at {1}.",YourHouse.Name,YourHouse.Address);
            }
            void AlertPolice()
            {
                Console.WriteLine("ALERT: Break-in in progress at {0}; owner is {1}.",YourHouse.Address,YourHouse.Name);
            }
            void AlertOwnerFire()
            {
                Console.WriteLine("Mr. {0}, there's a fire in your apt. at {1}.", YourHouse.Name, YourHouse.Address);
            }
            void AlertFireDept()
            {
                Console.WriteLine("ALERT: Fire in progress at {0}",YourHouse.Address);
            }



            Console.ReadLine();
        }
    }
}
