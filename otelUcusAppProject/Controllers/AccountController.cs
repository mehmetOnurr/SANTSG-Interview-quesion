using otelUcusAppProject.DBModel;
using otelUcusAppProject.Models;

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace otelUcusAppProject.Controllers
{
    public class AccountController : Controller
    {
        otelucusEntities1 otelucus = new otelucusEntities1();
        // GET: Account
        public ActionResult login()
        {
            loginModel login_page = new loginModel();
            return View(login_page);
        }

        [HttpPost]
        public ActionResult login(loginModel login_page)
        {
            if (ModelState.IsValid)
            {
                if(otelucus.users.Where(m => m.username ==  login_page.user_name && m.u_password == login_page.password).FirstOrDefault() == null)
                {
                    ModelState.AddModelError("Error", "Invalid User Name and Password");
                    return View();

                }
                else
                {
                    if (otelucus.users.Where(m => m.username == login_page.user_name && m.u_password == login_page.password && m.role_id.Equals(1)).FirstOrDefault() != null)
                    {
                        Session["user_name"] = login_page.user_name;

                        return RedirectToAction("admin", "Home");


                    }
                    else
                    {
                        Session["user_name"] = login_page.user_name;
                        return  RedirectToAction("userPage", "Home");

                    }
                   
                }
            }

            return View();
        }

        public ActionResult Register()
        {
            userModel user = new userModel();
            return View(user);
        }

        [HttpPost]
        public ActionResult Register(userModel user)
        {
            if (ModelState.IsValid)
            {
                
                users faruser = new DBModel.users();
               
                faruser.username = user.username;
                faruser.u_password = user.u_password;
                user.role_id = 2;
                faruser.role_id = user.role_id;
                otelucus.users.Add(faruser);
                otelucus.SaveChanges();
                user = new userModel();
                user.successMessage = "User is successfully added";
                return View(user);
            }
            
         
            
            return View();
        }

       
    }
}