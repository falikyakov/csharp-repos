using mvc._1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc._1.Controllers
{
    public class StamController : Controller
    {
        // GET: Stam
        public ActionResult Index()
        {
            return View();
        }
        private List<Class1> GetClass()
        {

            List<Class1> MyClass = new List<Class1>
            {
                new Class1{Name="Yanky",Age=41},
                new Class1{Name="Shlomit",Age=38},
                new Class1{Name="Meir Simcha", Age=15 }
            };

            return MyClass;
        }

        public JsonResult GetJson()
        {
            var classes = GetClass();
            return Json(classes, JsonRequestBehavior.AllowGet);
        }
    }
}