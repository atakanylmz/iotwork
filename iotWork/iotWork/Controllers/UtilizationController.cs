using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using iotWork.Models;
using System.Net.Sockets;
using System.IO;

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
       
        public ActionResult Start(int ID)
        {
            try
            {
                Device d = ctx.Devices.FirstOrDefault(x => x.deviceID ==ID );
                string IP = d.deviceIP;
                TcpClient tcpClient = new TcpClient(IP,5000);
                NetworkStream networkStream = tcpClient.GetStream();
                StreamWriter streamWriter = new StreamWriter(networkStream);
                streamWriter.WriteLine("A");
                streamWriter.Flush();
                tcpClient.Close();
            }
            catch (Exception)
            {

                throw;
            }
            return RedirectToAction("Index");
        }
        public ActionResult Stop(int ID)
        {
            try
            {
                Device d = ctx.Devices.FirstOrDefault(x => x.deviceID == ID);
                string IP = d.deviceIP;
                TcpClient tcpClient = new TcpClient(IP, 5000);
                NetworkStream networkStream = tcpClient.GetStream();
                StreamWriter streamWriter = new StreamWriter(networkStream);
                streamWriter.WriteLine("Y");
                streamWriter.Flush();
                tcpClient.Close();
            }
            catch (Exception)
            {

                throw;
            }
            return RedirectToAction("Index");
        }

    }
}