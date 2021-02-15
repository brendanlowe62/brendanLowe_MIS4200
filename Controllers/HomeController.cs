using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace brendanLowe_MIS4200.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About Brendan Lowe";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Brendan Lowe";

            return View();
        }
    }
}