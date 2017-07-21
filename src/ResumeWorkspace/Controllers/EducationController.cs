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

        //Education

        public ActionResult AddEducation()
        {
            var temp = new Education() { };
            temp.StartDate = DateTime.Now;
            temp.GPA = 0.00;
            return View("~/Views/Education/AddEducation.cshtml", temp);
        }

        [HttpPost]
        public ActionResult AddEducation(Education education)
        {
            //Includes PersonId for Employment Addition
            Person myPerson = db.Person.SingleOrDefault(user => user.Id == 1);

            if (ModelState.IsValid)
            {
                myPerson.AddEducation(education);
                db.AddEducation(education);
                return RedirectToAction("About", "Home");
            } else {
                return View("~/Views/Education/AddEducation.cshtml", education);
            }
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

            if (ModelState.IsValid)
            {
                db.EditEducation(education);
                db.SaveChanges();
                return RedirectToAction("About", "Home");
            } else {
                return View("~/Views/Education/EditEducation.cshtml", education);
            }
        }

        public ActionResult DeleteEducation(int? id)
        {
            if (id == null) { return new HttpStatusCodeResult(HttpStatusCode.BadRequest); }

            Education education = db.GetEducation((int)id);

            if (education == null) { return HttpNotFound(); }

            return View("~/Views/Education/DeleteEducation.cshtml", education);
        }

        [HttpPost]
        public ActionResult DeleteEducation(Education education)
        {
            db.DeleteEducation(education);
            db.SaveChanges();
            return RedirectToAction("About", "Home");
        }

    }
}