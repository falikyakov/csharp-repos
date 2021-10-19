using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_to_SQL_date_checker
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

            while (reader.Read())
            {
                if (dt.Month.ToString()==reader.GetValue(0).ToString())
                {
                    Console.WriteLine(reader.GetValue(0));
                }
                else
                {

                }
               
            }

            Console.ReadLine();
        }

        
    }
}
