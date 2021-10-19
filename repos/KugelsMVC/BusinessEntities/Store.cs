using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class Store : ICustomer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Area { get; set; } 
        public string Tel { get; set; }
        public string Owner { get; set; }
        public string Manager { get; set; }
        public string OwnerCell { get; set; }
        public string MgrCell { get; set; }
    }
}
