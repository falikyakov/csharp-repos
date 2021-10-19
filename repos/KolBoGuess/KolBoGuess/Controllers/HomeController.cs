using KolBoGuess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KolBoGuess.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string mod7,string mod5, string mod3)
        {
            Class1 myClass = new Class1();

            int int7 = Convert.ToInt32(mod7);
            int int5 = Convert.ToInt32(mod5);
            int int3 = Convert.ToInt32(mod3);
            
            ViewBag.myNumber = myClass.YourNumber(int7, int5, int3);


            return View(ViewBag.myNumber);
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