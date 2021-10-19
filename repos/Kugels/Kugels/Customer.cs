using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kugels
{
    class Customer : ISubject
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string  Telephone { get; set; }
        public string  CellPhone { get; set; }
        public string Email { get; set; }
        public Customer(string name, string adr, string tel, string cell)
        {
            this.Name = name;
            this.Address = adr;
            this.Telephone = tel;
            this.CellPhone = cell;
        }
    }
}
