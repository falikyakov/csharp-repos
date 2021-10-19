using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1234
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> Animals = new List<Animal>
            {
                new Animal{ name="lion",dwelling="Africa",amountInWorld=1000000},
                new Animal{ name="bear",dwelling="Africa",amountInWorld=2000000},
                new Animal{ name="moose",dwelling="America",amountInWorld=150000},
                new Animal{ name="panda",dwelling="Asia",amountInWorld=10000},
                new Animal{ name="Elephant",dwelling="Africa",amountInWorld=500000},
                new Animal{ name="Squirel",dwelling="America",amountInWorld=100000}
            };

            var check = from a in Animals
                        where a.dwelling == "Africa"
                        select a.name;

            foreach (var animal in check)
            {

            }

            Console.Read();
        }


    }

    class Animal
    {
        public string name { get; set; }
        public string dwelling { get; set; }
        public int amountInWorld { get; set; }
    }
}
