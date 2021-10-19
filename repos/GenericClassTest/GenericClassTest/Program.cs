using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClassTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter number of family members:");
            int x = Convert.ToInt32(Console.ReadLine());

            GenericClass<Melons> MyGenMelon = new GenericClass<Melons>(x); 
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine("Please enter name.");
                MyGenMelon.SetItem(i, new Melons { ID = i + 1, Name = Console.ReadLine() });
            }

            for (int i = 0; i < x; i++)
            {
                Console.Write(MyGenMelon.GetItem(i).Name + "; ");
                Console.WriteLine("ID:" + MyGenMelon.GetItem(i).ID.ToString());
            }



            Console.Read();
        }
    }
}
