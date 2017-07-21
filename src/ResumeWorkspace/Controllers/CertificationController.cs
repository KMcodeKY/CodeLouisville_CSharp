using ResumeWorkspace.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ResumeWorkspace.Controllers
{
    public class CertificationController : Controller
    {
        private Context db = new Context();

        //Certification

        public ActionResult AddCertification()
        {
            var temp = new Certification() { };
            return View("~/Views/Certification/AddCertification.cshtml", temp);
        }

        [HttpPost]
        public ActionResult AddCertification(Certification certification)
        {
            //Includes PersonId for Employment Addition
            Person myPerson = db.Person.SingleOrDefault(user => user.Id == 1);

            if (ModelState.IsValid)
            {
                myPerson.AddCertification(certification);
                db.AddCertification(certification);
                return RedirectToAction("About", "Home");
            } else {
                return View("~/Views/Certification/AddCertification.cshtml", certification);
            }
        }

        public ActionResult EditCertification(int? id)
        {
            if (id == null) { return new HttpStatusCodeResult(HttpStatusCode.BadRequest); }

            Certification certification = db.GetCertification((int)id);

            if (certification == null) { return HttpNotFound(); }

            return View("~/Views/Certification/EditCertification.cshtml", certification);
        }

        [HttpPost]
        public ActionResult EditCertification(Certification certification)
        {
            if (ModelState.IsValid)
            {
                db.EditCertification(certification);
                db.SaveChanges();
                return RedirectToAction("About", "Home");
            } else {
                return View("~/Views/Certification/EditCertification.cshtml", certification);
            }
        }

        public ActionResult DeleteCertification(int? id)
        {
            if (id == null) { return new HttpStatusCodeResult(HttpStatusCode.BadRequest); }

            Certification certification = db.GetCertification((int)id);

            if (certification == null) { return HttpNotFound(); }

            return View("~/Views/Certification/DeleteCertification.cshtml", certification);
        }

        [HttpPost]
        public ActionResult DeleteCertification(Certification certification)
        {
            db.DeleteCertification(certification);
            db.SaveChanges();
            return RedirectToAction("About", "Home");
        }

    }
}