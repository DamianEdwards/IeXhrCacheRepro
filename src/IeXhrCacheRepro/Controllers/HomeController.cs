using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IeXhrCacheRepro.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetServerTime()
        {
            return Json(DateTime.UtcNow.ToString(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetServerTimeWithCacheControl()
        {
            ControllerContext.HttpContext.Response.Cache.SetMaxAge(TimeSpan.FromSeconds(0));
            return Json(DateTime.UtcNow.ToString(), JsonRequestBehavior.AllowGet);
        }
    }
}