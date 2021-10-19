using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Home : IEngine
    {
        public void RealRunning()
        {
            Console.WriteLine("Running at home.");
        }

        public void RealWalking()
        {
            Console.WriteLine("Walking at home.");
        }
    }
}
