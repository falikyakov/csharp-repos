using api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace api.Controllers
{
    public class ValuesController : ApiController
    {
        List<Product> products = new List<Product>
        {
            new Product{Id=1, Name="Tomatoes", Category="Fruit", Price=2},
            new Product{Id=2, Name="Earphones", Category="Electronics", Price=8},
            new Product{Id=2, Name="Headband", Category="WomensClothing", Price=4}
        };
        // GET api/values
        public List<Product> Get()
        {
            return  products ;
        }

        // GET api/values/5
        public Product Get(int id)
        {
            return products.Where(x=>x.Id==id).FirstOrDefault();
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
