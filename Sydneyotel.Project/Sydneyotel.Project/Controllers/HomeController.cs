using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sydneyotel.Project.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Welcome to About us";
            return View();
        }
        public ActionResult Gallery()
        {
            ViewBag.Message = "Local Attractions and Events";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Welcome to Contact Us";

            return View();
        }
    }
}