using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

//052-764-3025 , Netanel

namespace ATM_simulation.Controllers
{
    public class HomeController : Controller
    { 
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Please fill out text area";

            return View();
        }

        [HttpPost]
        public ActionResult Contact(string myMessage)
        {
            ViewBag.Message = Content(myMessage);
            return View();
        }

        public ActionResult Ffoo()
        {
            return View("about");
        }

        public ActionResult Serial(string letterCase)
        {
            string serial = "MYASPAPP1";
            if (letterCase == "lower")
            {
                return Content(serial.ToLower());
            }
            return Json(new {name="Yankt",value=serial },JsonRequestBehavior.AllowGet);
        }
    }
}