using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericClass<Car> MyCars = new GenericClass<Car>(6);
            for (int i = 0; i < 6; i++)
            {
                MyCars.SetItem(i, new Car() { ID = i * 2, Owner = "Dani", Model = 254+i });
            }

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(MyCars.GetItem(i).ToString());
            }




            Console.ReadLine();
        }
    }
}
