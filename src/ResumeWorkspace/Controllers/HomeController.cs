using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ResumeWorkspace.Controllers
{
    public class HomeController : Controller
    {
        private Context db = new Context();

        public ActionResult Index()
        {
            var empList = db.Employment.ToList();
            var eduList = db.Education.ToList();
            return View(empList);
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