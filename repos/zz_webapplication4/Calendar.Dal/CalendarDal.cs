 using Calendar.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar.Dal
{
    public class CalendarDal
    {
        public List<VwOmer> GetAll()
        {
            Calendar.Common.CalendarContext db = new Common.CalendarContext();
            List<VwOmer> lst = db.VwOmers.ToList();
            return lst;
        }
         
        public VwOmer Get(int yom)
        {
            VwOmer wanted = GetAll().FindAll(o => o.Yom == yom).Single();
            return wanted;
        }

        public void GetForUpdate(int yom)
        {
            using (Calendar.Common.CalendarContext db = new Common.CalendarContext())
            {
                TblOmer updating = db.TblOmers.Where(o => o.Yom == yom).Single();
                //return updating;
            }
        } 

        public void Update(int yom, TblOmer newer)
        {
            using (Calendar.Common.CalendarContext db = new Common.CalendarContext())
            {
                TblOmer updating = db.TblOmers.Where(o => o.Yom == yom).Single();
                db.Entry<TblOmer>(updating).CurrentValues.SetValues(newer);
                db.SaveChanges();
            }
        }

        public void Create(TblOmer adding)
        {
            using (Calendar.Common.CalendarContext db = new Common.CalendarContext())
            {
                db.TblOmers.Add(adding);
                db.SaveChanges();
            }
        }
    }
}
