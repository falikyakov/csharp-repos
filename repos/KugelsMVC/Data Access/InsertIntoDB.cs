using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access
{
    public class InsertIntoDB
    {
        public void InsertIntoKugel(string Name, string Description, string IngredientFile)
        {

            string connectionString = "Server=DESKTOP-5SIR5IV;Database=KugelML;Integrated Security=true";

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand($"INSERT INTO Kugel VALUES ('{Name}', '{Description}', '{IngredientFile}')",connection);

            connection.Open();

            command.ExecuteNonQuery();
        }


        public void InsertIntoStore(
            string Name, 
            string Address, 
            string Area, 
            string Tel,
            string Owner,
            string Manager,
            string OwnerCell,
            string MgrCell)
        {

            string connectionString = "Server=DESKTOP-5SIR5IV;Database=KugelML;Integrated Security=true";

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand
                ($"INSERT INTO Store VALUES ('{Name}', '{Address}', '{Area}','{Tel}', '{Owner}', '{Manager}','{OwnerCell}','{MgrCell}')", connection);

            connection.Open();

            command.ExecuteNonQuery();
        }


        public void InsertIntoCustomer(
           string Name,
           string Address,
           string Area,
           string Tel,         
           string Cell,
           string Email)
        {

            string connectionString = "Server=DESKTOP-5SIR5IV;Database=KugelML;Integrated Security=true";

            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand
                ($"INSERT INTO Customer VALUES ('{Name}', '{Address}', '{Area}','{Tel}','{Cell}',{Email})", connection);

            connection.Open();

            command.ExecuteNonQuery();
        }
    }
}


