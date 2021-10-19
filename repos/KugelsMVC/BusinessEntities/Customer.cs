using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class Customer : ICustomer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Area { get;set; }
        public string Tel { get; set; }
        public string Cell { get; set; }
        public string Email { get; set; }

    }
}
