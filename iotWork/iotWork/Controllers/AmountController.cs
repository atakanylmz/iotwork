using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using iotWork.Models;

namespace iotWork.Controllers
{
    public class AmountController : BaseController
    {
        remoteWorkContext ctx = new remoteWorkContext();

        // GET: Device
        public ActionResult Index()
        {
            int uID = Convert.ToInt32(Session["userID"]);
            List<Device> devices = ctx.Devices.Where(x => x.userID == uID).ToList();
            return View(devices);
        }

        public ActionResult AddDevice()
        {
            ViewBag.types = ctx.Types.ToList();
            return View();
        }
        [HttpPost]
        public ActionResult AddDevice(Device d)
        {
            d.userID = Convert.ToInt32(Session["userID"]);
            ctx.Devices.Add(d);
            ctx.SaveChanges();
            ViewBag.types = ctx.Types.ToList();
            return View();
        }
        public ActionResult ListRemoveDevice()
        {
            int uID = Convert.ToInt32(Session["userID"]);
            List<Device> devices = ctx.Devices.Where(x => x.userID == uID).ToList();
            return View(devices);
        }
        
        public ActionResult RemoveDevice(int id)
        {
            Device d = ctx.Devices.FirstOrDefault(x => x.deviceID == id);
            ctx.Devices.Remove(d);
            ctx.SaveChanges();
              return RedirectToAction("ListRemoveDevice");     
        }

    }
}