using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary_CoreySchafer
{
    class SqliteDataAccess
    {
        public string LoadConnectionString(string name)
        {
            Console.WriteLine("Load connection string");
            return "testConnectionString";
        }

        public void LoadData(string sql)
        {
            Console.WriteLine("Loading Microsoft SQLite Data");
        }

        public void SaveData(string sql)
        {
            Console.WriteLine("Saving Data to Microsoft SQLite Server");
        }
    }
}
