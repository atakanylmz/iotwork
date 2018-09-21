using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using iotWork.Models;

namespace iotWork.Controllers
{
    public class LoginController : Controller
    {
        remoteWorkContext ctx = new remoteWorkContext();

        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult LoginForm(User u)
        {
            
            User user1 = ctx.Users.FirstOrDefault(x => x.userName == u.userName&&x.userPassword==u.userPassword);
            if (user1==null)
            {
                Session["userID"] = "0";
            }
            else
            {
                Session["userID"] = user1.userID.ToString();
            }
            
            return RedirectToAction("Index","Home");
        }
        public ActionResult Logout()
        {
            Session["userID"] = "0";
            return RedirectToAction("Index");
        }
    }
}