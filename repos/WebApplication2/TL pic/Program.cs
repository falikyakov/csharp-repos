using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TL_pic
{
    class Program
    {
        static void Main(string[] args)
        {
            ////DateTime dt = File.GetCreationTime(@"C:\Users\Yanky\Desktop\03.2020\IMG_4019.JPG");
            ////Console.WriteLine(dt);

            //string[] files= Directory.GetFiles(@"C:\Users\Yanky\Downloads\חיים כץ\tracing","*.*",SearchOption.AllDirectories);
            //foreach (string file in files)
            //{
            //    Console.WriteLine(file);
            //}

            class1 c1 = new class1();
            Console.WriteLine("Please pick a number between 7 and 104...");
            Console.WriteLine("Now please divide your number by 7 and enter the remainder");
            int m7 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Now please divide your number by 5 and enter the remainder");
            int m5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Now please divide your number by 3 and enter the remainder");
            int m3 = Convert.ToInt32(Console.ReadLine());

            int total = c1.YourNumber(m7, m5, m3);

            Console.WriteLine("Your number is: {0}", total);

            Console.ReadLine();
        }
    }


    class class1
    {

        public int YourNumber(int a, int b, int c)
        {
            int sub_a = a * 15;
            int sub_b = b * 21;
            int sub_c = c * 70;
            int subTotal = (sub_a + sub_b + sub_c);
            int total;

            if (subTotal > 315)
            {
                total = subTotal - 315;
            }
            else if (subTotal > 210)
            {
                total = subTotal - 210;
            }
            else if (subTotal > 105)
            {
                total = subTotal - 105;
            }
            else
            {
                total = subTotal;
            }

            return total;
        }

    }
}
