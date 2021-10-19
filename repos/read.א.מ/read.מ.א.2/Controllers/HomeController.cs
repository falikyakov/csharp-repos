using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace read.מ.א._2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string[] dir = System.IO.File.ReadAllLines(@"C:\Users\Yanky\Desktop\yisroTest.txt");
            List<string> newList = new List<string>();
            foreach (var item in dir)
            {
                newList.Add(item);
            }
            return View(newList);
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