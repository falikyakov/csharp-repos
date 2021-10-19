using PartialView_Test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartialView_Test.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Names()
        {
            List<Names> MyNames = new List<Names> {
                new Names{ID=1,Name="Danny",Age=15 },
                new Names{ID=2,Name="Moishy",Age=18 },
                new Names{ID=3,Name="Yanky",Age=13 },
                new Names{ID=4,Name="Yossi",Age=14 }
            };


            return View(MyNames);
        }
    }
}