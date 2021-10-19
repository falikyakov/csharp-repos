using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace yossi_26._1._20.Models
{
    public class RestaurantAdapter
    {
        public List<Restaurant> GetAllRestaurants(string filter)
        {
            List<Restaurant> result = new List<Restaurant>();
         

            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\USERS\YANKY\SOURCE\REPOS\YOSSI 26.1.20\YOSSI 26.1.20\APP_DATA\ORDERSDB.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            conn.Open();
            SqlCommand cmd1 = new SqlCommand
                ("select * from restaurants", conn);
            SqlDataReader reader = cmd1.ExecuteReader();
            while (reader.Read())
            {
                result.Add(new Restaurant
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    Address=reader.GetString(2),
                    Description = reader.GetString(3),
                    ImageUrl=reader.GetString(4)
                }) ;
            }
            return result;
        }
    }
}