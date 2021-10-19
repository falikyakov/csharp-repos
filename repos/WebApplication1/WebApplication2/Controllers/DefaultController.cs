using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Default
        public string Index()
        {
            return "Hey there";
        }

        public string Hello()
        {
            return "OK that's enough!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!";
        }
    }
}