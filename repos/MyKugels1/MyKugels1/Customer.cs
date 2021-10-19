using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyKugels1
{
    class Customer : IKugels
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Area { get; set; }
        

        public string Description { get; set; }
    }
}
