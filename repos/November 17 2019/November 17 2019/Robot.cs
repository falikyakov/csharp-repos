using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Robot
    {
        private IEngine WorkEngine;
        public Robot(IEngine realEngine)
        {
            this.WorkEngine = realEngine;
        }
        public void Walk()
        {
            WorkEngine.RealWalking();
        }

        public void Run()
        {
            WorkEngine.RealRunning();
        }


    }
}
