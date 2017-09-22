using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GitTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string str = "21";
            int i = 2;
            i++;
            i += 2;
            i = 2;
            i += 5;
            i = i + 6;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}