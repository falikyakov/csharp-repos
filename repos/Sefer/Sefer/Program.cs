using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sefer
{
    class Program
    {
        static void Main(string[] args)
        {
            SeforimStore Eichlers = new SeforimStore { Name = "Eichler's" };
            SeforimStore Shankys = new SeforimStore {Name="Shanky's" };

            SeforimSupplier Berman = new SeforimSupplier("Berman");

            SeforimPublisher ShasVilna = new SeforimPublisher();
            
            ShasVilna.NewUpdate = Eichlers.Update;
            ShasVilna.NewUpdate += Shankys.Update;

            float NewValue=0.0f;
            string seferName = "";

            while (ShasVilna.Price<1) 
            {
                Console.WriteLine("Please enter new value");
                try
                {
                    NewValue = Convert.ToSingle(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Please make sure to enter a number");
                }
                Console.WriteLine("Please enter name of Sefer:");
                seferName = Console.ReadLine();

                ShasVilna.Name = seferName;
                ShasVilna.Price = NewValue;

            }

            //ShasVilna.Price = 989.90f;
            //ShasVilna.Name = "Shas Vilna";




            Console.ReadLine();
        }
    }
}
