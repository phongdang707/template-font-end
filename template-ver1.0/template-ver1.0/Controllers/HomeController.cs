using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace template_ver1._0.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "About";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "contact";

            return View();
        }
    }
}