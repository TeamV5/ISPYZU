using ISPYZU.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ISPYZU.Areas.Remote.Controllers
{
    public class StudentsController : Controller
    {
        
        private TestDbContext db = new TestDbContext();
        // GET: Remote/Students
        public ActionResult CheckID(string StudentId)
        {
            bool result = db.Students.FirstOrDefault(s => s.StudentId == StudentId) == null;
            return Json(result, JsonRequestBehavior.AllowGet);

        }
    }
}