using calendar.Dal;
using Calendar.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar.Logic
{
    public class CalendarLogic
    {
        public List<VwOmer> GetAll()
        {
            CalendarDal dal = new CalendarDal();
            List<VwOmer> lst = dal.GetAll();
            return lst;
        }

        public VwOmer Get(int yom)
        {
            CalendarDal dal = new CalendarDal();
            VwOmer wanted = dal.Get(yom);
            return wanted;
        }

        public TblOmer GetForUpdate(int yom)
        {
            CalendarDal dal = new CalendarDal();
            dal.
            return wanted;
        }

        public void Update(int yom, TblOmer newer)
        {
            calendar.Dal.CalendarDal dal = new calendar.Dal.CalendarDal();
            dal.Update(yom, newer);
        }

        public void Create(TblOmer adding)
        {
            CalendarDal dal = new CalendarDal();
            dal.Create(adding);
        }
    }
}
