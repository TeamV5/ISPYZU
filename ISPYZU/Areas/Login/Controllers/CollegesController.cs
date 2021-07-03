using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ISPYZU.Models;

namespace ISPYZU.Areas.Login.Controllers
{
    public class CollegesController : Controller
    {
        private TestDbContext db = new TestDbContext();

        // GET: Login/Colleges
        public ActionResult Index()
        {
            return View(db.Colleges.ToList());
        }

        // GET: Login/Colleges/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Colleges colleges = db.Colleges.Find(id);
            if (colleges == null)
            {
                return HttpNotFound();
            }
            return View(colleges);
        }

        // GET: Login/Colleges/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Login/Colleges/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CollegeId,CollegeName")] Colleges colleges)
        {
            if (ModelState.IsValid)
            {
                db.Colleges.Add(colleges);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(colleges);
        }

        // GET: Login/Colleges/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Colleges colleges = db.Colleges.Find(id);
            if (colleges == null)
            {
                return HttpNotFound();
            }
            return View(colleges);
        }

        // POST: Login/Colleges/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CollegeId,CollegeName")] Colleges colleges)
        {
            if (ModelState.IsValid)
            {
                db.Entry(colleges).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(colleges);
        }

        // GET: Login/Colleges/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Colleges colleges = db.Colleges.Find(id);
            if (colleges == null)
            {
                return HttpNotFound();
            }
            return View(colleges);
        }

        // POST: Login/Colleges/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Colleges colleges = db.Colleges.Find(id);
            db.Colleges.Remove(colleges);
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
