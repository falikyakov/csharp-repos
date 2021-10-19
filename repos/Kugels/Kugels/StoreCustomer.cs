using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kugels
{
    class StoreCustomer : ISubject
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string  Area { get; set; }
        public string Telephone { get; set; }
        public string StoreOwner { get; set; }
        public string OwnerCell { get; set; }
        public string StoreManager { get; set; }
        public string ManagerCell { get; set; }
        public StoreCustomer(string name, string adr, string area, string owner, string mgr, string tel,string ownercell, string mgrcell)
        {
            this.Name = name;
            this.Address = adr;
            this.Area = area;
            this.StoreOwner = owner;
            this.StoreManager = mgr;
            this.Telephone = tel;
            this.OwnerCell = ownercell;
            this.ManagerCell=mgrcell;
        }

    }
}
