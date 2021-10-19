using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SelectPics.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(int? year)
        {
            year = 200;

            string[] dir = Directory.GetFiles(@"C:\Users\Yanky\Desktop\TL Camera");
            foreach (string dr in dir)
            {

            }

            return View(dir);
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