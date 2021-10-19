using Calendar.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calendar.Dal
{
    public class CalendarDal
    {
        public List<VwOmer> GetAll()
        {
            CalendarDbEntities db = new CalendarDbEntities();
            List<VwOmer> lst = db.VwOmers.ToList();
            return lst;
        }

        public VwOmer Get(int yom)
        {
            CalendarDbEntities db = new CalendarDbEntities();
            VwOmer vw = GetAll().FindAll(y => y.Yom == yom).Single();
            return vw;
        }
    }
}
