using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ChadPeami> ChadPeamiList = new List<ChadPeami> {
                new ChadPeami {Name="Coffee Cup",Description="Carton cup" },
                new ChadPeami { Name = "Big Plate", Description = "Plastic 9\" plate" },
                new ChadPeami { Name = "Fork", Description = "Plastic Fork" },
                new ChadPeami { Name = "Strong Spoon", Description = "Hard plastic spoon" }
            };
            ChadPeami a = new ChadPeami {Name="Plastic Cup",Description="Cheap cup" };
            ChadPeamiList.Add(a);
            Console.WriteLine(ChadPeamiList[4]);


            //foreach (ChadPeami item in ChadPeamiList)
            //{
            //    Console.WriteLine(item.ToString());
            //}

            Console.ReadLine();
        }
    }

    class ChadPeami : IChadPeami
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public override string ToString()
        {
            StringBuilder a = new StringBuilder();
            a.Append($"Item: {Name}; Description: {Description}");
            return a.ToString();
        }

    }
}
