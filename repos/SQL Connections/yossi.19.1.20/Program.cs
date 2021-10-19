using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//599 15804 - dafner

namespace yossi._19._1._20
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Yossi1912020;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
          //  string queryString = @"CREATE DATABASE Yossi1912020;";
           // string queryString2 = @"DROP DATABASE Yossi1912020;";
           // string queryString3 = @"CREATE TABLE person (ID INT IDENTITY (1,1) NOT NULL,Name NVarchar(30) )   ;";
            string queryString4 = @"INSERT INTO person VALUES ('TL Falik')";



            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(queryString4, connection);

            connection.Open();

            command.ExecuteNonQuery();


        }
    }
}
