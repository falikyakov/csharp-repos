using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test1.Models;

namespace Test1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Show(string filter="Fal", int counter=1)
        {
            People CurrentPeople = new People();

            ViewData["counter"] = counter;

            return View(CurrentPeople.GetAllPeople(filter));
        }

           
    }

    //public ActionResult Edit(int ID)
    //{
    //    return View(ID);
    //}
}
