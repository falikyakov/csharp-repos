using localDbPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace localDbPractice.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            Business a = new Business {Name="sacbhaskdbaskb",ID=5 };

            a.ABC(5,"ocjadco");
            
            return View();
        }   
    }       
}           