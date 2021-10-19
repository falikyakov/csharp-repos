using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Phone
    {
        public virtual void Charge5v()
        {
            Console.WriteLine("Need to charge battery.");
        }

    }
}
