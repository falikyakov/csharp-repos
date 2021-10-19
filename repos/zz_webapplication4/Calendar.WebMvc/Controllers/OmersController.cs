using Calendar.Common;
using System;
using System.Collections.Generic;
using System.EnterpriseServices.CompensatingResourceManager;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Calendar.WebMvc.Controllers
{
    public class OmersController : Controller
    {
        // GET: Omers  ,   Index is optional
        public ActionResult Index()
        {
            Calendar.Logic.CalendarLogic logic = new Logic.CalendarLogic();
            List<VwOmer> lst = logic.GetAll();
            return View(lst);
        }

        public ActionResult Details(int id)
        {
            Calendar.Logic.CalendarLogic logic = new Logic.CalendarLogic();
            VwOmer wanted = logic.Get(id);
            //Models.DtoOmerRes ww = wanted;
            return View(wanted);
        }

        [HttpGet]
        public ActionResult Update(int yom)
        {
            Calendar.Logic.CalendarLogic logic = new Logic.CalendarLogic();
            TblOmer wanted = logic.GetForUpdate(yom);
            return View(wanted);
        }

        [HttpPost]
        public void Update(int yom, TblOmer newer)
        {
            Calendar.Logic.CalendarLogic logic = new Logic.CalendarLogic();
            logic.Update(yom, newer);
            RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public void Create(TblOmer adding)//Models.DtoOmerReq adding)
        {
            //TblOmer qq = adding;
            Calendar.Logic.CalendarLogic logic = new Logic.CalendarLogic();
            logic.Create(adding);//qq);
            RedirectToAction("Index");
        }
    }
}