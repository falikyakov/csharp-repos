using MongoCsharpCorner.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MongoCsharpCorner.Controllers
{
    public class CarInformationController : Controller
    {
        MongoContext _dbContext;
        public CarInformationController()
        {
            _dbContext = new MongoContext();
        }


        // GET: CarInformation
        public ActionResult Index()
        {
            return View();
        }

        // GET: CarInformation/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CarInformation/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CarInformation/Create
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

        // GET: CarInformation/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CarInformation/Edit/5
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

        // GET: CarInformation/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CarInformation/Delete/5
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
