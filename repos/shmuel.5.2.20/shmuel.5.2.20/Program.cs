using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shmuel._5._2._20
{
    class Program
    {
        static void Main(string[] args)
        {
            ShoppingList shoppingList1 = new ShoppingList();
            ShoppingList list2 = new ShoppingList();
            PopulateShoppingList(shoppingList1);
            PopulateShoppingList(list2);
            //Console.WriteLine(shoppingList1.GenerateTotal(startTotalInfo, FinalTotalInfo));

            double finalPrice = list2.GenerateTotal(
                (startTotal) => Console.WriteLine($"Your start total is {startTotal}"),
                (products, startTotal) =>
                {
                    if (products.Count > 3)
                    {
                        return startTotal * .5;
                    }
                    else
                    {
                        return startTotal;
                    }
                },
                (message)=>Console.WriteLine(message),
                "Discount confirmed."
                
                );

            Console.Read();
        }

        public static void PopulateShoppingList(ShoppingList shoppingCart)
        {
            shoppingCart.Items.Add(new Product { Name = "Tomatoes", Price = 4.9 });
            shoppingCart.Items.Add(new Product { Name = "Cucumbers", Price = 3.9 });
            shoppingCart.Items.Add(new Product { Name = "Cereal", Price = 13.9 });
            shoppingCart.Items.Add(new Product { Name = "Milk", Price = 9.8 });
        }

        public static double FinalTotalInfo(List<Product> products, double startTotal)
        {
            if (startTotal > 100)
            {
                return startTotal * .80;
            }
            else if (startTotal > 50)
            {
                return startTotal * .85;
            }
            else if (startTotal > 10)
            {
                return startTotal * .95;
            }
            else
            {
                return startTotal;
            }
            
        }

        public static void startTotalInfo(double total)
        {
            Console.WriteLine($"Your start total is {total}");
        }
    }
}
