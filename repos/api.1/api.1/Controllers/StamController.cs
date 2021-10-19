using api._1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Web.Helpers;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Mvc;

namespace api._1.Controllers
{
    public class StamController : ApiController
    {
        // GET: api/Stam
        public JsonResult<List<Class1>> Get()
        {
            List<Class1> MyClass = new List<Class1>
            {
                new Class1{Name="Yanky",Age=41},
                new Class1{Name="Shlomit",Age=38},
                new Class1{Name="Meir Simcha", Age=15 },
                new Class1{Name="אסתי",Age=7},
                new Class1{Name="יהודה אריה",Age=5},
            };

            return Json(MyClass);
        }

         


        // GET: api/Stam/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Stam
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Stam/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Stam/5
        public void Delete(int id)
        {
        }
    }
}
