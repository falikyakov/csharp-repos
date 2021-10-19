using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using yossi_26._1._20.Models;

namespace yossi_26._1._20.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            RestaurantAdapter r1 = new RestaurantAdapter();
            List<Restaurant> AllRestaurants = r1.GetAllRestaurants("");

            return View(AllRestaurants);
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