using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarEngineStrategy
{
    class Car
    {
        private ICarEngine CarEngine;
        public Car(ICarEngine carEngine)
        {
            this.CarEngine = carEngine;
        }

        public void On()
        {
            CarEngine.On();
        }
        public void Idle()
        {
            CarEngine.Idle();
        }


    }
}
