using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace template_ver1._0.Controllers
{
    public class indexController : Controller
    {
        // GET: index
        public ActionResult Index()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
    }
}