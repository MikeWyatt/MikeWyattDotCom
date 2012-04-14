using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Blog()
        {
            return View();
        }
        public ActionResult AboutMe()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
    }
}
