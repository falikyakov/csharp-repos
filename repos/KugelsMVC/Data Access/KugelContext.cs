using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access
{
    public class KugelContext : DbContext
    {
        public KugelContext():base()
        {

        }

        
         
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Kugel> Kugels { get; set; }
    }
}
