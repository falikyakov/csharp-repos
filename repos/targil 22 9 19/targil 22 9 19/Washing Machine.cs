using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace targil_22_9_19
{
    class Washing_Machine : IOperate
    {
        private string Brand;

        public Washing_Machine(string brand)
        {
            this.Brand = brand;
        }

        public string On()
        {
            return string.Format("I am a {0}; waking up", Brand);
        }

        public string Work()
        {
            return string.Format("I am a {0}; in progress", Brand);
        }

        public string Off()
        {
            return string.Format("I am a {0}; shutting down", Brand);
        }


        public void TellMe()
        {
            Console.WriteLine("I just wanted to check out" +
                "how this works");
        }
    }
}
