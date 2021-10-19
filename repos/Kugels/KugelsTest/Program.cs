using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KugelsTest;

namespace KugelsTest
{
    class Program
    {
        static void Main(string[] args)
        {
            StoreCustomer BestMarket = new StoreCustomer("Best Market", "Cor. Dolev & Ayalon", "Dolev RBS-A", "Effi", "Tzach", 025386800,
                   123456, 9876544);
            Console.WriteLine("Store Name: {0}\nAddress: {1}\nArea: {2}\nOwner: {3}Manager: {4}\nStore Tel: {5}\nOwner Cell: {6}" +
                "\nManager Cell: {7}", BestMarket.Name, BestMarket.Address, BestMarket.Area, BestMarket.StoreOwner, BestMarket.StoreManager,
                BestMarket.Telephone, BestMarket.OwnerCell, BestMarket.ManagerCell);
        }
    }
}
