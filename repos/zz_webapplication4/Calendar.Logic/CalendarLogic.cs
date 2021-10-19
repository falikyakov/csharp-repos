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
            Calendar.Dal.CalendarDal dal = new Dal.CalendarDal();
            List<VwOmer> lst = dal.GetAll();
            return lst;
        }

        public VwOmer Get(int yom)
        {
            Calendar.Dal.CalendarDal dal = new Dal.CalendarDal();
            VwOmer wanted = dal.Get(yom);
            return wanted;
        }

        public TblOmer GetForUpdate(int yom)
        {
            Calendar.Dal.CalendarDal dal = new Dal.CalendarDal();
            TblOmer wanted = dal.GetForUpdate(yom);
            return wanted;
        }

        public void Update(int yom, TblOmer newer)
        {
            Calendar.Dal.CalendarDal dal = new Dal.CalendarDal();
            dal.Update(yom, newer);
        }

        public void Create(TblOmer adding)
        {
            Calendar.Dal.CalendarDal dal = new Dal.CalendarDal();
            dal.Create(adding);
        }
    }
}
