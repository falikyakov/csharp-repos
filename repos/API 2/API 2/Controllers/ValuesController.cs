using API_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API_2.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public List<person> Get()
        {
            return PeopleList;


            //return new string[] { "value1", "value2" };
        }

        public List<person> PeopleList = new List<person> {
            new person{Id=1, Name="Yanky", Age=41},
            new person{Id=2, Name="Shlomit", Age=37},
            new person{Id=3, Name="Tzirel Leah", Age=13},
           new person{Id=152, Name="Mei Simcha Falik", Age=15},

        };

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
