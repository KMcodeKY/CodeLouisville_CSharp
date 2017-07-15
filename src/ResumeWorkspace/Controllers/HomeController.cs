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
            Person myPerson = db.Person.SingleOrDefault(user => user.Id == 1);
            //var perList = db.Person.ToList();
            return View("~/Views/Home/Index.cshtml", myPerson);
        }

        public ActionResult About()
        {
            Person myPerson = db.Person.SingleOrDefault(user => user.Id == 1);
            //var perList = db.Person.ToList();
            return View("~/Views/Home/About.cshtml", myPerson);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View("~/Views/Home/Contact.cshtml");
        }

    }
}