using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using name_search_2.Models;

namespace name_search_2.Controllers
{
    public class kidsController : Controller
    {
        private Falik_FamilyEntities db = new Falik_FamilyEntities();

        // GET: kids
        public ActionResult Index(string searchBy, string textSearch)
        {
            if (searchBy == "School")
            {
                return View(db.kids.Where(x => x.School.StartsWith(textSearch)).ToList());
            }
            else
            {
                return View(db.kids.Where(x => x.Email.StartsWith(textSearch)).ToList());
            }
        }

        // GET: kids/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            kid kid = db.kids.Find(id);
            if (kid == null)
            {
                return HttpNotFound();
            }
            return View(kid);
        }

        // GET: kids/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: kids/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FirstName,Age,DateOfBirth,School,Email,TimeOfEntry")] kid kid)
        {
            if (ModelState.IsValid)
            {
                db.kids.Add(kid);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(kid);
        }

        // GET: kids/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            kid kid = db.kids.Find(id);
            if (kid == null)
            {
                return HttpNotFound();
            }
            return View(kid);
        }

        // POST: kids/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FirstName,Age,DateOfBirth,School,Email,TimeOfEntry")] kid kid)
        {
            if (ModelState.IsValid)
            {
                db.Entry(kid).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(kid);
        }

        // GET: kids/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            kid kid = db.kids.Find(id);
            if (kid == null)
            {
                return HttpNotFound();
            }
            return View(kid);
        }

        // POST: kids/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            kid kid = db.kids.Find(id);
            db.kids.Remove(kid);
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
