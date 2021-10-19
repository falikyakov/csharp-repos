using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Connection
{
    class InsuranceCompany:Customer
    {
        private FridgeTechnician fridgeTechie;
        public InsuranceCompany()
        {
            fridgeTechie = new FridgeTechnician();
        }
        public override void NeedService()
        {
            base.NeedService();
            fridgeTechie.FridgeWork();
            Console.WriteLine("Service provided to customer from Fridge Technician.");
        }
    }
}
