using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary_CoreySchafer
{
    class SqlDataAccess:IDataAccess
    {
        public string LoadConnectionString(string name)
        {
            Console.WriteLine("Load connection string");
            return "testConnectionString";
        }

        public void LoadData(string sql)
        {
            Console.WriteLine("Loading M icrosoft SQL Data");
        }

        public void SaveData(string sql)
        {
            Console.WriteLine("Saving Data to Microsoft SQL Server");
        }
    }
}
