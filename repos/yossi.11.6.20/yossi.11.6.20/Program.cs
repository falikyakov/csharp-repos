
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace yossi._11._6._20
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var client = new HttpClient();
            var result=await client.GetAsync("Http://localhost:3000");
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
