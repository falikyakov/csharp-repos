using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiyulim.BusinessEntities;

namespace Tiyulim.BusinessLogic
{
    public class TourSelector
    {
        public List<Tours> GetTours()
        {
            List<Tours> result = new List<Tours>();
            DataAccess.TiyulimReader tr = new DataAccess.TiyulimReader();
            result = tr.GetTours();
            return result;
        }
    }
}
