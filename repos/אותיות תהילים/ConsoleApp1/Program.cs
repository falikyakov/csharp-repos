using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            TehillimOpen();

            Console.ReadLine();
        }

        public static string TehillimOpen()
        {
            string tehillimText = File.ReadAllText(@"C:\Users\Yanky\Desktop\Chaim Yehuda Aryeh.docx");
            Console.WriteLine(tehillimText);

            return tehillimText;
        }
    }


}
