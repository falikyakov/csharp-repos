using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<CarList> MyCarList = new List<CarList>
            {
                new CarList{ID=01,Owner="blah",Model=4569 },
                new CarList{ID=02,Owner="Moish",Model=4570 },
                new CarList{ID=03,Owner="mench",Model=4578 },
                new CarList{ID=04,Owner="josh",Model=4556},
            };
            
            MyCarList.Sort();

            foreach (CarList item in MyCarList)
            {
                Console.WriteLine(item.ToString());
            }


            Console.ReadLine();
        }
    }
}
