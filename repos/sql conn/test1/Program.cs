using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conn = new SqlConnection("Server=DESKTOP-5SIR5IV;Database=Falik Family;Integrated Security=true");
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT month(DateOfBirth) FROM Kids", conn);

            SqlDataReader reader = cmd.ExecuteReader();

            DateTime dt = DateTime.Now;

            //while (reader.Read())
            //{
            //    if (reader.GetValue(0).ToString()==dt.Month.ToString())
            //    {
            //        Console.WriteLine(reader.GetValue(0));
            //    }
            //}



            while (reader.Read())
            {
                Console.WriteLine(reader.GetValue(0));
            }


            // File.WriteAllText(@"C:\Users\Yanky\Desktop\sql1.txt",reader);
            Console.ReadLine();
        }
    }
}
