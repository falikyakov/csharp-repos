using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiyulim.BusinessEntities;

namespace Tiyulim.DataAccess
{
    public class TiyulimReader
    {
        public List<Tours> GetTours()
        {
            List<Tours> result = null;

            using (var ctx = new TiyulimDbContext())
            {
                result = (from t in ctx.TiyulimTable
                          select t).ToList<Tours>();
            }

            return result;
        }


    }
}
