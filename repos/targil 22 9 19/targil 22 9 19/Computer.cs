using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace targil_22_9_19
{
    class Computer : IOperate
    {
        private  string  Description { get; set; }

        public Computer(string description)
        {
            this.Description = description;
        }

        public string On()
        {
            return string.Format("I am a {0}; waking up",Description);
        }

        public string Work()
        {
            return string.Format("I am a {0}; running software",Description);
        }

        public string Off()
        {
            return string.Format("I am a {0}; shutting down", Description);
        }
    }
}
