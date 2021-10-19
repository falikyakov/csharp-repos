using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace targil_22_9_19
{
    class Program
    {
        static void Main(string[] args)
        {
            IOperate machine = new Washing_Machine("Whirpool");
            MachineProcess(machine);
        }

        private static void MachineProcess(IOperate machine)
        {
            Console.WriteLine(machine.On());
            Console.WriteLine(machine.Work());
            Console.WriteLine(machine.Off());
        }

        public static IOperate SetObject(string machine)
        {
            if (machine.Contains("wash"))
            {
                return new Washing_Machine("Whirpool");
            }
            else

            if (machine.Contains("comp"))
            {
                return new Computer("Lenovo");
            }
            else 
            return null;
         

        }


    }
}

