using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Connection
{
    class Customer
    {
        public virtual void NeedService()
        {
            Console.WriteLine("Customer needs service.");
        }
    }
}
