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
    public class CourseEnrolledsController : Controller
    {
        private TestDbContext db = new TestDbContext();

        // GET: Login/CourseEnrolleds
        public ActionResult Index()
        {
            var courseEnrolled = db.CourseEnrolled.Include(c => c.Courses).Include(c => c.Student).Include(c => c.Teacher);
            return View(courseEnrolled.ToList());
        }

        // GET: Login/CourseEnrolleds/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseEnrolled courseEnrolled = db.CourseEnrolled.Find(id);
            if (courseEnrolled == null)
            {
                return HttpNotFound();
            }
            return View(courseEnrolled);
        }

        // GET: Login/CourseEnrolleds/Create
        public ActionResult Create()
        {
            ViewBag.CourseId = new SelectList(db.Courses, "CourseId", "CourseName");
            ViewBag.StudentId = new SelectList(db.Students, "StudentId", "Name");
           /* if (Session["StudentId"] != null)
            {
                
                ViewBag.StudentId = Session["StudentId"];

            }
            else
            {
                ViewBag.StudentId = new SelectList(db.Students, "StudentId", "Name");
            }
            */
                ViewBag.TeacherId = new SelectList(db.Teachers, "TeacherId", "Name");
            return View();
        }

        // POST: Login/CourseEnrolleds/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CEId,StudentId,CourseId,TeacherId")] CourseEnrolled courseEnrolled)
        {
            if (ModelState.IsValid)
            {
                db.CourseEnrolled.Add(courseEnrolled);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CourseId = new SelectList(db.Courses, "CourseId", "CourseName", courseEnrolled.CourseId);
            ViewBag.StudentId = new SelectList(db.Students, "StudentId", "Name", courseEnrolled.StudentId);
            /*if (Session["StudentId"] != null)
            {

                ViewBag.StudentId = Session["StudentId"];

            }
            else
            {
                ViewBag.StudentId = new SelectList(db.Students, "StudentId", "Name");
            }*/
            ViewBag.TeacherId = new SelectList(db.Teachers, "TeacherId", "Name", courseEnrolled.TeacherId);
            return View(courseEnrolled);
        }

        // GET: Login/CourseEnrolleds/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseEnrolled courseEnrolled = db.CourseEnrolled.Find(id);
            if (courseEnrolled == null)
            {
                return HttpNotFound();
            }
            ViewBag.CourseId = new SelectList(db.Courses, "CourseId", "CourseName", courseEnrolled.CourseId);
            ViewBag.StudentId = new SelectList(db.Students, "StudentId", "Name", courseEnrolled.StudentId);
            ViewBag.TeacherId = new SelectList(db.Teachers, "TeacherId", "Name", courseEnrolled.TeacherId);
            return View(courseEnrolled);
        }

        // POST: Login/CourseEnrolleds/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CEId,StudentId,CourseId,TeacherId")] CourseEnrolled courseEnrolled)
        {
            if (ModelState.IsValid)
            {
                db.Entry(courseEnrolled).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CourseId = new SelectList(db.Courses, "CourseId", "CourseName", courseEnrolled.CourseId);
            ViewBag.StudentId = new SelectList(db.Students, "StudentId", "Name", courseEnrolled.StudentId);
            ViewBag.TeacherId = new SelectList(db.Teachers, "TeacherId", "Name", courseEnrolled.TeacherId);
            return View(courseEnrolled);
        }

        // GET: Login/CourseEnrolleds/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseEnrolled courseEnrolled = db.CourseEnrolled.Find(id);
            if (courseEnrolled == null)
            {
                return HttpNotFound();
            }
            return View(courseEnrolled);
        }

        // POST: Login/CourseEnrolleds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            CourseEnrolled courseEnrolled = db.CourseEnrolled.Find(id);
            db.CourseEnrolled.Remove(courseEnrolled);
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
