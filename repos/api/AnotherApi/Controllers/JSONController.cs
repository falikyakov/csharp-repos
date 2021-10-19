using AnotherApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AnotherApi.Controllers
{
    public class JSONController : Controller
    {
        // GET: JSON
        public JsonResult GetJSON()
        {         
            //foreach (var person in PeopleList)
            //{
            //    return Json(new { id = person.Id, age = person.Age, name = person.Name }, JsonRequestBehavior.AllowGet);
            //}
            return Json(PeopleList,JsonRequestBehavior.AllowGet);
        }

        public List<people> PeopleList = new List<people> {
            new people{Id=1, Name="Yanky", Age=41},
            new people{Id=2, Name="Shlomit", Age=37},
            new people{Id=3, Name="Tzirel Leah", Age=13},
        };
    }
}