using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shmuel._5._2._20
{
    class ShoppingList
    {
        public List<Product> Items = new List<Product>();
        public delegate void notifyTotal(double subTotal);
        public double GenerateTotal(notifyTotal notice,
        Func<List<Product>, double, double> calculateDiscount,
        Action<string> notifyDiscount,
        string message
        )
        {
            double total = Items.Sum(x => x.Price);
            notice(total);
            notifyDiscount(message);
            return calculateDiscount(Items, total);
            

        }


    }
}
