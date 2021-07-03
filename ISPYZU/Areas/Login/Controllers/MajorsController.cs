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
    public class MajorsController : Controller
    {
        private TestDbContext db = new TestDbContext();

        // GET: Login/Majors
        public ActionResult Index()
        {
            var majors = db.Majors.Include(m => m.Colleges);
            return View(majors.ToList());
        }

        // GET: Login/Majors/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Majors majors = db.Majors.Find(id);
            if (majors == null)
            {
                return HttpNotFound();
            }
            return View(majors);
        }

        // GET: Login/Majors/Create
        public ActionResult Create()
        {
            ViewBag.CollegeId = new SelectList(db.Colleges, "CollegeId", "CollegeName");
            return View();
        }

        // POST: Login/Majors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MajorId,MajorName,CollegeId")] Majors majors)
        {
            if (ModelState.IsValid)
            {
                db.Majors.Add(majors);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CollegeId = new SelectList(db.Colleges, "CollegeId", "CollegeName", majors.CollegeId);
            return View(majors);
        }

        // GET: Login/Majors/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Majors majors = db.Majors.Find(id);
            if (majors == null)
            {
                return HttpNotFound();
            }
            ViewBag.CollegeId = new SelectList(db.Colleges, "CollegeId", "CollegeName", majors.CollegeId);
            return View(majors);
        }

        // POST: Login/Majors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MajorId,MajorName,CollegeId")] Majors majors)
        {
            if (ModelState.IsValid)
            {
                db.Entry(majors).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CollegeId = new SelectList(db.Colleges, "CollegeId", "CollegeName", majors.CollegeId);
            return View(majors);
        }

        // GET: Login/Majors/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Majors majors = db.Majors.Find(id);
            if (majors == null)
            {
                return HttpNotFound();
            }
            return View(majors);
        }

        // POST: Login/Majors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Majors majors = db.Majors.Find(id);
            db.Majors.Remove(majors);
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
