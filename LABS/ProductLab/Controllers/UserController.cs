using ProductLab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace ProductLab.Controllers
{
    [AllowAnonymous]
    public class UserController : Controller
    {
        // GET: User
        private readonly UserOps _userDb = new UserOps();
        // GET: Login
        [AllowAnonymous]
        public ActionResult Login()
        {
            _userDb.GetAll();
            return View();
        }
        [HttpPost]
        public ActionResult Login(User pUser)
        {
            User foundUser = _userDb.FindUser(pUser.Username);
            if (pUser.Username == foundUser.Username && pUser.Password == foundUser.Password)
            {
                FormsAuthentication.SetAuthCookie(pUser.Username, false);
                Session["username"] = foundUser.Username;
                return RedirectToAction("Dashboard", "Product");
            }
                ModelState.AddModelError("Password", "Identity theft is not a joke JIM! Millions of people suffer everyday!");
                return View("Login");
            
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}