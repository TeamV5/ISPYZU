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
        }


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

                        return RedirectToAction("UserDashBoard");
                       
                        
                    }
                    else
                    {
                        ModelState.AddModelError("", "The username and password is incorrect");
                    }

                }
            }
            return View(Alogin);

        }

        public ActionResult UserDashBoard()
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