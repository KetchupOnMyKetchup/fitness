using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fitness.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Fitness website designed to.. ";

            return View();
        }

        public ActionResult Articles()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Recipes()
        {
            ViewBag.Message = "Your recipes page.";

            return View();
        }

        public ActionResult Exercises()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Forum()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}