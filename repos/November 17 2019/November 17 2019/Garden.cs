using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Garden:IEngine
    {

        public void RealRunning()
        {
            Console.WriteLine("Running at garden.");
        }

        public void RealWalking()
        {
            Console.WriteLine("Walking at garden.");
        }
    }
}
