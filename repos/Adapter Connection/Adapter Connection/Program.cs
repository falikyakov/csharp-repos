using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Connection
{
    class Program
    {
        static void Main(string[] args)
        {
            InsuranceCompany ic = new InsuranceCompany();
            ic.NeedService();


            Console.Read();
        }
    }
}
