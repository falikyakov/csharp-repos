using BusinessEntitiesDbContext;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KugelML.DAL
{
    public class CustomerDAL
    {
        public List<Customer> GetAll()
        {
            KugelMLEntities kme = new KugelMLEntities();
            List<Customer> GetCustomers = kme.Customers.ToList();
            return GetCustomers;
        }

        public Customer GetSpecific(string name)
        {
            Customer SpecificCustomer = GetAll().FindAll(c => c.Name == name).Single();
            return SpecificCustomer;
        }

        public void Update(string name,string newName)
        {
            Customer updating = GetSpecific(name);

            using (KugelMLEntities km =new KugelMLEntities())
            {
                km.Entry<Customer>(updating).CurrentValues.SetValues(updating.Address="");
                km.Entry<Customer>(updating).CurrentValues.SetValues(updating.Cell = "");
                km.Entry<Customer>(updating).CurrentValues.SetValues(updating.Address = "");

            }
        }



    }
}
