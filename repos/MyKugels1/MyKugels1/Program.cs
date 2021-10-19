using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyKugels1
{
    class Program
    {
        static void Main(string[] args)
        {
            Store Store1 = new Store();
            Area Area1 = new Area();
            Customer Customer1 = new Customer();
            Kugel Kugel1 = new Kugel();

            Console.WriteLine("Please type in code for what you would like to insert:\n" +
                "S for Store,\n" +
                "C for Customer,\n" +
                "K for Kugel");
            string d = Console.ReadLine();
            Console.WriteLine(d);



            Console.Read();
        }
    }
}
