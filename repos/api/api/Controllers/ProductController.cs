using api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace api.Controllers
{
    public class ProductController : ApiController
    {
        // GET: Product


        Product[] products = new Product[]
        {
                new Product{Id=1,Name="apple", Category="food", Price=21},
                new Product{Id=2,Name="orange", Category="food", Price=31},
                new Product{Id=6,Name="phone", Category="electronics", Price=91},
        };

        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product==null)
            {
                return NotFound();
            }
            return Ok(product);
        }








    }
}