using Db_Test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Db_Test.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            GetStudents();


            return View();
        }

      
        public List<Student> GetStudents()
        {
            List<Student> result = new List<Student>();

            SchoolContext a = new SchoolContext();

            result = (from ps in a.Students
                      select ps).ToList<Student>();

            return result;
        }
    }
}