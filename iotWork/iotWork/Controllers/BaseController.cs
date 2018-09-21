using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iotWork.Controllers
{
    public class BaseController : Controller
    {
        // GET: Base
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
           if (Session["userID"] == null || Session["userID"].ToString() == "0")
            {
                filterContext.Result = new RedirectResult("~/Login");
            }
            
            base.OnActionExecuting(filterContext);
        }
    }
}