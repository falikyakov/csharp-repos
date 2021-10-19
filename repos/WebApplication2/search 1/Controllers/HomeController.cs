using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace search_1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string textArea)
        {

            return View(Content(textArea));
           
           
        }

        string textArea = "wallla";
        public ActionResult About()
        {
            return Content(textArea);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
} 