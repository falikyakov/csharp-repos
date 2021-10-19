using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access
{
    public class GetData
    {
        public List<Customer> DiplayCustomers()
        {
            List<Customer> result = new List<Customer>();

            SqlConnection conn = new SqlConnection(@"Server=DESKTOP-5SIR5IV;Database=KugelML;Integrated Security=true");
            conn.Open();
            SqlCommand cmd1 = new SqlCommand
                ("select * from Customer", conn);
            SqlDataReader reader = cmd1.ExecuteReader();
            while (reader.Read())
            {
                result.Add(new Customer
                {
                    ID = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    Address = reader.GetString(2),
                    Area = reader.GetString(3),
                    Tel = reader.GetString(4),
                    Cell = reader.GetString(5)                  
                });
            }

            return result;
        }

        public List<Store> DiplayStores()
        {
            List<Store> result = new List<Store>();

            SqlConnection conn = new SqlConnection(@"Server=DESKTOP-5SIR5IV;Database=KugelML;Integrated Security=true");
            conn.Open();
            SqlCommand cmd1 = new SqlCommand
                ("select * from Store", conn);
            SqlDataReader reader = cmd1.ExecuteReader();
            while (reader.Read())
            {
                result.Add(new Store
                {
                    ID = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    Address = reader.GetString(2),
                    Area = reader.GetString(3),
                    Tel = reader.GetString(4),
                    Owner = reader.GetString(5),
                    Manager = reader.GetString(6),
                    OwnerCell = reader.GetString(7),
                    MgrCell = reader.GetString(8)
                });
            }

            return result;
        }

        public List<Kugel> DiplayKugels()
        {
            List<Kugel> result = new List<Kugel>();

            SqlConnection conn = new SqlConnection(@"Server=DESKTOP-5SIR5IV;Database=KugelML;Integrated Security=true");
            conn.Open();
            SqlCommand cmd1 = new SqlCommand
                ("select * from Kugel", conn);
            SqlDataReader reader = cmd1.ExecuteReader();
            while (reader.Read())
            {
                result.Add(new Kugel
                {
                    ID = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    Description = reader.GetString(2),
                    IngredientFile = reader.GetString(3)
                });
            }
            return result;
        }
    }
}
