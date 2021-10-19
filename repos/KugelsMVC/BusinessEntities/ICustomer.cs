using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    interface ICustomer
    {
        int ID { get; set; }
        string Name { get; set; }
        string Address { get; set; }
        string Area { get; set; }
        string Tel { get; set; }

    }
}
