using BusinessEntities;
using Data_Access;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic
{
    public class AccessingDAL
    {
        public List<Customer> GetCustomerList()
        {
            List<Customer> CustomerList;
            GetData gd = new GetData();
            CustomerList = gd.DiplayCustomers();

            return CustomerList;
        }

        public List<Store> GetStoreList()
        {
            List<Store> StoreList;
            GetData gd = new GetData();
            StoreList = gd.DiplayStores();

            return StoreList;
        }

        public List<Kugel> GetKugelList()
        {
            List<Kugel> KugelList; 
            GetData gd = new GetData();
            KugelList = gd.DiplayKugels();

            return KugelList;
        }

       
        
    }
}
