using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiyulim.BusinessEntities;

namespace Tiyulim.DataAccess
{
    class Program
    {
        static void Main(string[] args)
        {
            TiyulimDbContext ctx = new TiyulimDbContext();

            //Tours TourKeverDan = new Tours()
            //{
            //    Description = "Kever of Dan ben Yaakov, with spring nearby",
            //    Region = "Matte Yehuda",
            //    Level = 1
            //};


            //ctx.TiyulimTable.Add(TourKeverDan);
        }
    }
}
