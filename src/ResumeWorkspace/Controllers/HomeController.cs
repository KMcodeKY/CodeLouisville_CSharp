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
        private static Context db = new Context();

        //MVC example set up for one user experience
        Person myPerson = db.Person.SingleOrDefault(user => user.Id == 1);

        public object MessageBox { get; private set; }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            var perList = db.Person.ToList();
            return View(perList);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult AddEmployment()
        {
            var temp = new Employment() {};
            return View(temp);
        }

        [HttpPost]
        public ActionResult AddEmployment(Employment employment)
        {
            //Includes PersonId for Employment Addition
            myPerson.AddEmployment(employment);

            db.AddEmployment(employment);
            return RedirectToAction("Index");
        }

        public ActionResult EditEmployment(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Employment employment = db.GetEmployment((int)id);

            if (employment == null)
            {
                return HttpNotFound();
            }

            return View(employment);
        }

        [HttpPost]
        public ActionResult EditEmployment(Employment employment)
        {
            db.EditEmployment(employment);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteEmployment(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Employment employment = db.GetEmployment((int)id);

            if (employment == null)
            {
                return HttpNotFound();
            }

            return View(employment);
        }

        [HttpPost]
        public ActionResult DeleteEmployment(Employment employment)
        {
            db.DeleteEmployment(employment);
            db.SaveChanges();
            return RedirectToAction("Index");
        }



    }
}