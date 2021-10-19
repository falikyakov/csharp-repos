using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using whatever.Models;

namespace whatever.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(int id,string name)
        {
            List<Class1> myClass = new List<Class1>();
            myClass.Add(new Class1 {id=id, name=name });

            return View(myClass);
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