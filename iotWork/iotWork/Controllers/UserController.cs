using iotWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iotWork.Controllers
{
    public class UserController : Controller
    {
        remoteWorkContext ctx = new remoteWorkContext();

        // GET: Item
        public ActionResult AddUser()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddUser(User u)
        {
            ctx.Users.Add(u);
            ctx.SaveChanges();
            return RedirectToAction("Index", "Login");
        }
        public ActionResult RemoveUser()
        {
            int id = Convert.ToInt16(Session["userID"]);
            User user1 = ctx.Users.FirstOrDefault(x => x.userID==id);
            ctx.Users.Remove(user1);
            ctx.SaveChanges();
            Session["userID"] = "0";
            return RedirectToAction("Index", "Login");
        }
        public ActionResult UpdateUser()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UpdateUser(User u)
        {
            int id = Convert.ToInt16(Session["userID"]);
            User user1 = ctx.Users.FirstOrDefault(x => x.userID == id);
            user1.userName = u.userName;
            user1.userPassword = u.userPassword;
            user1.lastName = u.lastName;
            user1.firstName = u.firstName;
            user1.mail = u.mail;
            ctx.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}