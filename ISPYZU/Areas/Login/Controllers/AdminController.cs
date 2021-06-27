using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ISPYZU.Models;

namespace ISPYZU.Areas.Login.Controllers
{
    public class AdminController : Controller
    {
         TestDbContext adminDB = new TestDbContext();


        public ActionResult Ajax(string id)
        {
            if (Request.IsAjaxRequest())
                return PartialView(id);
            else
                return View(id);


          /*if (id == null)
            {
                return View();
            }
            else
            {
                return View(id);
            } */


        }

        
        
        public ActionResult StudentLogin(string id)
        {
            return View();

        }




        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult StudentLogin(Student Slogin)
        {
             if(!ModelState.IsValid)
            {

                {
                    //var obj1= adminDB.Students.Where(a =>a.StudentId.Equals(Slogin) )
                    var obj = adminDB.Students.Where(s => s.StudentId.Equals(Slogin.StudentId) && s.Password.Equals(Slogin.Password)).FirstOrDefault();
                    if (obj != null)
                    {

                        Session["StudentId"] = obj.StudentId.ToString();
                        Session["Password"] = obj.Password.ToString();

                        return RedirectToAction("StudentDashBoard");


                    }
                    else
                    {
                        ModelState.AddModelError("", "The ID and password is incorrect");
                    }

                }
               
            }
            return View(Slogin);


        }
        
        public ActionResult StudentDashBoard()
        {
            if (Session["StudentId"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("StudentLogin");
            }
        }
        
       


        // teachers login function


        public ActionResult TeacherLogin(string id)
        {
            return View();

        }




        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TeacherLogin(Teacher Slogin)
        {
            if (!ModelState.IsValid)
            {

                {
                    //var obj1= adminDB.Students.Where(a =>a.StudentId.Equals(Slogin) )
                    var obj = adminDB.Teachers.Where(s => s.TeacherId.Equals(Slogin.TeacherId) && s.Password.Equals(Slogin.Password)).FirstOrDefault();
                    if (obj != null)
                    {

                        Session["TeacherId"] = obj.TeacherId.ToString();
                        Session["Password"] = obj.Password.ToString();

                        return RedirectToAction("TeacherDashBoard");


                    }
                    else
                    {
                        ModelState.AddModelError("", "The ID and password is incorrect");
                    }

                }

            }
            return View(Slogin);


        }

        public ActionResult TeacherDashBoard()
        {
            if (Session["TeacherId"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("TeacherLogin");
            }
        }



        /// <summary>
        /// // main index
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        public ActionResult Index(string id)
        {
            return View();
            
        }

        


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(User Alogin)
        {
            if(ModelState.IsValid)
            {
               
                {
                    var obj = adminDB.Users.Where(a => a.UserName.Equals(Alogin.UserName) && a.Password.Equals(Alogin.Password)).FirstOrDefault();
                    if (obj != null)
                    {
                        
                        Session["UserName"]= obj.UserName.ToString();
                        Session["Password"]= obj.Password.ToString();

                        return RedirectToAction("AdminDashBoard");
                       
                        
                    }
                    else
                    {
                        ModelState.AddModelError("", "The username and password is incorrect");
                    }

                }
            }
            return View(Alogin);

        }

        public ActionResult AdminDashBoard()
        {
            if (Session["UserName"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Ajax", "Admin");
        }


        public ActionResult Teacher()
        {
            return View();
        }

        public ActionResult Student()
        {
            return View();
        }




    }
}
