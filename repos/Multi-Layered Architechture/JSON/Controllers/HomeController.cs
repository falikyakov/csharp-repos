using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JSON.Controllers
{
    public class HomeController : Controller
    {
        public JsonResult Flower(string what)
        {
            Dictionary<string,Object> Flowers = new Dictionary<string, Object>();

            Flowers.Add("tulip", new { 
                id=1,
                description="colorful",
                Image= @"C:\Users\Yanky\Desktop\IMG_4024"
            });

            Flowers.Add("calanit", new
            {
                id = 2,
                description = "calanit",
                Image = @"C:\Users\Yanky\Desktop\IMG_4032"
            });

            return Json(Flowers[what], JsonRequestBehavior.AllowGet);
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