using Business_Logic;
using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Presentation_Layer.Controllers
{
    public class CreateController : Controller
    {
        // GET: Create
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Kugel()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Kugel(FormCollection formCollection)
        {
            Kugel k = new Kugel();
            k.Name = formCollection["Name"];
            k.Description = formCollection["Description"];
            k.IngredientFile = formCollection["IngredientFile"];

            AdaptData ad = new AdaptData();
            ad.AdaptKugelData(k.Name, k.Description, k.IngredientFile);
            Response.Write($"Name is {k.Name},\n Description is {k.Description},\n Ingredient file is {k.IngredientFile}");
            return View();
        }

        //wissotzky:  052-772-3500

        
        [HttpGet]
        public ActionResult Customer()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Customer(FormCollection formCollection)
        {
            Customer c = new Customer();
            c.Name = formCollection["Name"];
            c.Address = formCollection["Description"];
            c.Area = formCollection["Area"];
            c.Tel = formCollection["Tel"];
            c.Cell = formCollection["Cell"];
            c.Email = formCollection["Email"];

            AdaptData ad = new AdaptData();
            ad.AdaptCustomerData(c.Name, c.Address, c.Area, c.Tel, c.Cell, c.Email);

            Response.Write($"Name is {c.Name},\n Tel is {c.Tel}");
            return View();
        }



        [HttpGet]
        public ActionResult Store()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Store(FormCollection formCollection)
        {
            Store s = new Store();
            s.Name = formCollection["Name"];
            s.Address = formCollection["Address"];
            s.Area = formCollection["Area"];
            s.Tel = formCollection["Tel"];
            s.Owner = formCollection["Owner"];
            s.Manager = formCollection["Manager"];
            s.OwnerCell = formCollection["OwnerCell"];
            s.MgrCell = formCollection["MgrCell"];

            AdaptData ad = new AdaptData();
            ad.AdaptStoreData(s.Name, s.Address, s.Area, s.Tel, s.Owner, s.Manager, s.OwnerCell, s.MgrCell);

            Response.Write($"Name is {s.Name},\n Tel is {s.Tel}");
            return View();
        }




        // GET: Create/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Create/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Create/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Create/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Create/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Create/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Create/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
