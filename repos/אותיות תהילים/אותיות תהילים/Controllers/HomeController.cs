using retrieve_tehillim;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace אותיות_תהילים.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            TehillimAccess ta = new TehillimAccess('a');
            string a = ta.TehillimOpen();

            return View(a);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}