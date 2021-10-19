using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace node.example._1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var client = new HttpClient();
            var content = await client.GetStringAsync("http://localhost:3000");
            Console.WriteLine(content);

            Console.ReadLine();
        }
    }
}
