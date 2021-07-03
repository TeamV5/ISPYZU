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
    public class RunningCoursesController : Controller
    {
        private TestDbContext db = new TestDbContext();

        // GET: Login/RunningCourses
        public ActionResult Index()
        {
            var runningCourses = db.RunningCourses.Include(r => r.Courses).Include(r => r.Teacher);
            return View(runningCourses.ToList());
        }

        // GET: Login/RunningCourses/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RunningCourses runningCourses = db.RunningCourses.Find(id);
            if (runningCourses == null)
            {
                return HttpNotFound();
            }
            return View(runningCourses);
        }

        // GET: Login/RunningCourses/Create
        public ActionResult Create()
        {
            ViewBag.CourseId = new SelectList(db.Courses, "CourseId", "CourseName");
            ViewBag.TeacherId = new SelectList(db.Teachers, "TeacherId", "Name");
            return View();
        }

        // POST: Login/RunningCourses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RCId,CourseId,TeacherId")] RunningCourses runningCourses)
        {
            if (ModelState.IsValid)
            {
                db.RunningCourses.Add(runningCourses);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CourseId = new SelectList(db.Courses, "CourseId", "CourseName", runningCourses.CourseId);
            ViewBag.TeacherId = new SelectList(db.Teachers, "TeacherId", "Name", runningCourses.TeacherId);
            return View(runningCourses);
        }

        // GET: Login/RunningCourses/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RunningCourses runningCourses = db.RunningCourses.Find(id);
            if (runningCourses == null)
            {
                return HttpNotFound();
            }
            ViewBag.CourseId = new SelectList(db.Courses, "CourseId", "CourseName", runningCourses.CourseId);
            ViewBag.TeacherId = new SelectList(db.Teachers, "TeacherId", "Name", runningCourses.TeacherId);
            return View(runningCourses);
        }

        // POST: Login/RunningCourses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RCId,CourseId,TeacherId")] RunningCourses runningCourses)
        {
            if (ModelState.IsValid)
            {
                db.Entry(runningCourses).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CourseId = new SelectList(db.Courses, "CourseId", "CourseName", runningCourses.CourseId);
            ViewBag.TeacherId = new SelectList(db.Teachers, "TeacherId", "Name", runningCourses.TeacherId);
            return View(runningCourses);
        }

        // GET: Login/RunningCourses/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RunningCourses runningCourses = db.RunningCourses.Find(id);
            if (runningCourses == null)
            {
                return HttpNotFound();
            }
            return View(runningCourses);
        }

        // POST: Login/RunningCourses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            RunningCourses runningCourses = db.RunningCourses.Find(id);
            db.RunningCourses.Remove(runningCourses);
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
