using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using iotWork.Models;

namespace iotWork.Controllers
{
    public class HomeController : BaseController
    {
        remoteWorkContext ctx = new remoteWorkContext();
        // GET: Device
        public ActionResult Index()
        {
            int uID = Convert.ToInt32(Session["userID"]);
            List<Device> devices = ctx.Devices.Where(x=>x.userID==uID).ToList();
            return View(devices);
        }
    }
}