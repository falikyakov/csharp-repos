using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using name_search.Models;

namespace name_search.Controllers
{
    public class HomeController : Controller
    {
        private Falik_FamilyEntities db = new Falik_FamilyEntities();

        // GET: Home
        public ActionResult Index(string searchBy, string textSearch)
        {
            if (searchBy == "School")
            {
                return View(db.kids1.Where(x => x.School.StartsWith(textSearch)).ToList());
            }
            else
            {
                return View(db.kids1.Where(x => x.Email.StartsWith(textSearch)).ToList());
            }
        }
        // GET: Home/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            kids kids = db.kids1.Find(id);
            if (kids == null)
            {
                return HttpNotFound();
            }
            return View(kids);
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FirstName,Age,DateOfBirth,School,Email,TimeOfEntry")] kids kids)
        {
            if (ModelState.IsValid)
            {
                db.kids1.Add(kids);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(kids);
        }

        // GET: Home/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            kids kids = db.kids1.Find(id);
            if (kids == null)
            {
                return HttpNotFound();
            }
            return View(kids);
        }

        // POST: Home/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FirstName,Age,DateOfBirth,School,Email,TimeOfEntry")] kids kids)
        {
            if (ModelState.IsValid)
            {
                db.Entry(kids).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(kids);
        }

        // GET: Home/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            kids kids = db.kids1.Find(id);
            if (kids == null)
            {
                return HttpNotFound();
            }
            return View(kids);
        }

        // POST: Home/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            kids kids = db.kids1.Find(id);
            db.kids1.Remove(kids);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
