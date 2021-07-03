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
        public ActionResult CheckTeacherID(string TeacherId)
        {
            bool result = db.Teachers.FirstOrDefault(s => s.TeacherId == TeacherId) == null;
            return Json(result, JsonRequestBehavior.AllowGet);

        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
                db.Dispose();
            base.Dispose(disposing);
        }
    }
}







/*using ISPYZU.Models;
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


*/
