using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class PhoneCharger:Phone
    {
        private Outlet outlet;
        public PhoneCharger()
        {
            outlet = new Outlet();
        }
        public override void Charge5v()
        {
            base.Charge5v();
            outlet.Supply220v();
            Console.WriteLine("Converting to 5v.");
        }
    }
}
