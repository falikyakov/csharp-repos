using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Access;

namespace Business_Logic
{
    public class AdaptData
    {
        public void AdaptKugelData(string Name, string Description, string IngredientFile)
        {
            InsertIntoDB iiDB = new InsertIntoDB();
            iiDB.InsertIntoKugel(Name, Description, IngredientFile);
        }


        public void AdaptStoreData(string Name, string Address, string Area, string Tel, 
            string Owner, string Manager, string OwnerCell, string MgrCell)
        {
            InsertIntoDB iiDB = new InsertIntoDB();
            iiDB.InsertIntoStore(Name, Address, Area, Tel, Owner,  Manager,  OwnerCell,  MgrCell);
        }


        public void AdaptCustomerData(string Name, string Address, string Area, string Tel, string Cell, string Email)
        {
            InsertIntoDB iiDB = new InsertIntoDB();
            iiDB.InsertIntoCustomer(Name, Address, Area, Tel, Cell, Email);
        }
    }
}
