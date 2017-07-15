using ResumeWorkspace.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ResumeWorkspace.Controllers
{
    public class EducationController : Controller
    {
        private Context db = new Context();

        //Affiliation

        public ActionResult AddEducation()
        {
            var temp = new Education() { };
            return View("~/Views/Education/AddEducation.cshtml", temp);
        }

        [HttpPost]
        public ActionResult AddEducation(Education education)
        {
            //Includes PersonId for Employment Addition
            Person myPerson = db.Person.SingleOrDefault(user => user.Id == 1);
            myPerson.AddEducation(education);

            db.AddEducation(education);
            return RedirectToAction("About", "Home");
        }

        public ActionResult EditEducation(int? id)
        {
            if (id == null) { return new HttpStatusCodeResult(HttpStatusCode.BadRequest); }

            Education education = db.GetEducation((int)id);

            if (education == null) { return HttpNotFound(); }

            return View("~/Views/Education/EditEducation.cshtml", education);
        }

        [HttpPost]
        public ActionResult EditEducation(Education education)
        {
            db.EditEducation(education);
            db.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        public ActionResult DeleteEducation(int? id)
        {
            if (id == null) { return new HttpStatusCodeResult(HttpStatusCode.BadRequest); }

            Education education = db.GetEducation((int)id);

            if (education == null) { return HttpNotFound(); }

            db.DeleteEducation(education);
            db.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}