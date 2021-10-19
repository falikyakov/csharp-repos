using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_to_SQL_date_checker_2
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conn = new SqlConnection("Server=DESKTOP-5SIR5IV;Database=Falik Family;Integrated Security=true");
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT month(DateOfBirth),FirstName, Email FROM Kids", conn);
            
            SqlDataReader reader = cmd.ExecuteReader();
                      

            DateTime dt = DateTime.Now;

            while (reader.Read())
            {
                if (reader.GetValue(0).ToString()==dt.Month.ToString())
                {
                    Console.WriteLine(reader.GetString(1)+". Email address is: "+reader.GetString(2));
                }

            }

            Console.ReadLine();
        }
    }
}
