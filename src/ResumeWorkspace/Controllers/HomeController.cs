using ResumeWorkspace.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ResumeWorkspace.Controllers
{
    public class HomeController : Controller
    {
        private Context db = new Context();

        public ActionResult Index()
        {
            return View("~/Views/Home/Index.cshtml");
        }

        public ActionResult About()
        {
            var perList = db.Person.ToList();
            return View("~/Views/Home/About.cshtml", perList);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View("~/Views/Home/Contact.cshtml");
        }

    }
}