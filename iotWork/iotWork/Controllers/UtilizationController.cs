using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using iotWork.Models;
namespace iotWork.Controllers
{
    public class UtilizationController : BaseController
    {
        remoteWorkContext ctx = new remoteWorkContext();

        // GET: Utilization
        public ActionResult Index()
        {
            int uID = Convert.ToInt32(Session["userID"]);
            List<Device> devices = ctx.Devices.Where(x => x.userID == uID).ToList();
            return View(devices);
        }
       
        public ActionResult Start(int id)
        {

            return RedirectToAction("Index");
        }
        public ActionResult Stop(int id)
        {
            return RedirectToAction("Index");
        }

    }
}