using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AmexBtcSolution.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View("Index");
        }

        public ActionResult AboutUs()
        {
            return View("About");
        }

        public ActionResult ContactUs()
        {
            return View("Contact");
        }

        public ActionResult Opportunity()
        {
            return View("Opportunity");
        }

        public ActionResult Login()
        {
            return View("Login");
        }

        public ActionResult Registration()
        {
            return View("Registration");
        }
    }
}