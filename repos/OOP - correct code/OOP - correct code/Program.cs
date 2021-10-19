using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___correct_code
{
    class Program
    {
        static void Main(string[] args)
        {
            //template method
            //separate bet. algorithm and use of it
            CakeMaker choc = new ChocolateCake("Chocolate Cake");
            choc.Make(choc.Name);


            Console.Read();
        }
    }
}
